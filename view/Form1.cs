using Classes;
using Microsoft.Win32.SafeHandles;
using SimuladorSegurosResidenciais.controller;
using System;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorSegurosResidenciais
{
    public partial class Form1 : Form
    {
        LoadStates loadStates = new LoadStates();

        public Form1()
        {
            InitializeComponent();
            // Set ErrorProvider's padding
            epvPropertyValue.SetIconPadding(this.mktPropertyValue, 4);
            epvGoodsValue.SetIconPadding(this.mktGoodsValue, 4);
            epvStates.SetIconPadding(this.cbbStates, 4);
            epvCities.SetIconPadding(this.cbbCities, 4);
            epvUserName.SetIconPadding(this.mktUserName, 4);
            epvUserPhone.SetIconPadding(this.mktUserPhone, 4);
            epvUserEmail.SetIconPadding(this.mktUserEmail, 4);
            epvUserZipCode.SetIconPadding(this.mktUserZipCode, 4);
            epvUserStreet.SetIconPadding(this.mktUserStreet, 4);
            epvUserNumber.SetIconPadding(this.mktUserNumber, 4);
            epvUserNeighborhood.SetIconPadding(this.mktUserNeighborhood, 4);
            epvUserCity.SetIconPadding(this.mktUserCity, 4);
            epvUserStateAcronym.SetIconPadding(this.mktUserStateAcronym, 4);
            // Fill State Combobox            
            foreach (var state in loadStates.getStates())
            {                
                if (!cbbStates.Items.Contains(state.getName().ToUpper()))
                {
                    cbbStates.Items.Add(state.getName().ToUpper());
                }  
            }
            cbbStates.Text = "Selecionar";
            cbbCities.Enabled = false;            
        }

        private bool validateMaskedTextBoxCurrency(MaskedTextBox mkt, ErrorProvider epv)
        {
            Double inputValue;
            mkt.Text = mkt.Text.Replace("R$ ", "");
            if (Double.TryParse(mkt.Text, out inputValue))
            {
                mkt.Text = String.Format("{0:C2}", inputValue);
                epv.Icon = Properties.Resources.valid_ic;
                epv.SetError(mkt, "Valor válido!");
                return true;
            }                        
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(mkt, "Valor inválido!");
            mkt.Text = String.Empty;
            return false;
        }

        private bool validateMaskedTextBoxLength(MaskedTextBox mkt, ErrorProvider epv, int minLength, int maxLength)
        {
            if (mkt.Text.Length >= minLength && mkt.Text.Length <= maxLength)
            {
                epv.Icon = Properties.Resources.valid_ic;
                epv.SetError(mkt, "Entrada válida");
                return true;
            }
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(mkt, "Informe um valor com no mínimo " + minLength + " e no máximo " + maxLength + " caracteres!");
            return false;
        }

        private bool validateMaskedTextBoxPhone(MaskedTextBox mkt, ErrorProvider epv, int minLength, int maxLength)
        {                        
            if (Regex.IsMatch(mkt.Text, @"^\d{" + minLength + "," + maxLength + "}$")) 
            {
                string text = string.Join("", mkt.Text.ToCharArray().Where(Char.IsDigit));
                Int64 value = Int64.Parse(text);
                if (value > 0)
                {
                    mkt.Text = String.Format(text.Length == 10 ? "{0:(##) ####-####}" : "{0:(##) #####-####}", Int64.Parse(text));
                    epv.Icon = Properties.Resources.valid_ic;
                    epv.SetError(mkt, "Telefone válido!");
                    return true;
                }
            }            
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(mkt, "Informe um telefone com no mínimo " + minLength + " e no máximo " + maxLength + " dígitos!");
            mkt.Text = String.Empty;
            return false;
        }

        private bool validateMaskedTextBoxEmail(MaskedTextBox mkt, ErrorProvider epv)
        {
            try
            {
                new System.Net.Mail.MailAddress(mkt.Text);                
                epv.Icon = Properties.Resources.valid_ic;
                epv.SetError(mkt, "E-mail válido!");
                return true;                  
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(mkt, "E-mail inválido!");
            mkt.Text = String.Empty;
            return false;
        }

        private bool validateMaskedTextBoxZipCode(MaskedTextBox mkt, ErrorProvider epv)
        {
            if (Regex.IsMatch(mkt.Text, @"^\d{5}-?\d{3}$"))
            {
                string text = string.Join("", mkt.Text.ToCharArray().Where(Char.IsDigit));
                mkt.Text = text.Substring(0, 5) + "-" + text.Substring(5, 3);
                epv.Icon = Properties.Resources.valid_ic;
                epv.SetError(mkt, "CEP válido!");
                return true;
            }
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(mkt, "CEP inválido!");
            mkt.Text = String.Empty;
            return false;
        }

        private bool validateCombobox(ComboBox cbb, ErrorProvider epv)
        {
            if (cbb.Text.Length > 0 && cbb.Text != "Selecionar" )
            {
                epv.Icon = Properties.Resources.valid_ic;
                epv.SetError(cbb, "Item selecionado válido!");
                return true;
            }
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(cbb, "Item selecionado é inválido!");            
            return false;
        }

        //public async Task<bool> DoTheWorkAsync()
        //{
        //    DialogResult mgb = MessageBox.Show("Aguarde enquanto busca os dados do CeP", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        //    bool finished = await Task.Run(() => changeUserAddressFields());
        //    mgb.Invoke(new Action(() => { mgb.Close(); }));
            
        //    return finished;
        //}

        private bool changeUserAddressFields()
        {           
            if (validateMaskedTextBoxZipCode(mktUserZipCode, epvUserZipCode))
            {
                try
                {
                    int zipCode = int.Parse(string.Join("", mktUserZipCode.Text.ToCharArray().Where(Char.IsDigit)));
                    LoadZipCode loadZipCode = new LoadZipCode(zipCode);
                    if (loadZipCode.isSuccessed())
                    {
                        mktUserStreet.Text = loadZipCode.getStreet();
                        mktUserCity.Text = loadZipCode.getCity();
                        mktUserNeighborhood.Text = loadZipCode.getNeighborhood();
                        mktUserStateAcronym.Text = loadZipCode.getState();                        
                        mktUserStreet.Enabled = false;
                        mktUserNeighborhood.Enabled = false;
                        mktUserCity.Enabled = false;
                        mktUserStateAcronym.Enabled = false;                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                mktUserStreet.Enabled = true;
                mktUserNeighborhood.Enabled = true;
                mktUserCity.Enabled = true;
                mktUserStateAcronym.Enabled = true;
            }
            return true;
        }

            private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Label3_Click(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Label6_Click(object sender, EventArgs e)
        {
        }

        private void MaskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Label15_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void txtPropertyValue_Validating(object sender, CancelEventArgs e)
        {            
        }

        private void txtPropertyValue_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxCurrency(mktPropertyValue, epvPropertyValue);                                           
        }

        private void txtPropertyValue_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtPropertyValue_TextChanged(object sender, EventArgs e)
        {            
        }

        private void mktGoodsValue_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxCurrency(mktGoodsValue, epvGoodsValue);            
        }

        private void ckbHasAlarme_CheckedChanged(object sender, EventArgs e)
        {           
        }

        private Property validatePropertyAttributes()
        {            
            double? value = null, goodsValue = null;
            bool? hasAlarme = false;
            bool isValid = true;

            try
            {
                value = double.Parse(mktPropertyValue.Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            }
            catch (Exception ex)
            {
                isValid = false;
                Console.WriteLine(ex.Message);
                MessageBox.Show("Preencha corretamente o campo 'Valor' no grupo 'Imóvel!'", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                goodsValue = double.Parse(mktGoodsValue.Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            } catch (Exception ex)
            {
                isValid = false;
                Console.WriteLine(ex.Message);
                MessageBox.Show("Preencha corretamente o campo 'Valor Bens' no grupo 'Imóvel!'", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
            if (ckbHasAlarme.CheckState == CheckState.Indeterminate)
            {
                isValid = false;    
                MessageBox.Show("Preencha corretamente o campo 'Possui Alarme' no grupo Imóvel!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                hasAlarme = ckbHasAlarme.CheckState == CheckState.Checked ? true : false;
            }
            
            State stateCbb = null;
            if (validateCombobox(cbbStates, epvStates))
            {                
                if (loadStates.getStates().Count > 0)
                {
                    foreach (var state in loadStates.getStates())
                    {
                        if (cbbStates.SelectedItem.ToString() == state.getName())
                        {
                            stateCbb = state;
                            break;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Escolha o estado (UF) do 'Imóvel!'", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            City cityCbb = null;
            if (validateCombobox(cbbCities, epvCities) && stateCbb != null)
            {   
                if (stateCbb.getCities().Count > 0)
                {
                    foreach (var city in stateCbb.getCities())
                    {
                        if (cbbCities.SelectedItem.ToString() == city.getName())
                        {
                            cityCbb = city;
                        }
                    }
                }
            } else
            {
                isValid = false;
            }            
            if (isValid)
            {
                Console.WriteLine(cityCbb.getIndividualIndex());
                Property property = new Property((double)value, (double)goodsValue, (bool)hasAlarme, cityCbb);
                return property;
            }
            return null;
        }


        private User validateUserAttributes()
        {
            string name = "", email = "";
            Int64 phone = -1;
            bool isValid = true;
            if (validateMaskedTextBoxLength(mktUserName, epvUserName, 3, 80))
            {
                name = mktUserName.Text;
            } else
            {
                isValid = false;
            }           
            if (validateMaskedTextBoxPhone(mktUserPhone, epvUserPhone, 10, 11))
            {
                try
                {
                    phone = Int64.Parse(string.Join("", mktUserPhone.Text.ToCharArray().Where(Char.IsDigit)));
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isValid = false;
                }
            } else
            {
                isValid = false;
            }
            if (validateMaskedTextBoxEmail(mktUserEmail, epvUserEmail))
            {
                email = mktUserEmail.Text;
            } else
            {
                isValid = false;
            }
            if (isValid)
            {
                //User user = new User(name, phone, email);
                //return user;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mktPropertyValue.Focus();
            mktGoodsValue.Focus();
            cbbStates.Focus();
            if (!cbbCities.Enabled)
            {
                cbbCities.Enabled = true;
                cbbCities.Focus();
                cbbCities.Enabled = false;
            } else
            {
                cbbCities.Focus();
            }            
            mktUserName.Focus();
            bool isValid = validateMaskedTextBoxCurrency(mktPropertyValue, epvPropertyValue)
                && validateMaskedTextBoxCurrency(mktGoodsValue, epvGoodsValue) && 
                validateCombobox(cbbStates, epvStates) && validateCombobox(cbbCities, epvCities)
                ;
            // Initialize Model Classes            
            if (isValid)
            {
                Property property = validatePropertyAttributes();
                User user = validateUserAttributes();
                
            }            
        }

        private void loadCbbCities()
        {
            cbbCities.Items.Clear();
            cbbCities.Text = "Selecionar";
            foreach (var state in loadStates.getStates())
            {
                //Console.WriteLine(cbbStates.SelectedItem.ToString());
                if (cbbStates.SelectedItem.ToString() == state.getName().ToUpper())
                {
                    foreach (var city in state.getCities())
                    {
                        if (!cbbCities.Items.Contains(city.getName().ToUpper()))
                        {
                            cbbCities.Items.Add(city.getName().ToUpper());
                        }
                    }
                }
            }            
        }

        private void cbbState_TextChanged(object sender, EventArgs e)
        {
            if (cbbStates.SelectedIndex < 0)
            {
                cbbStates.Text = "Selecionar";
                cbbCities.Enabled = false;
            }
            else
            {
                cbbStates.Text = cbbStates.SelectedText;
                loadCbbCities();
                cbbCities.Enabled = true;
            }
        }

        private void cbbStates_Leave(object sender, EventArgs e)
        {
            validateCombobox(cbbStates, epvStates);
        }

        private void cbbCities_Leave(object sender, EventArgs e)
        {
            validateCombobox(cbbCities, epvCities);
        }

        private void mktUserName_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxLength(mktUserName, epvUserName, 3, 80);
        }

        private void mktUserPhone_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxPhone(mktUserPhone, epvUserPhone, 10, 11);
            
        }

        private void mktUserEmail_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxEmail(mktUserEmail, epvUserEmail);
        }

        private void mktUserZipCode_Leave(object sender, EventArgs e)
        {
            changeUserAddressFields();
        }

        private void mktUserZipCode_TextChanged(object sender, EventArgs e)
        {            
        }

        private void mktUserZipCode_Enter(object sender, EventArgs e)
        {            
        }

        private void mktUserZipCode_MouseLeave(object sender, EventArgs e)
        {            
        }

        private void mktUserZipCode_Click(object sender, EventArgs e)
        {            
        }
    }
}
//https://stackoverflow.com/questions/21107782/email-mask-for-maskedtextbox-in-c-sharp
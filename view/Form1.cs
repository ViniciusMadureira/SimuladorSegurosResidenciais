using Classes;
using SimuladorSegurosResidenciais.controller;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
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
            epvPropertyGoodsValue.SetIconPadding(this.mktPropertyGoodsValue, 4);
            epvPropertyStates.SetIconPadding(this.cbbPropertyStates, 4);
            epvPropertyCities.SetIconPadding(this.cbbPropertyCities, 4);
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
                if (!cbbPropertyStates.Items.Contains(state.getName().ToUpper()))
                {
                    cbbPropertyStates.Items.Add(state.getName().ToUpper());
                }  
            }
            cbbPropertyStates.Text = "Selecionar";
            cbbPropertyCities.Enabled = false;            
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
            mkt.Text = "";
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(mkt, "Informe um valor com no mínimo " + minLength + " e no máximo " + maxLength + " caracteres!");
            return false;
        }

        private bool validateMaskedTextBoxDigit(MaskedTextBox mkt, ErrorProvider epv, int min, int max)
        {
            if (Regex.IsMatch(mkt.Text, @"^\d+$"))
            {
                Int64 number = Int64.Parse(mkt.Text);
                if (number >= min && number <= max)
                {
                    epv.Icon = Properties.Resources.valid_ic;
                    epv.SetError(mkt, "Entrada válida");
                    return true;
                }
            }
            mkt.Text = "";
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(mkt, "Informe um valor entre " + min + " e " + max + "!");
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
                        mktUserNumber.Focus();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }           
            return true;
        }

        private void clearFormFields()
        {
            mktPropertyValue.Text = "";
            epvPropertyValue.Clear();
            mktPropertyGoodsValue.Text = "";
            epvPropertyGoodsValue.Clear();
            ckbPropertyHasAlarme.Checked = false;
            cbbPropertyCities.SelectedIndex = -1;
            epvPropertyCities.Clear();
            cbbPropertyCities.Text = "";
            cbbPropertyStates.SelectedIndex = -1;
            epvPropertyStates.Clear();
            cbbPropertyStates.Text = "Selecionar";
            mktUserName.Text = "";
            epvUserName.Clear();
            mktUserPhone.Text = "";
            epvUserPhone.Clear();
            mktUserEmail.Text = "";
            epvUserEmail.Clear();
            mktUserZipCode.Text = "";
            epvUserZipCode.Clear();
            mktUserStreet.Text = "";
            epvUserStreet.Clear();
            mktUserNumber.Text = "";
            epvUserNumber.Clear();
            mktUserNeighborhood.Text = "";
            epvUserNeighborhood.Clear();
            mktUserCity.Text = "";
            epvUserCity.Clear();
            mktUserStateAcronym.Text = "";
            epvUserStateAcronym.Clear();
            mktInsuranceMonthlyPay.Clear();
            mktInsuranceFranchise.Clear();
            ckbInsuranceTheft.Checked = false;
            ckbInsuranceDisasters.Checked = false;            
            mktPropertyValue.Focus();
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
            validateMaskedTextBoxCurrency(mktPropertyGoodsValue, epvPropertyGoodsValue);            
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
                goodsValue = double.Parse(mktPropertyGoodsValue.Text.Replace("R$ ", "").Replace(".", "").Replace(",", "."));
            } catch (Exception ex)
            {
                isValid = false;
                Console.WriteLine(ex.Message);
                MessageBox.Show("Preencha corretamente o campo 'Valor Bens' no grupo 'Imóvel!'", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
            if (ckbPropertyHasAlarme.CheckState == CheckState.Indeterminate)
            {
                isValid = false;    
                MessageBox.Show("Preencha corretamente o campo 'Possui Alarme' no grupo Imóvel!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                hasAlarme = ckbPropertyHasAlarme.CheckState == CheckState.Checked ? true : false;
            }
            
            State stateCbb = null;
            if (validateCombobox(cbbPropertyStates, epvPropertyStates))
            {                
                if (loadStates.getStates().Count > 0)
                {
                    foreach (var state in loadStates.getStates())
                    {
                        if (cbbPropertyStates.SelectedItem.ToString() == state.getName())
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
            if (validateCombobox(cbbPropertyCities, epvPropertyCities) && stateCbb != null)
            {   
                if (stateCbb.getCities().Count > 0)
                {
                    foreach (var city in stateCbb.getCities())
                    {
                        if (cbbPropertyCities.SelectedItem.ToString() == city.getName())
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
            string name = "", email = "", street = "", neighborhood = "", city = "", stateAcronym = "";
            Int64 phone = -1, number = -1;
            bool isValid = true;
            if (validateMaskedTextBoxLength(mktUserName, epvUserName, 3, 80))
            {
                name = mktUserName.Text.Trim();
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
                email = mktUserEmail.Text.Trim();
            } else
            {
                isValid = false;
            }
            if (validateMaskedTextBoxDigit(mktUserNumber, epvUserNumber, 0, 9999999))
            {
                number = Int64.Parse(mktUserNumber.Text.Trim());
            } else
            {
                isValid = false;
            }
            if (validateMaskedTextBoxLength(mktUserStreet, epvUserStreet, 2, 30))
            {
                street = mktUserStreet.Text.Trim();
            } else
            {
                isValid = false;
            }
            if (validateMaskedTextBoxLength(mktUserNeighborhood, epvUserNeighborhood, 2, 30))
            {
                neighborhood = mktUserNeighborhood.Text.Trim();
            } else 
            {
                isValid = false;
            }
            if (validateMaskedTextBoxLength(mktUserCity, epvUserCity, 2, 30))
            {
                city = mktUserCity.Text.Trim();
            } else
            {
                isValid = false;
            }
            if (validateMaskedTextBoxLength(mktUserStateAcronym, epvUserStateAcronym, 2, 2) && Regex.IsMatch(mktUserStateAcronym.Text, @"^[a-zA-Z]{2}$")) {
                stateAcronym = mktUserStateAcronym.Text.ToUpper();
            }
            if (isValid)
            {
               User user = new User(name, phone, email, street, number, neighborhood, city, stateAcronym);
               return user;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mktPropertyValue.Focus();
            mktPropertyGoodsValue.Focus();
            cbbPropertyStates.Focus();
            if (!cbbPropertyCities.Enabled)
            {
                cbbPropertyCities.Enabled = true;
                cbbPropertyCities.Focus();
                cbbPropertyCities.Enabled = false;
            } else
            {
                cbbPropertyCities.Focus();
            }            
            mktUserName.Focus();
            bool isValid = validateMaskedTextBoxCurrency(mktPropertyValue, epvPropertyValue)
                && validateMaskedTextBoxCurrency(mktPropertyGoodsValue, epvPropertyGoodsValue) && 
                validateCombobox(cbbPropertyStates, epvPropertyStates) && validateCombobox(cbbPropertyCities, epvPropertyCities)
                ;
            // Initialize Model's Classes
            if (isValid)
            {
                Property property = validatePropertyAttributes();
                User user = validateUserAttributes();                
            }            
        }

        private void loadCbbCities()
        {
            cbbPropertyCities.Items.Clear();
            cbbPropertyCities.Text = "Selecionar";
            foreach (var state in loadStates.getStates())
            {
                //Console.WriteLine(cbbStates.SelectedItem.ToString());
                if (cbbPropertyStates.SelectedItem.ToString() == state.getName().ToUpper())
                {
                    foreach (var city in state.getCities())
                    {
                        if (!cbbPropertyCities.Items.Contains(city.getName().ToUpper()))
                        {
                            cbbPropertyCities.Items.Add(city.getName().ToUpper());
                        }
                    }
                }
            }            
        }

        private void cbbState_TextChanged(object sender, EventArgs e)
        {
            if (cbbPropertyStates.SelectedIndex < 0)
            {
                cbbPropertyStates.Text = "Selecionar";
                cbbPropertyCities.Enabled = false;
            }
            else
            {
                cbbPropertyStates.Text = cbbPropertyStates.SelectedText;
                loadCbbCities();
                cbbPropertyCities.Enabled = true;
            }
        }

        private void cbbStates_Leave(object sender, EventArgs e)
        {
            validateCombobox(cbbPropertyStates, epvPropertyStates);
        }

        private void cbbCities_Leave(object sender, EventArgs e)
        {
            validateCombobox(cbbPropertyCities, epvPropertyCities);
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

        private void mktUserStreet_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxLength(mktUserStreet, epvUserStreet, 2, 30);
        }

        private void mktUserNeighborhood_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxLength(mktUserNeighborhood, epvUserNeighborhood, 2, 30);
        }

        private void mktUserCity_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxLength(mktUserCity, epvUserCity, 2, 30);
        }

        private void mktUserStateAcronym_Leave(object sender, EventArgs e)
        {
            if (validateMaskedTextBoxLength(mktUserStateAcronym, epvUserStateAcronym, 2, 2) && Regex.IsMatch(mktUserStateAcronym.Text, @"^[a-zA-Z]{2}$"))
            {
                mktUserStateAcronym.Text = mktUserStateAcronym.Text.ToUpper();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFormFields();
        }

        private void mktUserNumber_Leave(object sender, EventArgs e)
        {
            validateMaskedTextBoxDigit(mktUserNumber, epvUserNumber, 0, 9999999);
        }
    }
}
//https://stackoverflow.com/questions/21107782/email-mask-for-maskedtextbox-in-c-sharp
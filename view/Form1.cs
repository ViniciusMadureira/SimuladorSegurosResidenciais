using Classes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorSegurosResidenciais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            epvPropertyValue.SetIconPadding(this.mktPropertyValue, 4);
            epvGoodsValue.SetIconPadding(this.mktGoodsValue, 4);            
        }

        private bool validateMaskedTextBoxCurrency(MaskedTextBox mkt, ErrorProvider epv)
        {
            Double inputValue;
            mkt.Text = mkt.Text.Replace("R$ ", "");
            if (Double.TryParse(mkt.Text, out inputValue))
            {
                mkt.Text = String.Format("{0:C2}", inputValue);
                epv.Icon = Properties.Resources.valid_ic;
                epv.SetError(mkt, "Entrada válida!");
                return true;
            }            
            Console.WriteLine(mkt.Text);
            epv.Icon = Properties.Resources.invalid_ic;
            epv.SetError(mkt, "Entrada inválida!");
            mkt.Text = String.Empty;
            return false;
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
            Console.WriteLine(ckbHasAlarme.Checked);
            //switch (ckbHasAlarme.CheckState)
            //{
            //    case CheckState.Checked:
            //        // Code for checked state.  
            //        break;
            //    case CheckState.Unchecked:
            //        // Code for unchecked state.  
            //        break;
            //    case CheckState.Indeterminate:
            //        // Code for indeterminate state.  
            //        break;
            //}
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
            if (isValid)
            {                
                Property property = new Property((double)value, (double)goodsValue, (bool)hasAlarme);
                return property;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = validateMaskedTextBoxCurrency(mktPropertyValue, epvPropertyValue)
                && validateMaskedTextBoxCurrency(mktGoodsValue, epvGoodsValue);
            // Initialize Model Classes                  
            if (isValid)
            {
                validatePropertyAttributes();
            }            
        }
    }
}
//https://stackoverflow.com/questions/21107782/email-mask-for-maskedtextbox-in-c-sharp
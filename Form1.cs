using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                Double value;
                tbxPropertyValue.Text = tbxPropertyValue.Text.Replace("R$ ", "");
                if (Double.TryParse(tbxPropertyValue.Text, out value))
                {
                    tbxPropertyValue.Text = String.Format("{0:C2}", value);                    
                    epvPropertyValue.Icon = Properties.Resources.valid_ic;
                    epvPropertyValue.SetError(tbxPropertyValue, "Entrada válida!");
                }
                else
                {
                    Console.WriteLine(tbxPropertyValue.Text);
                    epvPropertyValue.Icon = Properties.Resources.invalid_ic;
                    epvPropertyValue.SetError(tbxPropertyValue, "Entrada inválida!");
                    tbxPropertyValue.Text = String.Empty;
                }                                  
        }

        private void txtPropertyValue_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtPropertyValue_TextChanged(object sender, EventArgs e)
        {            
        }
    }
}
//https://stackoverflow.com/questions/21107782/email-mask-for-maskedtextbox-in-c-sharp
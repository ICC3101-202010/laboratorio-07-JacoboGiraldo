using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio07
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void AcBtn_Click(object sender, EventArgs e)
        {
            ActualTxt.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ActualTxt.Text.Length > 0)
            {
                ActualTxt.Text = ActualTxt.Text.Remove(ActualTxt.Text.Length - 1, 1);
            }
        }

        private void AnsBtn_Click(object sender, EventArgs e)
        {

        }

        private void Num1_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void Num2_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void Num3_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void Num4_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void Num5_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void Num6_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void Num7_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }
        private void Num8_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void Num9_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void Num0_Click(object Numero, EventArgs e)
        {
            ActualTxt.Text += (Numero as Button).Text;
        }

        private void PropSum_Click(object suma, EventArgs e)
        {
            ActualTxt.Text += (suma as Button).Text;
        }

        private void PropRest_Click(object resta, EventArgs e)
        {
            ActualTxt.Text += (resta as Button).Text;
        }

        private void PropMult_Click(object multiplicacion, EventArgs e)
        {
            ActualTxt.Text += (multiplicacion as Button).Text;
        }

        private void PropDiv_Click(object division, EventArgs e)
        {
            ActualTxt.Text += (division as Button).Text;
        }

        private void PropResul_Click(object sender, EventArgs e)
        {
            
        }
    }
}

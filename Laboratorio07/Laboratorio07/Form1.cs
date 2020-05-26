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
            int Ultimo = Ans.Count();
            ActualTxt.Text += Ans[Ultimo - 1];
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
        List<string> Ans = new List<string>();
        List<string> Historial = new List<string>();
        private void PropResul_Click(object sender, EventArgs e)
        {
            List<double> PreResultados = new List<double>();
            if (ActualTxt.Text.Contains("+"))
            {
                double ResultadoSum = 0;
                try
                {
                    PreResultados = ActualTxt.Text.Split('+').Select(double.Parse).ToList();
                    for (int cont = 0; cont < PreResultados.Count(); cont++)
                    {
                        ResultadoSum += PreResultados[cont];
                    }
                    ActualTxt.Text = ResultadoSum.ToString();
                    Ans.Add(ResultadoSum.ToString());
                }
                catch(FormatException)
                {
                    ActualTxt.Text = "Syntax ERROR";
                }
                
            }
            if (ActualTxt.Text.Contains("-"))
            {
                try
                {
                    PreResultados = ActualTxt.Text.Split('-').Select(double.Parse).ToList();
                    double ResultadoRest = PreResultados[0];
                    for (int cont = 1; cont < PreResultados.Count(); cont++)
                    {
                        ResultadoRest -= PreResultados[cont];
                    }
                    ActualTxt.Text = ResultadoRest.ToString();
                    Ans.Add(ResultadoRest.ToString());
                }
                catch(FormatException)
                {
                    ActualTxt.Text = "Syntax ERROR";
                }
            }
            if (ActualTxt.Text.Contains("x"))
            {
                try
                {
                    PreResultados = ActualTxt.Text.Split('x').Select(double.Parse).ToList();
                    double ResultadoMult = PreResultados[0];
                    for (int cont = 1; cont < PreResultados.Count(); cont++)
                    {
                        ResultadoMult *= PreResultados[cont];
                    }
                    ActualTxt.Text = ResultadoMult.ToString();
                    Ans.Add(ResultadoMult.ToString());
                }
                catch(FormatException)
                {
                    ActualTxt.Text = "Syntax ERROR";
                }


            }
            if (ActualTxt.Text.Contains("÷"))
            {
                try
                {
                    PreResultados = ActualTxt.Text.Split('÷').Select(double.Parse).ToList();
                    double ResultadoDiv = PreResultados[0];
                    for (int cont = 1; cont < PreResultados.Count(); cont++)
                    {
                        ResultadoDiv /= PreResultados[cont];
                    }
                    if (ResultadoDiv.ToString() == "∞")
                    {
                        ActualTxt.Text = "Math ERROR";
                    }
                    else
                    {
                        ActualTxt.Text = ResultadoDiv.ToString();
                        Ans.Add(ResultadoDiv.ToString());
                    }
                }
                catch (FormatException)
                {
                    ActualTxt.Text = "Syntax ERROR";
                }
            }
        }

        private void Sep_Decimal_Click(object punto, EventArgs e)
        {
            ActualTxt.Text += (punto as Button).Text;
        }
    }
}

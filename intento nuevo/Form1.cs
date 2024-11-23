using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intento_nuevo
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }
        private void agregar_num(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (RESU.Text == "0")
                RESU.Text = "";

            RESU.Text += boton.Text;
        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(RESU.Text);

            if (operador == '+')
            {

                RESU.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(RESU.Text);
            }
            else if (operador == '-')
            {
                RESU.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(RESU.Text);
            }

            else if (operador == '*')
            {
                RESU.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(RESU.Text);
            }

            else if (operador == '/')
            {
                RESU.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(RESU.Text);
            }
        }

        private void dltone_Click(object sender, EventArgs e)
        {
            if (RESU.Text.Length > 1)
            {
                RESU.Text = RESU.Text.Substring(0, RESU.Text.Length -1);
            }
            else RESU.Text = "0";
        
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            RESU.Text = "0";
        }

        private void borrapar_Click(object sender, EventArgs e)
        {
            RESU.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!RESU.Text.Contains("."))
            {
                RESU.Text += ".";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(RESU.Text);
            num1 *= -1;
            RESU.Text = num1.ToString();
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(RESU.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                num1 = Math.Pow(num1, 2);
                RESU.Text = num1.ToString();

            }

            else if (operador == '√')
            {
                num1 = Math.Sqrt(num1);
                RESU.Text = num1.ToString();

            }

            else if (operador == '³')
            {

                num1 = Math.Pow(num1, 1.0 / 3.0);
                RESU.Text = num1.ToString();
            }

            
            

            else

                RESU.Text = "0";
        }



    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_3_LAB_POO
{
    public partial class aritmetica : Form
    {
        double primero;
        double segundo;
        string operador;
        public aritmetica()
        {
            InitializeComponent();
        }
        Clases_Aritmetica._Suma obj = new Clases_Aritmetica._Suma();
        Clases_Aritmetica._Resta obj1 = new Clases_Aritmetica._Resta();
        Clases_Aritmetica._Division obj2 = new Clases_Aritmetica._Division();
        Clases_Aritmetica._Multiplicacion obj3 = new Clases_Aritmetica._Multiplicacion();

        private void button17_Click(object sender, EventArgs e)
        {
            MenuPrincipal regresar = new MenuPrincipal();
            this.Hide();
            regresar.Show();
        }

        private void aritmetica_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtResultado.Text);
            double sum, res, mult, div;

            switch (operador)
            {
                case "+":
                    sum = obj.Sumar((primero), (segundo));
                    txtResultado.Text = sum.ToString();
                    break;
                case "-":
                    res = obj1.Restar((primero), (segundo));
                    txtResultado.Text = res.ToString();
                    break;
                case "*":
                    mult = obj3.Multiplicar((primero), (segundo));
                    txtResultado.Text = mult.ToString();
                    break;
                case "/":
                    div = obj2.Dividir((primero), (segundo));
                    txtResultado.Text = div.ToString();
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length == 1)
                txtResultado.Text = "";
            else
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }
    }
}

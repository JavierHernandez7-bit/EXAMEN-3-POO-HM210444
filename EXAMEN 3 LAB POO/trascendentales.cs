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
    public partial class trascendentales : Form
    {
        bool inicio = true;
        double primero;
        double segundo;
        double resultado;
        string operador;
        public trascendentales()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt2.Text = txt2.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
                MenuPrincipal regresar = new MenuPrincipal();
            this.Hide();
            regresar.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txt2.Text);
            resultado = primero;
            txt1.Text = "cos (" + txt1.Text + txt2.Text + ")";
            txt2.Text = Math.Cos(primero).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txt2.Text);
            resultado = primero;
            txt1.Text = "sin (" + txt1.Text + txt2.Text + ")";
            txt2.Text = Math.Sin(primero).ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txt2.Text);
            resultado = primero;
            txt1.Text = "tan (" + txt1.Text + txt2.Text + ")";
            txt2.Text = Math.Tan(primero).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

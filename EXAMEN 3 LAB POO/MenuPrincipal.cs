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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            traductor ir = new traductor();
            this.Hide();
            ir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aritmetica calculo_arit = new aritmetica();
            this.Hide();
            calculo_arit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trascendentales calcu_tras = new trascendentales();
            this.Hide();
            calcu_tras.Show();
        }
    }
}

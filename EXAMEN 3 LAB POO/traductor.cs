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
    public partial class traductor : Form
    {
        traductorClase trad = new traductorClase();
        public traductor()
        {
            InitializeComponent();
        }

        private void bntTraducir_Click(object sender, EventArgs e)
        {
            trad.Ingreso = txt1Español.Text;
            txt2Ingles.Text = trad.traduce();

            if (!trad.encontrar)
            {
                MessageBox.Show("Se solicita corroborar los datos introducidos");
                txt1Español.Clear();
                txt2Ingles.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt2Ingles.Clear();
            txt1Español.Clear();
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnRegresar_Click(object sender, EventArgs e)
        { 
            MenuPrincipal regresar = new MenuPrincipal();
            this.Hide();
            regresar.Show();
        }

        private void traductor_Load(object sender, EventArgs e)
        {

        }
    }
}  


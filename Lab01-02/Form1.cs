using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = txtDn.Text;
            string nombre = txtN.Text;
            string apellido = txtA.Text;
            string direccion = txtD.Text;
            string telefono = txtT.Text;
            string email = txtE.Text;
            string nacimiento = dtpDate.Text;
            string departamento = cbD.Text;
            string cargo = cbCargo.Text;
            string codigo = txtCode.Text;


            dgvTabla.Rows.Add(nombre, apellido, codigo, dni, direccion, telefono, email, nacimiento, departamento, cargo);
        }
    }
}

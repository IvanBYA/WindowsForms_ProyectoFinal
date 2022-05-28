using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PIA_Progra
{
    public partial class login : Form
    {
        frmInicio inicio;

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // administrador
            if ((txtUsuario.Text == "laesperanza") && (txtContra.Text == "1903845"))
            {
                inicio = new frmInicio();
                inicio.Show();
                this.Hide();
            }
            else if ((txtContra.Text == "") && (txtUsuario.Text == ""))
            {
                MessageBox.Show("Favor de llenar ambos campos", "Campo usuario y contraseña vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor ingresa el usuario", "Campo usuario vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtContra.Text == "")
            {
                MessageBox.Show("Por favor ingresa la contraseña", "Campo contraseña vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsuario.Text != "laesperanza")
            {
                MessageBox.Show("El usuario es incorrecto, intentalo de nuevo", "Usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtContra.Text != "1903845")
            {
                MessageBox.Show("La contraseña es incorrecta, intentalo de nuevo", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {


        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            //Contraseña con asteriscos
            txtContra.PasswordChar = '*';
            // Longitud maxima de 3 caracteres
            //txtContra.MaxLength = 3;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblMsjErrorUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged_1(object sender, EventArgs e)
        {
            txtContra.PasswordChar = '*';
        }
    }
}

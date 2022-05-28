using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PIA_Progra
{
    public partial class frmInicio : Form
    {

        login login;




        public frmInicio()
        {
            InitializeComponent();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToString("dddd, dd MMMM yyyy");

            // Apenas cargue el programa, verificará si existe el txt
            // Cambiar aqui tu ruta
            if(!File.Exists("C:\\Users\\Ceci_\\OneDrive\\Documentos\\FACPYA\\6 SEMESTRE\\Programación\\DatosCitas.txt"))
            {
                // Guardar en esta ruta un txt
                // Cambiar aqui tu ruta
                StreamWriter sw = new StreamWriter("C:\\Users\\Ceci_\\OneDrive\\Documentos\\FACPYA\\6 SEMESTRE\\Programación\\DatosCitas.txt");
                sw.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellidoPat.Text == "" || txtApellidoMat.Text == "" || nudEdad.Text == "" || txtTelefono.Text == "" || txtrMotivo.Text == "" || txtrSinto.Text == "" || txtDoctor.Text == "" || txtCedula.Text == "" || txtrDiag.Text == "" || txtrTrata.Text == "")
            {
                MessageBox.Show("Es necesario llenar todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                // metodo grabar datos en txt
                GrabarDatos();

                int n = dgvRegistros.Rows.Add();
                dgvRegistros.Rows[n].Cells[0].Value = txtDoctor.Text;
                dgvRegistros.Rows[n].Cells[1].Value = txtCedula.Text;
                dgvRegistros.Rows[n].Cells[2].Value = txtNombre.Text;
                dgvRegistros.Rows[n].Cells[3].Value = txtApellidoPat.Text;
                dgvRegistros.Rows[n].Cells[4].Value = txtApellidoMat.Text;
                dgvRegistros.Rows[n].Cells[5].Value = nudEdad.Text;
                dgvRegistros.Rows[n].Cells[6].Value = txtTelefono.Text;
                dgvRegistros.Rows[n].Cells[7].Value = txtrMotivo.Text;
                dgvRegistros.Rows[n].Cells[8].Value = txtrSinto.Text;
                dgvRegistros.Rows[n].Cells[9].Value = txtrDiag.Text;
                dgvRegistros.Rows[n].Cells[10].Value = txtrTrata.Text;

                // Ver la manera de usar un boton para imprimir lo del datagrid view
            }
        }

        private void GrabarDatos()
        {
            // Cambiar aqui tu ruta
            StreamWriter sw = new StreamWriter("C:\\Users\\Ceci_\\OneDrive\\Documentos\\FACPYA\\6 SEMESTRE\\Programación\\DatosCitas.txt", true);

            sw.WriteLine("==========================================");
            sw.WriteLine("                 Paciente                 ");
            sw.WriteLine("==========================================");
            sw.WriteLine("Doctor: " + txtDoctor.Text);
            sw.WriteLine("Cedula: " + txtCedula.Text);
            sw.WriteLine("");
            sw.WriteLine("Nombre: " + txtNombre.Text);
            sw.WriteLine("Apellido Paterno: "+ txtApellidoPat.Text);
            sw.WriteLine("Apellido Materno: "+ txtApellidoMat.Text);
            sw.WriteLine("Edad: "+ nudEdad.Text);
            sw.WriteLine("Telefono: "+ txtTelefono.Text);
            sw.WriteLine("Motivo: "+ txtrMotivo.Text);
            sw.WriteLine("Sintomas: "+ txtrSinto.Text);
            sw.WriteLine("Diagnostico: "+ txtrDiag.Text);
            sw.WriteLine("Tratamiento: "+txtrTrata.Text);
            sw.WriteLine("==========================================");
            sw.WriteLine("");
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDoctor.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            nudEdad.Text = "";
            txtTelefono.Text = "";
            txtApellidoPat.Text = "";
            txtApellidoMat.Text = "";
            txtrMotivo.Text = "";
            txtrSinto.Text = "";
            txtrDiag.Text = "";
            txtrTrata.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login = new login();
            login.Show();
            this.Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 29)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Nombre' debe ser menor a 30", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.MaxLength = 30;
            }
        }
        private void txtDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nudEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar)&& !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSinto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDiag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTrata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtDoctor.TextLength > 39)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Doctor' debe ser menor a 40", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDoctor.MaxLength = 40;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSinto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTextoFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnNota_Click(object sender, EventArgs e)
        {

        }

        private void nudEdad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtrMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtrSinto_ImeChange(object sender, EventArgs e)
        {

        }

        private void txtrSinto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtrDiag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtrTrata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoPat_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidoPat.TextLength > 29)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Apellido Paterno' debe ser menor a 30", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidoPat.MaxLength = 30;
            }
        }

        private void txtApellidoMat_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidoMat.TextLength > 29)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Apellido Materno' debe ser menor a 30", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.MaxLength = 30;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.TextLength > 11)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Teléfono' debe ser menor a 10 digitos", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.MaxLength = 10;
            }
        }

        private void txtrMotivo_TextChanged(object sender, EventArgs e)
        {
            if (txtrMotivo.TextLength > 119)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Motivo' debe ser menor a 120", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtrMotivo.MaxLength = 120;
            }
        }

        private void txtrSinto_TextChanged(object sender, EventArgs e)
        {
            if (txtrSinto.TextLength > 149)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Sintomas' debe ser menor a 150", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtrSinto.MaxLength = 150;
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.TextLength > 9)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Cedula' debe ser menor a 10", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.MaxLength = 10;
            }
        }

        private void txtrDiag_TextChanged(object sender, EventArgs e)
        {
            if (txtrDiag.TextLength > 399)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Diagnóstico' debe ser menor a 400", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtrDiag.MaxLength = 400;
            }
        }

        private void txtrTrata_TextChanged(object sender, EventArgs e)
        {
            if (txtrTrata.TextLength > 549)
            {
                MessageBox.Show("La longitud de caracteres del campo 'Tratamiento' debe ser menor a 550", "Longitud limite del Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.MaxLength = 550;
            }
        }
    }
}

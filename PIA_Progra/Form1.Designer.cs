
namespace PIA_Progra
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrTrata = new System.Windows.Forms.RichTextBox();
            this.txtrDiag = new System.Windows.Forms.RichTextBox();
            this.txtrSinto = new System.Windows.Forms.RichTextBox();
            this.txtrMotivo = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtApellidoMat = new System.Windows.Forms.TextBox();
            this.txtApellidoPat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.lblAPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTextoFecha = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Síntomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Consultas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrTrata);
            this.groupBox1.Controls.Add(this.txtrDiag);
            this.groupBox1.Controls.Add(this.txtrSinto);
            this.groupBox1.Controls.Add(this.txtrMotivo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblEdad);
            this.groupBox1.Controls.Add(this.nudEdad);
            this.groupBox1.Controls.Add(this.txtApellidoMat);
            this.groupBox1.Controls.Add(this.txtApellidoPat);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblMotivo);
            this.groupBox1.Controls.Add(this.lblAMaterno);
            this.groupBox1.Controls.Add(this.lblAPaterno);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(52, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1252, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtrTrata
            // 
            this.txtrTrata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrTrata.Location = new System.Drawing.Point(668, 115);
            this.txtrTrata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrTrata.Name = "txtrTrata";
            this.txtrTrata.Size = new System.Drawing.Size(557, 292);
            this.txtrTrata.TabIndex = 23;
            this.txtrTrata.Text = "";
            this.txtrTrata.TextChanged += new System.EventHandler(this.txtrTrata_TextChanged);
            this.txtrTrata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrTrata_KeyPress);
            // 
            // txtrDiag
            // 
            this.txtrDiag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrDiag.Location = new System.Drawing.Point(668, 28);
            this.txtrDiag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrDiag.Name = "txtrDiag";
            this.txtrDiag.Size = new System.Drawing.Size(557, 78);
            this.txtrDiag.TabIndex = 22;
            this.txtrDiag.Text = "";
            this.txtrDiag.TextChanged += new System.EventHandler(this.txtrDiag_TextChanged);
            this.txtrDiag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrDiag_KeyPress);
            // 
            // txtrSinto
            // 
            this.txtrSinto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrSinto.Location = new System.Drawing.Point(141, 328);
            this.txtrSinto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrSinto.Name = "txtrSinto";
            this.txtrSinto.Size = new System.Drawing.Size(380, 78);
            this.txtrSinto.TabIndex = 21;
            this.txtrSinto.Text = "";
            this.txtrSinto.ImeChange += new System.EventHandler(this.txtrSinto_ImeChange);
            this.txtrSinto.TextChanged += new System.EventHandler(this.txtrSinto_TextChanged);
            this.txtrSinto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrSinto_KeyPress);
            // 
            // txtrMotivo
            // 
            this.txtrMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrMotivo.Location = new System.Drawing.Point(141, 246);
            this.txtrMotivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtrMotivo.Name = "txtrMotivo";
            this.txtrMotivo.Size = new System.Drawing.Size(380, 68);
            this.txtrMotivo.TabIndex = 20;
            this.txtrMotivo.Text = "";
            this.txtrMotivo.TextChanged += new System.EventHandler(this.txtrMotivo_TextChanged);
            this.txtrMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrMotivo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(570, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tratamiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(53, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Síntomas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(572, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Diagnóstico";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Location = new System.Drawing.Point(141, 210);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(380, 22);
            this.txtTelefono.TabIndex = 13;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(58, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Teléfono";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEdad.Location = new System.Drawing.Point(82, 168);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad";
            // 
            // nudEdad
            // 
            this.nudEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudEdad.Location = new System.Drawing.Point(141, 164);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(380, 25);
            this.nudEdad.TabIndex = 10;
            this.nudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEdad.ValueChanged += new System.EventHandler(this.nudEdad_ValueChanged);
            this.nudEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudEdad_KeyPress);
            // 
            // txtApellidoMat
            // 
            this.txtApellidoMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoMat.Location = new System.Drawing.Point(141, 128);
            this.txtApellidoMat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidoMat.Name = "txtApellidoMat";
            this.txtApellidoMat.Size = new System.Drawing.Size(380, 22);
            this.txtApellidoMat.TabIndex = 6;
            this.txtApellidoMat.TextChanged += new System.EventHandler(this.txtApellidoMat_TextChanged);
            this.txtApellidoMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMat_KeyPress);
            // 
            // txtApellidoPat
            // 
            this.txtApellidoPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPat.Location = new System.Drawing.Point(141, 84);
            this.txtApellidoPat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidoPat.Name = "txtApellidoPat";
            this.txtApellidoPat.Size = new System.Drawing.Size(380, 22);
            this.txtApellidoPat.TabIndex = 5;
            this.txtApellidoPat.TextChanged += new System.EventHandler(this.txtApellidoPat_TextChanged);
            this.txtApellidoPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPat_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(141, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMotivo.Location = new System.Drawing.Point(74, 246);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(55, 20);
            this.lblMotivo.TabIndex = 3;
            this.lblMotivo.Text = "Motivo";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAMaterno.Location = new System.Drawing.Point(5, 128);
            this.lblAMaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(128, 20);
            this.lblAMaterno.TabIndex = 2;
            this.lblAMaterno.Text = "Apellido Materno";
            // 
            // lblAPaterno
            // 
            this.lblAPaterno.AutoSize = true;
            this.lblAPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAPaterno.Location = new System.Drawing.Point(4, 87);
            this.lblAPaterno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAPaterno.Name = "lblAPaterno";
            this.lblAPaterno.Size = new System.Drawing.Size(125, 20);
            this.lblAPaterno.TabIndex = 1;
            this.lblAPaterno.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(64, 47);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1233, 525);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Green;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegistrar.Location = new System.Drawing.Point(1233, 572);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 100);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar y Guardar en TXT";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTextoFecha
            // 
            this.lblTextoFecha.AutoSize = true;
            this.lblTextoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTextoFecha.Location = new System.Drawing.Point(1112, 17);
            this.lblTextoFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextoFecha.Name = "lblTextoFecha";
            this.lblTextoFecha.Size = new System.Drawing.Size(64, 24);
            this.lblTextoFecha.TabIndex = 2;
            this.lblTextoFecha.Text = "Fecha";
            this.lblTextoFecha.Click += new System.EventHandler(this.lblTextoFecha_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(718, 53);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor,
            this.CedProf,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Edad,
            this.Telefono,
            this.Motivo,
            this.Síntomas,
            this.Diagnostico,
            this.Tratamiento});
            this.dgvRegistros.Location = new System.Drawing.Point(27, 525);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.Size = new System.Drawing.Size(1178, 206);
            this.dgvRegistros.TabIndex = 4;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(1240, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegresar.Location = new System.Drawing.Point(27, 9);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(107, 73);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "<   Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(636, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Doctor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDoctor
            // 
            this.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctor.Location = new System.Drawing.Point(702, 24);
            this.txtDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(379, 21);
            this.txtDoctor.TabIndex = 14;
            this.txtDoctor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctor_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(702, 53);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(178, 21);
            this.txtCedula.TabIndex = 14;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(614, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ced. Prof.";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Location = new System.Drawing.Point(1114, 50);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(0, 13);
            this.txtFecha.TabIndex = 15;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            this.Doctor.Width = 125;
            // 
            // CedProf
            // 
            this.CedProf.HeaderText = "CedProf";
            this.CedProf.MinimumWidth = 6;
            this.CedProf.Name = "CedProf";
            this.CedProf.ReadOnly = true;
            this.CedProf.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "AppPaterno";
            this.ApellidoPaterno.MinimumWidth = 6;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            this.ApellidoPaterno.Width = 125;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "AppMaterno";
            this.ApellidoMaterno.MinimumWidth = 6;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            this.ApellidoMaterno.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.MinimumWidth = 6;
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 125;
            // 
            // Síntomas
            // 
            this.Síntomas.HeaderText = "Síntomas";
            this.Síntomas.MinimumWidth = 6;
            this.Síntomas.Name = "Síntomas";
            this.Síntomas.ReadOnly = true;
            this.Síntomas.Width = 125;
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.MinimumWidth = 6;
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            this.Diagnostico.Width = 125;
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.MinimumWidth = 6;
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            this.Tratamiento.Width = 125;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTextoFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Consultas";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellidoMat;
        private System.Windows.Forms.TextBox txtApellidoPat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.Label lblAPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTextoFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.RichTextBox txtrMotivo;
        private System.Windows.Forms.RichTextBox txtrSinto;
        private System.Windows.Forms.RichTextBox txtrDiag;
        private System.Windows.Forms.RichTextBox txtrTrata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Síntomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
    }
}


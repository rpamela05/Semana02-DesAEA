
namespace Lab02_01
{
    partial class manUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpNacimiento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 135);
            this.panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(340, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(340, 42);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 23);
            this.txtApellido.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Apellido";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(340, 10);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(79, 23);
            this.dtpNacimiento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(71, 100);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(422, 23);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(71, 71);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(161, 23);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(71, 13);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(80, 23);
            this.txtDNI.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(124, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.nombre,
            this.telefono,
            this.dirección,
            this.fecNac,
            this.apellido,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(13, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(506, 180);
            this.dataGridView1.TabIndex = 5;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // dirección
            // 
            this.dirección.HeaderText = "Dirección";
            this.dirección.Name = "dirección";
            // 
            // fecNac
            // 
            this.fecNac.HeaderText = "Fecha Nacimiento";
            this.fecNac.Name = "fecNac";
            this.fecNac.Width = 80;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // manUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Name = "manUsuario";
            this.Text = "manUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}
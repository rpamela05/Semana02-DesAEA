
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesos = new System.Windows.Forms.ToolStripMenuItem();
            this.regVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.regCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.repVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.repCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.repInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.repProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.repUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.repClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimiento,
            this.procesos,
            this.reportes,
            this.sistema});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // mantenimiento
            // 
            this.mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimiento.Name = "mantenimiento";
            this.mantenimiento.Size = new System.Drawing.Size(101, 20);
            this.mantenimiento.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.CheckOnClick = true;
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(139, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(139, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(139, 22);
            this.mnuManCategorias.Text = "Categorías";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(139, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(139, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // procesos
            // 
            this.procesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regVentas,
            this.regCompras});
            this.procesos.Name = "procesos";
            this.procesos.Size = new System.Drawing.Size(66, 20);
            this.procesos.Text = "Procesos";
            // 
            // regVentas
            // 
            this.regVentas.Name = "regVentas";
            this.regVentas.Size = new System.Drawing.Size(166, 22);
            this.regVentas.Text = "Registrar Venta";
            // 
            // regCompras
            // 
            this.regCompras.Name = "regCompras";
            this.regCompras.Size = new System.Drawing.Size(166, 22);
            this.regCompras.Text = "Registrar Compra";
            // 
            // reportes
            // 
            this.reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repVentas,
            this.repCompras,
            this.repInventario,
            this.repProveedores,
            this.repUsuarios,
            this.repClientes});
            this.reportes.Name = "reportes";
            this.reportes.Size = new System.Drawing.Size(65, 20);
            this.reportes.Text = "Reportes";
            // 
            // repVentas
            // 
            this.repVentas.Name = "repVentas";
            this.repVentas.Size = new System.Drawing.Size(200, 22);
            this.repVentas.Text = "Reporte de Ventas";
            // 
            // repCompras
            // 
            this.repCompras.Name = "repCompras";
            this.repCompras.Size = new System.Drawing.Size(200, 22);
            this.repCompras.Text = "Reporte de compras";
            // 
            // repInventario
            // 
            this.repInventario.Name = "repInventario";
            this.repInventario.Size = new System.Drawing.Size(200, 22);
            this.repInventario.Text = "Inventario de productos";
            // 
            // repProveedores
            // 
            this.repProveedores.Name = "repProveedores";
            this.repProveedores.Size = new System.Drawing.Size(200, 22);
            this.repProveedores.Text = "Reporte de proveedores";
            // 
            // repUsuarios
            // 
            this.repUsuarios.Name = "repUsuarios";
            this.repUsuarios.Size = new System.Drawing.Size(200, 22);
            this.repUsuarios.Text = "Reporte de usuarios";
            // 
            // repClientes
            // 
            this.repClientes.Name = "repClientes";
            this.repClientes.Size = new System.Drawing.Size(200, 22);
            this.repClientes.Text = "Reporte de clientes";
            // 
            // sistema
            // 
            this.sistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.sistema.Name = "sistema";
            this.sistema.Size = new System.Drawing.Size(60, 20);
            this.sistema.Text = "Sistema";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(158, 22);
            this.mnuSalir.Text = "Salir del sistema";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem procesos;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem regVentas;
        private System.Windows.Forms.ToolStripMenuItem regCompras;
        private System.Windows.Forms.ToolStripMenuItem reportes;
        private System.Windows.Forms.ToolStripMenuItem repVentas;
        private System.Windows.Forms.ToolStripMenuItem repCompras;
        private System.Windows.Forms.ToolStripMenuItem repInventario;
        private System.Windows.Forms.ToolStripMenuItem repProveedores;
        private System.Windows.Forms.ToolStripMenuItem repUsuarios;
        private System.Windows.Forms.ToolStripMenuItem repClientes;
        private System.Windows.Forms.ToolStripMenuItem sistema;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}
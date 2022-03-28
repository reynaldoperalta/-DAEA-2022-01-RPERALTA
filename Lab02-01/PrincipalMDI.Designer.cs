
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
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepInventarioProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuSisSalirSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes,
            this.mnuSalir});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRegistrarVenta,
            this.mnuProRegistrarCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepReporteVentas,
            this.mnuRepReporteCompras,
            this.mnuRepInventarioProductos,
            this.mnuRepReporteProveedores,
            this.mnuRepReporteUsuarios,
            this.mnuRepReporteClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuSisSalirSistema});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuManCategorias.Text = "Categorías";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSalir.Text = "Salir";
            // 
            // mnuProRegistrarVenta
            // 
            this.mnuProRegistrarVenta.Name = "mnuProRegistrarVenta";
            this.mnuProRegistrarVenta.Size = new System.Drawing.Size(180, 22);
            this.mnuProRegistrarVenta.Text = " Registrar Venta";
            // 
            // mnuProRegistrarCompra
            // 
            this.mnuProRegistrarCompra.Name = "mnuProRegistrarCompra";
            this.mnuProRegistrarCompra.Size = new System.Drawing.Size(180, 22);
            this.mnuProRegistrarCompra.Text = " Registrar Compra";
            // 
            // mnuRepReporteVentas
            // 
            this.mnuRepReporteVentas.Name = "mnuRepReporteVentas";
            this.mnuRepReporteVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteVentas.Text = "Reporte de ventas";
            // 
            // mnuRepReporteCompras
            // 
            this.mnuRepReporteCompras.Name = "mnuRepReporteCompras";
            this.mnuRepReporteCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteCompras.Text = "Reporte de compras";
            // 
            // mnuRepInventarioProductos
            // 
            this.mnuRepInventarioProductos.Name = "mnuRepInventarioProductos";
            this.mnuRepInventarioProductos.Size = new System.Drawing.Size(200, 22);
            this.mnuRepInventarioProductos.Text = "Inventario de productos";
            // 
            // mnuRepReporteProveedores
            // 
            this.mnuRepReporteProveedores.Name = "mnuRepReporteProveedores";
            this.mnuRepReporteProveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteProveedores.Text = "Reporte de proveedores";
            // 
            // mnuRepReporteUsuarios
            // 
            this.mnuRepReporteUsuarios.Name = "mnuRepReporteUsuarios";
            this.mnuRepReporteUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteUsuarios.Text = "Reporte de usuarios";
            // 
            // mnuRepReporteClientes
            // 
            this.mnuRepReporteClientes.Name = "mnuRepReporteClientes";
            this.mnuRepReporteClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteClientes.Text = "Reporte de clientes";
            // 
            // nmuSisSalirSistema
            // 
            this.nmuSisSalirSistema.Name = "nmuSisSalirSistema";
            this.nmuSisSalirSistema.Size = new System.Drawing.Size(180, 22);
            this.nmuSisSalirSistema.Text = "Salir del sistema";
            this.nmuSisSalirSistema.Click += new System.EventHandler(this.nmuSisSalirSistema_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 452);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepInventarioProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteClientes;
        private System.Windows.Forms.ToolStripMenuItem nmuSisSalirSistema;
    }
}
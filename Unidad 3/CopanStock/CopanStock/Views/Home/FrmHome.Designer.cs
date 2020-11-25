namespace CopanStock.Views.Home
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new JacksiroKe.MdiTabCtrl.TabControl();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVender = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuProcesos,
            this.mnuMantenimiento,
            this.mnuAyuda});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(972, 32);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Location = new System.Drawing.Point(0, 453);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusBar.Size = new System.Drawing.Size(972, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.MenuRenderer = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(972, 421);
            this.tabControl1.TabCloseButtonImage = null;
            this.tabControl1.TabCloseButtonImageDisabled = null;
            this.tabControl1.TabCloseButtonImageHot = null;
            this.tabControl1.TabIndex = 2;
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Image = global::CopanStock.Properties.Resources.icon_archivo_20px;
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(97, 28);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Image = global::CopanStock.Properties.Resources.icon_salir_20px;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(125, 30);
            this.mnuSalir.Text = "Salir";
            // 
            // mnuProcesos
            // 
            this.mnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVender});
            this.mnuProcesos.Image = global::CopanStock.Properties.Resources.icon_procesos_20px;
            this.mnuProcesos.Name = "mnuProcesos";
            this.mnuProcesos.Size = new System.Drawing.Size(105, 28);
            this.mnuProcesos.Text = "Procesos";
            // 
            // mnuVender
            // 
            this.mnuVender.Image = global::CopanStock.Properties.Resources.icon_vender_20px;
            this.mnuVender.Name = "mnuVender";
            this.mnuVender.Size = new System.Drawing.Size(142, 30);
            this.mnuVender.Text = "Vender";
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCategorias,
            this.mnuProductos});
            this.mnuMantenimiento.Image = global::CopanStock.Properties.Resources.icon_mantenieminto_20px;
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(148, 28);
            this.mnuMantenimiento.Text = "Mantenimiento";
            // 
            // mnuCategorias
            // 
            this.mnuCategorias.Image = global::CopanStock.Properties.Resources.icon_categoria_20px;
            this.mnuCategorias.Name = "mnuCategorias";
            this.mnuCategorias.Size = new System.Drawing.Size(228, 30);
            this.mnuCategorias.Text = "Categorías";
            this.mnuCategorias.Click += new System.EventHandler(this.mnuCategorias_Click);
            // 
            // mnuProductos
            // 
            this.mnuProductos.Image = global::CopanStock.Properties.Resources.icon_producto_20px;
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(228, 30);
            this.mnuProductos.Text = "Productos";
            this.mnuProductos.Click += new System.EventHandler(this.mnuProductos_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.Image = global::CopanStock.Properties.Resources.icon_ayuda_20px;
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(89, 28);
            this.mnuAyuda.Text = "Ayuda";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 475);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopanStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.StatusStrip statusBar;
        private JacksiroKe.MdiTabCtrl.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem mnuVender;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem mnuCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
    }
}


namespace CopanStock.Views.Venta
{
    partial class FrmVentaInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaInsert));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOpciones = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.btnGetCliente = new System.Windows.Forms.Button();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.txtUsuarioId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProductoCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.btnGetProducto = new System.Windows.Forms.Button();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgVentaDetalle = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscarProducto = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscarProducto = new System.Windows.Forms.ToolStripButton();
            this.btnCerrarProductos = new System.Windows.Forms.ToolStripButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabOpciones.SuspendLayout();
            this.tabVenta.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentaDetalle)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuarioNombre);
            this.groupBox1.Controls.Add(this.txtUsuarioId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtClienteNombre);
            this.groupBox1.Controls.Add(this.btnGetCliente);
            this.groupBox1.Controls.Add(this.txtClienteId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CopanStock.Properties.Resources.icon_cancelar_16px;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(153, 591);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CopanStock.Properties.Resources.icon_guardar_16px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(26, 591);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 35);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtClienteId
            // 
            this.txtClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteId.Location = new System.Drawing.Point(232, 30);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(90, 30);
            this.txtClienteId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(56, 30);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(82, 30);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // tabOpciones
            // 
            this.tabOpciones.Controls.Add(this.tabVenta);
            this.tabOpciones.Controls.Add(this.tabProductos);
            this.tabOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOpciones.Location = new System.Drawing.Point(0, 0);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(1088, 676);
            this.tabOpciones.TabIndex = 1;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.label7);
            this.tabVenta.Controls.Add(this.lblTotal);
            this.tabVenta.Controls.Add(this.groupBox3);
            this.tabVenta.Controls.Add(this.groupBox2);
            this.tabVenta.Controls.Add(this.btnCancelar);
            this.tabVenta.Controls.Add(this.btnGuardar);
            this.tabVenta.Controls.Add(this.groupBox1);
            this.tabVenta.Location = new System.Drawing.Point(4, 34);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(1080, 638);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Factura";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.dgProductos);
            this.tabProductos.Controls.Add(this.toolStrip1);
            this.tabProductos.Location = new System.Drawing.Point(4, 34);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(1080, 638);
            this.tabProductos.TabIndex = 1;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // btnGetCliente
            // 
            this.btnGetCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCliente.Image = global::CopanStock.Properties.Resources.icon_buscar_16px;
            this.btnGetCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetCliente.Location = new System.Drawing.Point(328, 30);
            this.btnGetCliente.Name = "btnGetCliente";
            this.btnGetCliente.Size = new System.Drawing.Size(27, 30);
            this.btnGetCliente.TabIndex = 6;
            this.btnGetCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetCliente.UseVisualStyleBackColor = true;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Enabled = false;
            this.txtClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNombre.Location = new System.Drawing.Point(361, 30);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(219, 30);
            this.txtClienteNombre.TabIndex = 7;
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Enabled = false;
            this.txtUsuarioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioNombre.Location = new System.Drawing.Point(765, 30);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(252, 30);
            this.txtUsuarioNombre.TabIndex = 10;
            // 
            // txtUsuarioId
            // 
            this.txtUsuarioId.Enabled = false;
            this.txtUsuarioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioId.Location = new System.Drawing.Point(682, 30);
            this.txtUsuarioId.Name = "txtUsuarioId";
            this.txtUsuarioId.Size = new System.Drawing.Size(77, 30);
            this.txtUsuarioId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtProductoPrecio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtProductoCantidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtProductoNombre);
            this.groupBox2.Controls.Add(this.btnGetProducto);
            this.groupBox2.Controls.Add(this.txtProductoId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(18, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Producto";
            // 
            // txtProductoCantidad
            // 
            this.txtProductoCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoCantidad.Location = new System.Drawing.Point(573, 30);
            this.txtProductoCantidad.Name = "txtProductoCantidad";
            this.txtProductoCantidad.Size = new System.Drawing.Size(90, 30);
            this.txtProductoCantidad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Enabled = false;
            this.txtProductoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoNombre.Location = new System.Drawing.Point(241, 30);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(219, 30);
            this.txtProductoNombre.TabIndex = 7;
            // 
            // btnGetProducto
            // 
            this.btnGetProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetProducto.Image = global::CopanStock.Properties.Resources.icon_buscar_16px;
            this.btnGetProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetProducto.Location = new System.Drawing.Point(208, 30);
            this.btnGetProducto.Name = "btnGetProducto";
            this.btnGetProducto.Size = new System.Drawing.Size(27, 30);
            this.btnGetProducto.TabIndex = 6;
            this.btnGetProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetProducto.UseVisualStyleBackColor = true;
            this.btnGetProducto.Click += new System.EventHandler(this.btnGetProducto_Click);
            // 
            // txtProductoId
            // 
            this.txtProductoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoId.Location = new System.Drawing.Point(121, 30);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.ReadOnly = true;
            this.txtProductoId.Size = new System.Drawing.Size(82, 30);
            this.txtProductoId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto:";
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Enabled = false;
            this.txtProductoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoPrecio.Location = new System.Drawing.Point(765, 30);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(106, 30);
            this.txtProductoPrecio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(677, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::CopanStock.Properties.Resources.icon_guardar_16px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(877, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 31);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = global::CopanStock.Properties.Resources.icon_borrar_16px;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(910, 29);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(27, 31);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgVentaDetalle);
            this.groupBox3.Location = new System.Drawing.Point(18, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1040, 398);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de Factura";
            // 
            // dgVentaDetalle
            // 
            this.dgVentaDetalle.AllowUserToAddRows = false;
            this.dgVentaDetalle.AllowUserToDeleteRows = false;
            this.dgVentaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVentaDetalle.Location = new System.Drawing.Point(3, 26);
            this.dgVentaDetalle.Name = "dgVentaDetalle";
            this.dgVentaDetalle.ReadOnly = true;
            this.dgVentaDetalle.RowHeadersWidth = 51;
            this.dgVentaDetalle.RowTemplate.Height = 24;
            this.dgVentaDetalle.Size = new System.Drawing.Size(1034, 369);
            this.dgVentaDetalle.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBuscarProducto,
            this.btnBuscarProducto,
            this.btnCerrarProductos});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1074, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductos.Location = new System.Drawing.Point(3, 38);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.Size = new System.Drawing.Size(1074, 597);
            this.dgProductos.TabIndex = 3;
            this.dgProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellDoubleClick);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(200, 35);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Image = global::CopanStock.Properties.Resources.icon_buscar_16px;
            this.btnBuscarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(92, 32);
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnCerrarProductos
            // 
            this.btnCerrarProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarProductos.Image = global::CopanStock.Properties.Resources.icon_cancelar_16px;
            this.btnCerrarProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarProductos.Name = "btnCerrarProductos";
            this.btnCerrarProductos.Size = new System.Drawing.Size(110, 32);
            this.btnCerrarProductos.Text = "Cancelar";
            this.btnCerrarProductos.Click += new System.EventHandler(this.btnCerrarProductos_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(904, 588);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 25);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(836, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total:";
            // 
            // FrmVentaInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 676);
            this.Controls.Add(this.tabOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentaInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Factura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOpciones.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabVenta.PerformLayout();
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVentaDetalle)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabOpciones;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Button btnGetCliente;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.TextBox txtUsuarioId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProductoCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductoNombre;
        private System.Windows.Forms.Button btnGetProducto;
        private System.Windows.Forms.TextBox txtProductoId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProductoPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgVentaDetalle;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtBuscarProducto;
        private System.Windows.Forms.ToolStripButton btnBuscarProducto;
        private System.Windows.Forms.ToolStripButton btnCerrarProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
    }
}
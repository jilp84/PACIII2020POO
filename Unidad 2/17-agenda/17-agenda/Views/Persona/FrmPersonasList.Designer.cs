namespace _17_agenda.Views.Persona
{
    partial class FrmPersonasList
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
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.btnBorrar = new MetroFramework.Controls.MetroTile();
            this.btnDetalle = new MetroFramework.Controls.MetroTile();
            this.btnEditar = new MetroFramework.Controls.MetroTile();
            this.btnNuevo = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(468, 162);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PromptText = "Ingrese un texto para buscar...";
            this.txtBuscar.Size = new System.Drawing.Size(270, 35);
            this.txtBuscar.TabIndex = 4;
            // 
            // dgDatos
            // 
            this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(15, 228);
            this.dgDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersWidth = 62;
            this.dgDatos.Size = new System.Drawing.Size(1131, 429);
            this.dgDatos.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(747, 162);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 37);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TileImage = global::_17_agenda.Properties.Resources.search_16px;
            this.btnBuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.UseTileImage = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(358, 115);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(99, 83);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.TileImage = global::_17_agenda.Properties.Resources.delete_32px;
            this.btnBorrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrar.UseTileImage = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(250, 115);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(99, 83);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.TileImage = global::_17_agenda.Properties.Resources.view_32px;
            this.btnDetalle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetalle.UseTileImage = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(142, 115);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 83);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.TileImage = global::_17_agenda.Properties.Resources.edit_32px;
            this.btnEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.UseTileImage = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(34, 115);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 83);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.TileImage = global::_17_agenda.Properties.Resources.add_32px;
            this.btnNuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.UseTileImage = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmPersonasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPersonasList";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Agenda de Contactos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnNuevo;
        private MetroFramework.Controls.MetroTile btnEditar;
        private MetroFramework.Controls.MetroTile btnDetalle;
        private MetroFramework.Controls.MetroTile btnBorrar;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroTile btnBuscar;
        private System.Windows.Forms.DataGridView dgDatos;
    }
}


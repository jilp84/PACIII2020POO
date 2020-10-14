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
            this.txtBuscar.Location = new System.Drawing.Point(312, 105);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PromptText = "Ingrese un texto para buscar...";
            this.txtBuscar.Size = new System.Drawing.Size(180, 23);
            this.txtBuscar.TabIndex = 4;
            // 
            // dgDatos
            // 
            this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(23, 148);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(754, 279);
            this.dgDatos.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 24);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TileImage = global::_17_agenda.Properties.Resources.search_16px;
            this.btnBuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.UseTileImage = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(239, 75);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(66, 54);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.TileImage = global::_17_agenda.Properties.Resources.delete_32px;
            this.btnBorrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrar.UseTileImage = true;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(167, 75);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(66, 54);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.TileImage = global::_17_agenda.Properties.Resources.view_32px;
            this.btnDetalle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetalle.UseTileImage = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(95, 75);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(66, 54);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.TileImage = global::_17_agenda.Properties.Resources.edit_32px;
            this.btnEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.UseTileImage = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(23, 75);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 54);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.TileImage = global::_17_agenda.Properties.Resources.add_32px;
            this.btnNuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.UseTileImage = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmPersonasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "FrmPersonasList";
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


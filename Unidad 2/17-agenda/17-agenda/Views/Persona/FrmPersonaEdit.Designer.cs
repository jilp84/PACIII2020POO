namespace _17_agenda.Views.Persona
{
    partial class FrmPersonaEdit
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
            this.tabPrincipal = new MetroFramework.Controls.MetroTabControl();
            this.tabDatosGenerales = new MetroFramework.Controls.MetroTabPage();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.rbtnHombre = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnMujer = new MetroFramework.Controls.MetroRadioButton();
            this.lblGenero = new MetroFramework.Controls.MetroLabel();
            this.txtApellidos = new MetroFramework.Controls.MetroTextBox();
            this.lblApellidos = new MetroFramework.Controls.MetroLabel();
            this.txtNombres = new MetroFramework.Controls.MetroTextBox();
            this.lblNombres = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.tabContacto = new MetroFramework.Controls.MetroTabPage();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.cmbTipoContacto = new MetroFramework.Controls.MetroComboBox();
            this.lblTipoContacto = new MetroFramework.Controls.MetroLabel();
            this.txtContacto = new MetroFramework.Controls.MetroTextBox();
            this.lblContacto = new MetroFramework.Controls.MetroLabel();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.tabPrincipal.SuspendLayout();
            this.tabDatosGenerales.SuspendLayout();
            this.tabContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabDatosGenerales);
            this.tabPrincipal.Controls.Add(this.tabContacto);
            this.tabPrincipal.Location = new System.Drawing.Point(23, 74);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 1;
            this.tabPrincipal.Size = new System.Drawing.Size(677, 391);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabDatosGenerales
            // 
            this.tabDatosGenerales.Controls.Add(this.btnCancelar);
            this.tabDatosGenerales.Controls.Add(this.btnGuardar);
            this.tabDatosGenerales.Controls.Add(this.txtDireccion);
            this.tabDatosGenerales.Controls.Add(this.lblDireccion);
            this.tabDatosGenerales.Controls.Add(this.rbtnHombre);
            this.tabDatosGenerales.Controls.Add(this.rbtnMujer);
            this.tabDatosGenerales.Controls.Add(this.lblGenero);
            this.tabDatosGenerales.Controls.Add(this.txtApellidos);
            this.tabDatosGenerales.Controls.Add(this.lblApellidos);
            this.tabDatosGenerales.Controls.Add(this.txtNombres);
            this.tabDatosGenerales.Controls.Add(this.lblNombres);
            this.tabDatosGenerales.Controls.Add(this.txtId);
            this.tabDatosGenerales.Controls.Add(this.lblId);
            this.tabDatosGenerales.HorizontalScrollbarBarColor = true;
            this.tabDatosGenerales.Location = new System.Drawing.Point(4, 35);
            this.tabDatosGenerales.Name = "tabDatosGenerales";
            this.tabDatosGenerales.Size = new System.Drawing.Size(669, 352);
            this.tabDatosGenerales.TabIndex = 0;
            this.tabDatosGenerales.Text = "Datos Generales";
            this.tabDatosGenerales.VerticalScrollbarBarColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(214, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(133, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(81, 137);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PromptText = "Ingrese la dirección de la persona";
            this.txtDireccion.Size = new System.Drawing.Size(208, 100);
            this.txtDireccion.TabIndex = 19;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(13, 137);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 19);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección:";
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Location = new System.Drawing.Point(141, 112);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(67, 15);
            this.rbtnHombre.TabIndex = 17;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Location = new System.Drawing.Point(81, 112);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(54, 15);
            this.rbtnMujer.TabIndex = 16;
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(13, 108);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(55, 19);
            this.lblGenero.TabIndex = 15;
            this.lblGenero.Text = "Género:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(81, 83);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PromptText = "Ingrese los apellidos de la persona";
            this.txtApellidos.Size = new System.Drawing.Size(208, 23);
            this.txtApellidos.TabIndex = 14;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(13, 83);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(66, 19);
            this.lblApellidos.TabIndex = 13;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(81, 54);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PromptText = "Ingrese los nombres de la persona";
            this.txtNombres.Size = new System.Drawing.Size(208, 23);
            this.txtNombres.TabIndex = 12;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(13, 54);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(62, 19);
            this.lblNombres.TabIndex = 11;
            this.lblNombres.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(208, 23);
            this.txtId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id:";
            // 
            // tabContacto
            // 
            this.tabContacto.Controls.Add(this.btnAgregar);
            this.tabContacto.Controls.Add(this.cmbTipoContacto);
            this.tabContacto.Controls.Add(this.lblTipoContacto);
            this.tabContacto.Controls.Add(this.txtContacto);
            this.tabContacto.Controls.Add(this.lblContacto);
            this.tabContacto.Controls.Add(this.dgDatos);
            this.tabContacto.HorizontalScrollbarBarColor = true;
            this.tabContacto.Location = new System.Drawing.Point(4, 35);
            this.tabContacto.Name = "tabContacto";
            this.tabContacto.Size = new System.Drawing.Size(669, 352);
            this.tabContacto.TabIndex = 1;
            this.tabContacto.Text = "Contactos";
            this.tabContacto.VerticalScrollbarBarColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(583, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 29);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            // 
            // cmbTipoContacto
            // 
            this.cmbTipoContacto.FormattingEnabled = true;
            this.cmbTipoContacto.ItemHeight = 23;
            this.cmbTipoContacto.Items.AddRange(new object[] {
            "Correo",
            "Telefono Fijo",
            "Celular"});
            this.cmbTipoContacto.Location = new System.Drawing.Point(408, 24);
            this.cmbTipoContacto.Name = "cmbTipoContacto";
            this.cmbTipoContacto.Size = new System.Drawing.Size(169, 29);
            this.cmbTipoContacto.TabIndex = 16;
            // 
            // lblTipoContacto
            // 
            this.lblTipoContacto.AutoSize = true;
            this.lblTipoContacto.Location = new System.Drawing.Point(287, 28);
            this.lblTipoContacto.Name = "lblTipoContacto";
            this.lblTipoContacto.Size = new System.Drawing.Size(114, 19);
            this.lblTipoContacto.TabIndex = 15;
            this.lblTipoContacto.Text = "Tipo de Contacto:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(72, 24);
            this.txtContacto.Multiline = true;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.PromptText = "Ingrese un numero y correo...";
            this.txtContacto.Size = new System.Drawing.Size(208, 29);
            this.txtContacto.TabIndex = 14;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(4, 28);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(65, 19);
            this.lblContacto.TabIndex = 13;
            this.lblContacto.Text = "Contacto:";
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(3, 57);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(663, 294);
            this.dgDatos.TabIndex = 2;
            // 
            // FrmPersonaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 479);
            this.Controls.Add(this.tabPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonaEdit";
            this.Resizable = false;
            this.Text = "Editar Persona";
            this.tabPrincipal.ResumeLayout(false);
            this.tabDatosGenerales.ResumeLayout(false);
            this.tabDatosGenerales.PerformLayout();
            this.tabContacto.ResumeLayout(false);
            this.tabContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabPrincipal;
        private MetroFramework.Controls.MetroTabPage tabDatosGenerales;
        private MetroFramework.Controls.MetroTabPage tabContacto;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroLabel lblDireccion;
        private MetroFramework.Controls.MetroRadioButton rbtnHombre;
        private MetroFramework.Controls.MetroRadioButton rbtnMujer;
        private MetroFramework.Controls.MetroLabel lblGenero;
        private MetroFramework.Controls.MetroTextBox txtApellidos;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private MetroFramework.Controls.MetroTextBox txtNombres;
        private MetroFramework.Controls.MetroLabel lblNombres;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroComboBox cmbTipoContacto;
        private MetroFramework.Controls.MetroLabel lblTipoContacto;
        private MetroFramework.Controls.MetroTextBox txtContacto;
        private MetroFramework.Controls.MetroLabel lblContacto;
        private System.Windows.Forms.DataGridView dgDatos;
    }
}
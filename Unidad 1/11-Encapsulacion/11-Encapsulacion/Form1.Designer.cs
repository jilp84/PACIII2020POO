namespace _11_Encapsulacion
{
    partial class Form1
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
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeEge = new System.Windows.Forms.TextBox();
            this.lblEmployeeEge = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.txtEmployeePosition);
            this.grpEmployee.Controls.Add(this.lblEmployeePosition);
            this.grpEmployee.Controls.Add(this.txtEmployeeName);
            this.grpEmployee.Controls.Add(this.lblEmployeeName);
            this.grpEmployee.Controls.Add(this.txtEmployeeEge);
            this.grpEmployee.Controls.Add(this.lblEmployeeEge);
            this.grpEmployee.Controls.Add(this.txtEmployeeId);
            this.grpEmployee.Controls.Add(this.lblEmployeeId);
            this.grpEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployee.Location = new System.Drawing.Point(12, 12);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(333, 170);
            this.grpEmployee.TabIndex = 0;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Empleado";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(24, 35);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(30, 20);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Id:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(99, 32);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(219, 26);
            this.txtEmployeeId.TabIndex = 1;
            // 
            // txtEmployeeEge
            // 
            this.txtEmployeeEge.Location = new System.Drawing.Point(99, 64);
            this.txtEmployeeEge.Name = "txtEmployeeEge";
            this.txtEmployeeEge.Size = new System.Drawing.Size(219, 26);
            this.txtEmployeeEge.TabIndex = 3;
            // 
            // lblEmployeeEge
            // 
            this.lblEmployeeEge.AutoSize = true;
            this.lblEmployeeEge.Location = new System.Drawing.Point(24, 67);
            this.lblEmployeeEge.Name = "lblEmployeeEge";
            this.lblEmployeeEge.Size = new System.Drawing.Size(56, 20);
            this.lblEmployeeEge.TabIndex = 2;
            this.lblEmployeeEge.Text = "Edad:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(99, 96);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(219, 26);
            this.txtEmployeeName.TabIndex = 5;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(24, 99);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(76, 20);
            this.lblEmployeeName.TabIndex = 4;
            this.lblEmployeeName.Text = "Nombre:";
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(99, 128);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(219, 26);
            this.txtEmployeePosition.TabIndex = 7;
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Location = new System.Drawing.Point(24, 131);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(70, 20);
            this.lblEmployeePosition.TabIndex = 6;
            this.lblEmployeePosition.Text = "Puesto:";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(235, 199);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 253);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpEmployee);
            this.Name = "Form1";
            this.Text = "Gestión de Empleados";
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.Label lblEmployeePosition;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeEge;
        private System.Windows.Forms.Label lblEmployeeEge;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Button btnSend;
    }
}


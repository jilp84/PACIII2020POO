namespace _11_Encapsulacion
{
    partial class EmployeeDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeEge = new System.Windows.Forms.Label();
            this.grpEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(235, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.lblEmployeePosition);
            this.grpEmployee.Controls.Add(this.lblEmployeeName);
            this.grpEmployee.Controls.Add(this.lblEmployeeEge);
            this.grpEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployee.Location = new System.Drawing.Point(12, 12);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(333, 150);
            this.grpEmployee.TabIndex = 2;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Empleado";
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Location = new System.Drawing.Point(40, 103);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(70, 20);
            this.lblEmployeePosition.TabIndex = 6;
            this.lblEmployeePosition.Text = "Puesto:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(40, 71);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(76, 20);
            this.lblEmployeeName.TabIndex = 4;
            this.lblEmployeeName.Text = "Nombre:";
            // 
            // lblEmployeeEge
            // 
            this.lblEmployeeEge.AutoSize = true;
            this.lblEmployeeEge.Location = new System.Drawing.Point(40, 39);
            this.lblEmployeeEge.Name = "lblEmployeeEge";
            this.lblEmployeeEge.Size = new System.Drawing.Size(56, 20);
            this.lblEmployeeEge.TabIndex = 2;
            this.lblEmployeeEge.Text = "Edad:";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 243);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpEmployee);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpEmployee;
        public System.Windows.Forms.Label lblEmployeePosition;
        public System.Windows.Forms.Label lblEmployeeName;
        public System.Windows.Forms.Label lblEmployeeEge;
    }
}
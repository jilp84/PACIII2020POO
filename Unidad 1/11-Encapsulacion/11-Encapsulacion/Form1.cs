using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Encapsulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.EmployeeEge = Convert.ToInt32(txtEmployeeEge.Text);
            employeeDetails.EmployeeName = txtEmployeeName.Text;
            employeeDetails.EmployeePosition = txtEmployeePosition.Text;

            EmployeeDetails frm = new EmployeeDetails();

            frm.lblEmployeeEge.Text = employeeDetails.EmployeeEge.ToString();
            frm.lblEmployeeName.Text = employeeDetails.EmployeeName;
            frm.lblEmployeePosition.Text = employeeDetails.EmployeePosition;

            frm.ShowDialog();

        }
    }
}

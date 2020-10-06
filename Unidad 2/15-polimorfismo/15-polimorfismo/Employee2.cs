using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_polimorfismo
{
    public class Employee2
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }

        public virtual string SetValues(int Id, string Name, double Salary) 
        {
            EmployeeId = Id;
            EmployeeName = Name;
            EmployeeSalary = Salary;

            string texto = "Id: " + EmployeeId + Environment.NewLine;
            texto += "Nombre: " + EmployeeName + Environment.NewLine;
            texto += "Salario: " + EmployeeSalary.ToString() + Environment.NewLine;

            return texto;
        }

    }
}

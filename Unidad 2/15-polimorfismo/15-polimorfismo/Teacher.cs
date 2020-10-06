using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_polimorfismo
{
    public class Teacher : Employee
    {
        public string EmployeePosition { get; set; }

        public void SetValues(int Id, string Name, double Salary, string Position)
        {
            EmployeeId = Id;
            EmployeeName = Name;
            EmployeeSalary = Salary;
            EmployeePosition = Position;
        }

        public string GetValues() 
        {
            string texto = "Id: " + EmployeeId + Environment.NewLine ;
            texto += "Nombre: " + EmployeeName + Environment.NewLine ;
            texto += "Salario: " + EmployeeSalary.ToString() + Environment.NewLine ;
            texto += "Puesto: " + EmployeePosition + Environment.NewLine ;

            return texto;

        }

    }
}

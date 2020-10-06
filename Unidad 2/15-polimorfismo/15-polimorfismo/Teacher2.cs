using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_polimorfismo
{
    public class Teacher2 : Employee2
    {
        public string EmployeePosition { get; set; }

        public override string SetValues(int Id, string Name, double Salary) 
        {
            EmployeeId = Id;
            EmployeeName = Name;
            EmployeeSalary = Salary;
            EmployeePosition = "Profesor";

            string texto = "Id: " + EmployeeId + Environment.NewLine;
            texto += "Nombre: " + EmployeeName + Environment.NewLine;
            texto += "Salario: " + EmployeeSalary.ToString() + Environment.NewLine;
            texto += "Puesto: " + EmployeePosition + Environment.NewLine;

            return texto;
        }

    }
}

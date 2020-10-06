using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_polimorfismo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }

        public void SetValues( int Id)
        {
            EmployeeId = Id;
        }

        public void SetValues(int Id, string Name)
        {
            EmployeeId = Id;
            EmployeeName = Name;
        }

        public void SetValues(int Id, string Name, double Salary)
        {
            EmployeeId = Id;
            EmployeeName = Name;
            EmployeeSalary = Salary;
        }
    }
}

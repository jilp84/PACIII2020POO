using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Encapsulacion
{
    class Employee
    {
        protected int EmployeeId { get; set; }
        public int  EmployeeEge { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
    }
}

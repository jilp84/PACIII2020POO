using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_interface
{
    public class DellComputers : Computer, DellComputer
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Mark { get; set; }

        public void GetDesktop()
        {
            Name = "Desktop1";
            Price = 2800;
        }

        public void GetLaptop()
        {
            Name = "Laptop1";
            Price = 2200;
        }

        public void GetMark()
        {
            Mark = "Dell";
        }
    }
}

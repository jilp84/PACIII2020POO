using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_abstract
{
    public class Bus : Vehicle
    {
        public override double GetFullAmount()
        {
            return 800000;
        }
    }
}

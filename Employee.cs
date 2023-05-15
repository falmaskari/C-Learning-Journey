using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    internal class Employee //Class declaration
    {
        public const double TAX = 0.03; //Constant value
        public string fName;
        public string lName;
        public double wags;
        public double loggedHours;

        public int addone(ref int x)
        {
            return x + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Calculator
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public double add(double x, double y)
        {
            return x + y;
        }
        public string add(string x, string y)
        {
            return x + y;
        }

        public string numberType(int x)
        {
            return x%2==0 ? "even" : "odd";
        }
    }
}

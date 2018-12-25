using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class A
    {
        [My("Attributed")]
        public int PropertyInt { get; set; }
        public double PropertyDouble { get; set; }
        [My("Attributed")]
        public string PropertyString { get; set; }

        public A(int propertyInt, double propertyDouble, string propertyString)
        {
            PropertyInt = propertyInt;
            PropertyDouble = propertyDouble;
            PropertyString = propertyString;
        }

        public int MethodInt()
        {
            return 17;
        }

        public double MethodDouble()
        {
            return 24.34;
        }

        public string MethodString()
        {
            return "25";
        }
    }
}

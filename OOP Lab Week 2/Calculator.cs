using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Week_2
{
    public class Calculator
    {
        float num1;
        float num2;

        public Calculator(float x, float y)
        {
            num1 = x;
            num2 = y;
        }

        public float addition()
        {
            return num1 + num2;
        }

        public float subtraction()
        {
            return num1 - num2;
        }

        public float multiply()
        {
            return num1 * num2;
        }

        public float divide()
        {
            return num1 / num2;
        }
    }
}

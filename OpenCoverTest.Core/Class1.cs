using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverTest.Core
{

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
    }




    public class StringHelper
    {
        public string Reverse(string input)
        {
            if (input == null) return null;
            return new string(input.Reverse().ToArray());
        }
    }

    public class MathUtils
    {
        public bool IsEven(int number) => number % 2 == 0;
    }
}

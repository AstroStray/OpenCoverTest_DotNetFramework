using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OpenCoverTest.App
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
    }

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

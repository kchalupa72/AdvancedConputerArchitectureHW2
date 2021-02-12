using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ArithmeticFunctions
    {
        public static int AddFunction(int a, int b) => a + b;
        public static int SubtractFunction(int a, int b) => a - b;
        public static int MultiplyFunction(int a, int b) => a * b;
        public static int DivideFunction(int a, int b) => a / b;
        public static int DuplicateFunction(int a, int b) => a;
        public static int DoubleFunction(int a, int b) => a * 2;
        public static int SquareFunction(int a, int b) => a * a;
        public static bool EqualToFunction(int a, int b) => a == b;
        public static bool NotEqualToFunction(int a, int b) => a != b;
        public static bool LessThanFunction(int a, int b) => a < b;
        public static bool LessThanEqualFunction(int a, int b) => a <= b;
        public static bool GreaterThanFunction(int a, int b) => a > b;
        public static bool GreaterThanEqualFunction(int a, int b) => a >= b;
        public static bool AndFunction(int a, int b) => ((a != 0)  && (b != 0));
        public static bool OrFunction(int a, int b) => ((a != 0) || (b != 0));
        public static bool NorFunction(int a, int b) => ((a == 0) && (b == 0));
        public static bool XorFunction(int a, int b) => ((a != 0) ^ (b != 0));

    }
}

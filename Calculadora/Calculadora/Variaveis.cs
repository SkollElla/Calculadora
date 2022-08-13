using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Variaveis
    {
        private static double res;

        public static double GetRes()
        {
            return res;
        }

        public static void SetRes(double value)
        {
            res = value;
        }

        public static bool Y { get; set; }
        public static string[] e = { "+", "-", "/", "*" };
    }
}

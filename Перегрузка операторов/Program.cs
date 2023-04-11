using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_операторов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(1, 8);
            Rational r2 = new Rational(2, 4);
            Console.WriteLine(r1 + r2);
            Console.ReadKey();
        }
    }
}

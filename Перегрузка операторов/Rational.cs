using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_операторов
{
    class Rational
    {
        private int a;
        private int b;

        public Rational(int a, int b)
        {
            this.a = a;
            this.b = b;
            Reduce();
        }

        private void Reduce()
        {
            int gcd = GCD(a, b);
            this.a /= gcd;
            this.b /= gcd;
        }

        private int GCD(int x, int y)
        {
            while (x > 0)
            {
                int c = y % x;
                y = x;
                x = c;
            }
            return y;
        }

        public static Rational operator +(Rational left, Rational right)
        {
            return new Rational(left.a * right.b + right.a * left.b, left.b * right.b);
        }

        public override string ToString()
        {
            return $"({a}/{b})";
        }
    }
}

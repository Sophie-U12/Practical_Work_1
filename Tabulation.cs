using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sophie
{
    public class Tabulation
    {
        private double a;
        private double Xn;
        private double Xk;
        private double h;

        public Tabulation(double a, double Xn, double Xk, double h)
        {
            this.a = a;
            this.Xn = Xn;
            this.Xk = Xk;
            this.h = h;
        }

        public double CalculateFunction(double x)
        {
            if (x <= 0)
            {
                return (Math.Pow(3 * x - 1, 2)) / (Math.Pow(x, 5));
            }
            else if (x <= a)
            {
                return Math.Pow(Math.Log(Math.Abs(Math.Sqrt(x + 5)), 2), 2);
            }
            return Math.Cos(Math.Sqrt(1 + Math.Pow(x, 2)));
        }


        public List<(double, double)> Tab()
        {
            List<(double, double)> result = new List<(double, double)>();

            for (double x = Xn; x <= Xk; x += h)
            {
                double y = CalculateFunction(x);
                result.Add((x, y));
            }
            return result;
        }
    }
}

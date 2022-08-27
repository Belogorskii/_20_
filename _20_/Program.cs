using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите радиус окружности");
            double r = Convert.ToInt32(Console.ReadLine());

            MyDelegate myDelegate = PowerD;
            double D = myDelegate(r);
            Console.WriteLine(D);

            myDelegate = PowerS;
            double S = myDelegate(r);
            Console.WriteLine(S);

            myDelegate = PowerV;
            double V = myDelegate(r);
            Console.WriteLine(V);
        }
        static double PowerD(double r) => 2.0 * r * Math.PI;
        static double PowerS(double r) => r * r * Math.PI;
        static double PowerV(double r) => (4 * r * r * r * Math.PI) / 3
            ;
    }
}
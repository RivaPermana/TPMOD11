using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AljabarLibraries2
{
    public class AkarPersaKuad
    {
        public void SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                //Akar real dan berbeda
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Output : {" + root1 + ", " + root2 + "}");
            }
            else if (discriminant == 0)
            {
                //Akar real dan sama
                double root = -b / (2 * a);
                Console.WriteLine("x1 = x2 = " + root);
            }
            else
            {
                //Akar imajiner
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("Output : {" + realPart + ", " + imaginaryPart + "}");
            }

        }
    }
}

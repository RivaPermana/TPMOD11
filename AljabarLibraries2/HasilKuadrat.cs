using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AljabarLibraries2
{
    public class Hasilkuadrat
    {
        public void olahHasilKuadrat(double a, double b)
        {
            Console.WriteLine("Output : {" + Math.Pow(a, 2) + ", " + 2 * (a * b) + ", " + Math.Pow(b, 2) + "}");
        }
    }
}

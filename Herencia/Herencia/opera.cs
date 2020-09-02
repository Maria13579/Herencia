using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{

    class opera:ope
    {


        public double Raiz(double a)
        {
            return Math.Sqrt(a);
        }

        public double Poten(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}

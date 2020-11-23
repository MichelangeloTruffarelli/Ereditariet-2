using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiGeometria
{
    public class Rettangolo : Quadrilatero
    {
        public Rettangolo(double base1, double altezza) : base(base1, altezza, base1, altezza)
        {
        }
        public double CalcolaArea()
        {
            return lato1 * lato2;
        }
    }
}

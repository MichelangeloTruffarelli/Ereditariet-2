using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiGeometria
{
    class Triangolo
    {
        public double base1 { get; private set; }
        public double lato2 { get; private set; }
        public double lato3 { get; private set; }
        public double altezza { get; private set; }
        public Triangolo(double base1, double lato2, double lato3, double altezza)
        {
            this.base1 = base1;
            this.lato2 = lato2;
            this.lato3 = lato3;
            this.altezza = altezza;
        }
        public double CalcolaPerimetro()
        {
            return base1 + lato2 + lato3;
        }
        public double CalcolaArea()
        {
            return (base1 * altezza) / 2;
        }
    }
}

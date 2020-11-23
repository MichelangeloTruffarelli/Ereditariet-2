using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiGeometria
{
    public abstract class Quadrilatero : FiguraGeometrica
    {
        public double lato1 { get; private set; }
        public double lato2 { get; private set; }
        public double lato3 { get; private set; }
        public double lato4 { get; private set; }
        public Quadrilatero(double lato1, double lato2, double lato3, double lato4)
        {
            this.lato1 = lato1;
            this.lato2 = lato2;
            this.lato3 = lato3;
            this.lato4 = lato4;
        }
        public double CalcolaPerimetro()
        {
            return lato1 + lato2 + lato3 + lato4;
        }
    }
}

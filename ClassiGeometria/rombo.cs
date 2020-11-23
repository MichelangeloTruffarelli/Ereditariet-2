using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiGeometria
{
    public class Rombo : Quadrilatero
    {
        public double lato { get; private set; }
        public double diagonale1 { get; private set; }
        public double diagonale2 { get; private set; }
        public Rombo(double lato, double diagonale1, double diagonale2)
        {
            this.lato = lato;
            this.diagonale1 = diagonale1;
            this.diagonale2 = diagonale2;
        }
        public double CalcolaPerimetro()
        {
            return (lato * lato * lato * lato);
        }
        public double CalcolaArea()
        {
            return (diagonale1 * diagonale2) / 2;
        }
    }
}

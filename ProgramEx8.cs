using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaaPOOex8
{
    internal class Maior
    {
        private double x;
        private double y;

        public void setx(double d)
        {
            x = d;
        }
        public void sety(double d)
        {
            y = d;
        }
        public double getx()
        {
            return x;
        }
        public double gety()
        {
            return y;
        }
        public void calcular() 
        {
            if (x < y)
                Console.WriteLine("y maior que x", x, y);
            else
                if (x > y)
                Console.WriteLine("x maior que y");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    class Triangle3
    {
        public double a;
        public double b;
        public double c;

        public Triangle3(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle3()
        {

        }

        public Triangle3(double B, double C)
        {
            b = B;
            c = C;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }

        public double cosA()
        {
            double cosinA = 0;
            cosinA = Math.Round((b / c), 2);
            return cosinA;
        }

        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }

        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }
    }
}

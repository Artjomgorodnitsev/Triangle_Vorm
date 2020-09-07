using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    class Triangle4
    {
        public double a;
        public double b;
        public double c;

        public Triangle4(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle4()
        {

        }

        public Triangle4(double B, double A)
        {
            b = B;
            a = A;
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

        public double tanA()
        {
            double tangA = 0;
            tangA = Math.Round((a / b), 2);
            return tangA;
        }

        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }

        public double GetSetA
        {
            get { return a; }
            set { a = value; }
        }
    }
}

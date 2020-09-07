using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    class Triangle2
    {
        public double a;
        public double b;
        public double c;




        public Triangle2(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public Triangle2()
        {

        }

        public Triangle2(double A, double C)
        {
            a = A;
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


        public string outputAU()
        {
            return Convert.ToString(a);
        }
        public string outputBU()
        {
            return Convert.ToString(b);
        }
        public string outputCU()
        {
            return Convert.ToString(c);
        }

        public double sinA()
        {
            double sinusA = 0;
            sinusA = Math.Round((a / c), 2);
            return sinusA;
        }
        public double cosA()
        {
            double cosinA = 0;
            cosinA = Math.Round((b / c), 2);
            return cosinA;
        }
        public double tanA()
        {
            double tangA = 0;
            tangA = Math.Round((a / b), 2);
            return tangA;
        }




        public double GetSetA
        {
            get { return a; }
            set { a = value; }
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

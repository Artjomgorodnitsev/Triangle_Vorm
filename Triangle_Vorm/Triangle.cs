﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;




        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public Triangle()
        {

        }

        public Triangle(double A, double H)
        {
            a = A;
            h = H;
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

        public string outputH()
        {
            return Convert.ToString(h);
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

        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }

        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c)/2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        public double Surface2()
        {
            double s = 0;
            s = 0.5 * a * h;
            return s;
        }

        public double sinA()
        {
            double sinusA = 0;
            sinusA = Math.Round((a / c),2);
            return sinusA;
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

        public double GetSetH
        {
            get { return h; }
            set { h = value; }
        }

        public bool ExistTriangle
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return true;
                else return false;
               
            }
        }

        public int TypeTriangleRavn {
            get {
                if (a == b && b == c && c == a)
                    return 1;
                else if (a == b && b != c && c != a)
                    return 2;
                else if (a != b && b != c && c != a)
                    return 3;
                else
                    return 4;

            }
        }

        
    }

    
}

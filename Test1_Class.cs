using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LinearFunction
    {
        private double a;
        private double b;
        
        public double A
        {
            get {return a;}
            set {a=value;}
        }
        
        public double B
        {
            get {return b;}
            set {b=value;}
        }
        
        public double GetFunctionY(double x)
        {
            return (A * x) + B;

        }
    }
}

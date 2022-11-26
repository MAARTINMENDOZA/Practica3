using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Areas
{
    public class Calcular
    {
        
        public decimal Paralelogramo(decimal l1, decimal l2)
        {
            return (2*l1) + (2*l2);
        }
        public decimal Trapezoide(decimal a, decimal b, decimal c, decimal d)
        {
            var Area = a + b + c + d ;
            return Area;
        }
    }
}
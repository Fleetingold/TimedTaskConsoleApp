using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FunctionalProgram
{

    public class PropertyFeeCalculator
    {
        public Func<decimal> SquareForCivil(int width, int hight)
        {
            return () => width * hight;
        }

        public Func<decimal> SquareForBusiness(int width, int hight)
        {
            return () => width * hight * 1.2m;
        }

        public decimal PropertyFee(decimal price, Func<decimal> square)
        {
            return price * square();
        }
    }

    public static class ExtensionDecimal {

    }
}
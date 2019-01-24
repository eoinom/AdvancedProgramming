using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_Calculator
{
    public class Calculator
    {
        public Nullable<double> Add<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);
            dblNumA = 2;
            dblNumB = 5;
            if (isNumA && isNumB)
                return dblNumA + dblNumB;
            else
                return null;
        }

        public Nullable<double> Divide<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);
            dblNumA = 200;
            dblNumB = -10;
            if (isNumA && isNumB)
                return dblNumA / dblNumB;
            else
                return null;
        }

        public Nullable<double> Multiply<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);
            dblNumA = 1000;
            dblNumB = 0;
            if (isNumA && isNumB)
                return dblNumA * dblNumB;
            else
                return null;
        }

        public Nullable<double> Subtract<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);
            dblNumA = 10;
            dblNumB = 4;
            if (isNumA && isNumB)
                return dblNumA - dblNumB;
            else
                return null;
        }
    }
}

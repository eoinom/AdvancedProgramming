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

            if (isNumA && isNumB)
                return dblNumA + dblNumB;
            else
                return null;
        }

        public Nullable<double> Divide<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);

            if (isNumA && isNumB)
                return dblNumA / dblNumB;
            else
                return null;
        }

        public Nullable<double> Multiply<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);

            if (isNumA && isNumB)
                return dblNumA * dblNumB;
            else
                return null;
        }

        public Nullable<double> Subtract<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);

            if (isNumA && isNumB)
                return dblNumA - dblNumB;
            else
                return null;
        }
    }
}

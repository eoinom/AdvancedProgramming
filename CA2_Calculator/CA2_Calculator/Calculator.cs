using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Math;

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

        public Nullable<double> CosFromDeg<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum)
                return Math.Cos(dblNum * (Math.PI / 180));
            else
                return null;
        }

        public Nullable<double> Cube<T>(T num)
        {
            bool isNum = double.TryParse(num.ToString(), out double dblNum);

            if (isNum)
                return Math.Pow(dblNum, 3);
            else
                return null;
        }

        public Nullable<double> CubeRoot<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum)
                return Math.Round(Math.Pow(dblNum, 1.0/3), 8);
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

        public Nullable<double> Exponent<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);

            if (isNumA && isNumB)
                return Math.Pow(dblNumA, dblNumB);
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

        public Nullable<double> SinFromDeg<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum)
                return Math.Sin(dblNum * (Math.PI / 180));
            else
                return null;
        }

        public Nullable<double> Square<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum)
                return Math.Pow(dblNum, 2);
            else
                return null;
        }

        public Nullable<double> SquareRoot<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum)
                return Math.Sqrt(dblNum);
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

        public Nullable<double> TanFromDeg<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (!isNum || (dblNum % 90 == 0 && dblNum % 180 != 0) )
                return null;
            else
                return Math.Tan(dblNum * (Math.PI / 180) );
        }

    }
}

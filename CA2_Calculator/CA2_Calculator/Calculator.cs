﻿using System;
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

            if (isNumA && isNumB) { 
                return dblNumA + dblNumB;
            }
            return null;
        }

        public Nullable<double> CosFromDeg<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum) {
                return Math.Cos(dblNum * (Math.PI / 180));
            }
            return null;
        }

        public Nullable<double> CosFromRad<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum) { 
                return Math.Cos(dblNum);
            }
            return null;
        }

        public Nullable<double> Cube<T>(T num)
        {
            bool isNum = double.TryParse(num.ToString(), out double dblNum);

            if (isNum) {
                return Math.Pow(dblNum, 3);
            }
            return null;
        }

        public Nullable<double> CubeRoot<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum) { 
                return Math.Round(Math.Pow(dblNum, 1.0/3), 8);
            }
            return null;
        }

        public Nullable<double> Divide<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);

            if (isNumA && isNumB) {
                return dblNumA / dblNumB;
            }
            return null;
        }

        public Nullable<double> Exponent<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);

            if (isNumA && isNumB) {
                return Math.Pow(dblNumA, dblNumB);
            }
            return null;
        }

        public Nullable<double> Factorial<T>(T numA)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);

            if (isNumA)
            {
                if (dblNumA >= 0 && dblNumA % 1 == 0)
                {
                    return MathNet.Numerics.SpecialFunctions.Factorial( (int)dblNumA );
                }
                else if (dblNumA < 0 && dblNumA % 1 == 0)
                {
                    return null;
                }
                return dblNumA * MathNet.Numerics.SpecialFunctions.Gamma(dblNumA);
            }
            return null;
        }

        public Nullable<double> Multiply<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);

            if (isNumA && isNumB) { 
                return dblNumA * dblNumB;
            }
            return null;
        }

        public Nullable<double> SinFromDeg<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum) { 
                return Math.Sin(dblNum * (Math.PI / 180));
            }
            return null;
        }

        public Nullable<double> SinFromRad<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum) { 
                return Math.Sin(dblNum);
            }
            return null;
        }

        public Nullable<double> Square<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum) { 
                return Math.Pow(dblNum, 2);
            }
            return null;
        }

        public Nullable<double> SquareRoot<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (isNum) { 
                return Math.Sqrt(dblNum);
            }
            return null;
        }

        public Nullable<double> Subtract<T>(T numA, T numB)
        {
            bool isNumA = double.TryParse(numA.ToString(), out double dblNumA);
            bool isNumB = double.TryParse(numB.ToString(), out double dblNumB);

            if (isNumA && isNumB) { 
                return dblNumA - dblNumB;
            }
            return null;
        }

        public Nullable<double> TanFromDeg<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (!isNum || (dblNum % 90 == 0 && dblNum % 180 != 0) ) { 
                return null;
            }
            return Math.Tan(dblNum * (Math.PI / 180) );
        }

        public Nullable<double> TanFromRad<T>(T numA)
        {
            bool isNum = double.TryParse(numA.ToString(), out double dblNum);

            if (!isNum || ( dblNum % (Math.PI / 2) == 0 && dblNum % Math.PI != 0) ) { 
                return null;
            }
            return Math.Tan(dblNum);
        }

    }

    public enum AngleType
    {
        Deg,
        Rad
    }
}

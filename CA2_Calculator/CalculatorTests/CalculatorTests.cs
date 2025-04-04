﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA2_Calculator;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_2Plus5_Equals7()
        {
            Calculator calc = new Calculator();
            var result = calc.Add(2, 5);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Add_2PlusNegative5_EqualsNegative3()
        {
            Calculator calc = new Calculator();
            var result = calc.Add(2, -5);
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void CosFromDeg_ZeroCos_Equals1()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromDeg(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CosFromDeg_60Cos_Equals0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromDeg(60);
            Assert.AreEqual(0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void CosFromDeg_90Cos_EqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromDeg(90);
            Assert.AreEqual(0, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void CosFromDeg_240Cos_EqualsNegative0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromDeg(240);
            Assert.AreEqual(-0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void CosFromDeg_Negative60Cos_Equals0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromDeg(-60);
            Assert.AreEqual(0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void CosFromDeg_900Cos_EqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromDeg(900);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CosFromRad_PiOver3Cos_Equals0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromRad(Math.PI / 3.0);
            Assert.AreEqual(0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void CosFromRad_PiOver2Cos_EqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromRad(Math.PI / 2.0);
            Assert.AreEqual(0, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void CosFromRad_4PiOver3Cos_EqualsNegative0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromRad(4.0 * Math.PI / 3.0);
            Assert.AreEqual(-0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void CosFromRad_NegativePiOver3Cos_Equals0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromRad(-Math.PI / 3.0);
            Assert.AreEqual(0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void CosFromRad_5PICos_EqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.CosFromRad(5.0 * Math.PI);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Cube_3CubedEquals27()
        {
            Calculator calc = new Calculator();
            var result = calc.Cube(3);
            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void Cube_Negative1CubedEqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.Cube(-1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Cube_ZeroCubedEqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.Cube(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Cube_2Point5CubedEquals15Point625()
        {
            Calculator calc = new Calculator();
            var result = calc.Cube(2.5);
            Assert.AreEqual(15.625, result);
        }

        [TestMethod]
        public void CubeRoot_64CubeRootEquals4()
        {
            Calculator calc = new Calculator();
            var result = calc.CubeRoot(64);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CubeRoot_Negative8CubeRootEqualsNaN()
        {
            Calculator calc = new Calculator();
            var result = calc.CubeRoot(-8);
            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void CubeRoot_9Point261CubeRootEquals2Point1()
        {
            Calculator calc = new Calculator();
            var result = calc.CubeRoot(9.261);
            Assert.AreEqual(2.1, result);
        }

        [TestMethod]
        public void CubeRoot_ZeroCubeRootEqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.CubeRoot(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Divide_25DividedBy2_Equals12Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.Divide(25, 2);
            Assert.AreEqual(12.5, result);
        }

        [TestMethod]
        public void Divide_200DividedByNegative10_EqualsNegative20()
        {
            Calculator calc = new Calculator();
            var result = calc.Divide(200, -10);
            Assert.AreEqual(-20, result);
        }

        [TestMethod]
        public void Exponent_2Exp4Equals16()
        {
            Calculator calc = new Calculator();
            var result = calc.Exponent(2, 4);
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void Exponent_Negative1Exp6Equals1()
        {
            Calculator calc = new Calculator();
            var result = calc.Exponent(-1, 6);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Exponent_ZeroExp20()
        {
            Calculator calc = new Calculator();
            var result = calc.Exponent(0, 20);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Exponent_Negative2Exp5EqualsNegative32()
        {
            Calculator calc = new Calculator();
            var result = calc.Exponent(-2, 5);
            Assert.AreEqual(-32, result);
        }

        [TestMethod]
        public void Factorial_3FactorialEquals6()
        {
            Calculator calc = new Calculator();
            var result = calc.Factorial(3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Factorial_10FactorialEquals3628800()
        {
            Calculator calc = new Calculator();
            var result = calc.Factorial(10);
            Assert.AreEqual(3628800, result);
        }

        [TestMethod]
        public void Factorial_ZeroFactorialEquals1()
        {
            Calculator calc = new Calculator();
            var result = calc.Factorial(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Factorial_Negative3FactorialEqualsNull()
        {
            Calculator calc = new Calculator();
            var result = calc.Factorial(-3);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void Multiply_Negative5Point2MultiplyBy2_EqualsNegative10Point4()
        {
            Calculator calc = new Calculator();
            var result = calc.Multiply(-5.2, 2);
            Assert.AreEqual(-10.4, result);
        }

        [TestMethod]
        public void Multiply_1000MultiplyByZero_EqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.Multiply(1000, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SinFromDeg_ZeroSin_EqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromDeg(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SinFromDeg_30Sin_Equals0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromDeg(30);
            Assert.AreEqual(0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void SinFromDeg_90Sin_Equals1()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromDeg(90);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SinFromDeg_210Sin_EqualsNegative0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromDeg(210);
            Assert.AreEqual(-0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void SinFromDeg_Negative30Sin_EqualsNegative0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromDeg(-30);
            Assert.AreEqual(-0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void SinFromDeg_630Sin_EqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromDeg(630);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SinFromRad_ZeroSin_EqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromRad(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SinFromRad_PiOver6Sin_Equals0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromRad(Math.PI / 6.0);
            Assert.AreEqual(0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void SinFromRad_PiOver2Sin_Equals1()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromRad(Math.PI / 2.0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SinFromRad_7PiOver6Sin_EqualsNegative0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromRad(7.0 * Math.PI / 6.0);
            Assert.AreEqual(-0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void SinFromRad_NegativePiOver6Sin_EqualsNegative0Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromRad(-Math.PI / 6.0);
            Assert.AreEqual(-0.5, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void SinFromRad_7PiOver2Sin_EqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.SinFromRad(7.0 * Math.PI / 2.0);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Subtract_10Minus4_Equals6()
        {
            Calculator calc = new Calculator();
            var result = calc.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Subtract_10MinusNegative10_Equals20()
        {
            Calculator calc = new Calculator();
            var result = calc.Subtract(10, -10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Square_3SquaredEquals9()
        {
            Calculator calc = new Calculator();
            var result = calc.Square(3);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Square_Negative1SquaredEquals1()
        {
            Calculator calc = new Calculator();
            var result = calc.Square(-1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Square_2Point5SquaredEquals6Point25()
        {
            Calculator calc = new Calculator();
            var result = calc.Square(2.5);
            Assert.AreEqual(6.25, result);
        }

        [TestMethod]
        public void Square_ZeroSquaredEqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.Square(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SquareRoot_64SquareRootEquals8()
        {
            Calculator calc = new Calculator();
            var result = calc.SquareRoot(64);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void SquareRoot_Negative3SquareRootEqualsNaN()
        {
            Calculator calc = new Calculator();
            var result = calc.SquareRoot(-3);
            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void SquareRoot_2Point25SquareRootEquals1Point5()
        {
            Calculator calc = new Calculator();
            var result = calc.SquareRoot(2.25);
            Assert.AreEqual(1.5, result);
        }

        [TestMethod]
        public void SquareRoot_ZeroSquareRootEqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.SquareRoot(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TanFromDeg_ZeroTan_EqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromDeg(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TanFromDeg_45Tan_Equals1()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromDeg(45);
            Assert.AreEqual(1, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void TanFromDeg_90Tan_EqualsNull()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromDeg(90);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void TanFromDeg_135Tan_EqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromDeg(135);
            Assert.AreEqual(-1, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void TanFromDeg_Negative45Tan_EqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromDeg(-45);
            Assert.AreEqual(-1, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void TanFromDeg_585Tan_Equals1()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromDeg(585);
            Assert.AreEqual(1, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void TanFromRad_ZeroTan_EqualsZero()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromRad(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TanFromRad_PiOver4Tan_Equals1()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromRad(Math.PI / 4.0);
            Assert.AreEqual(1, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void TanFromRad_PiOver2Tan_EqualsNull()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromRad(Math.PI / 2.0);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void TanFromRad_3PiOver4Tan_EqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromRad(3.0 * Math.PI / 4.0);
            Assert.AreEqual(-1, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void TanFromRad_NegativePiOver4Tan_EqualsNegative1()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromRad(-Math.PI / 4.0);
            Assert.AreEqual(-1, Math.Round((double)result, 12));
        }

        [TestMethod]
        public void TanFromRad_13PiOver4Tan_Equals1()
        {
            Calculator calc = new Calculator();
            var result = calc.TanFromRad(13.0 * Math.PI / 4.0);
            Assert.AreEqual(1, Math.Round((double)result, 12));
        }

    }
}

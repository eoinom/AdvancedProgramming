using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA2_Calculator;

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
        public void Cube_3CubedEquals27()
        {
            Calculator calc = new Calculator();
            var result = calc.Cube(3);
            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void Cube_Negative1CubedEqualsMinus1()
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
        public void Exponent_Minus2Exp5EqualsMinus32()
        {
            Calculator calc = new Calculator();
            var result = calc.Exponent(-2, 5);
            Assert.AreEqual(-32, result);
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
    }
}

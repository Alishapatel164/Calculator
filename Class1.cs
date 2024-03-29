﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace Test_Calculator
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input4point5and8point9_Returns13point4()
            {
                double number1 = 4.5; double number2 = 8.9; 
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetAddition(); 
                Assert.AreEqual(expectedResult, actualResult); 
            }
            [Test]
            public void GetAddition_Inputminus1point2andminus4point2_Returnsminus5point4()
            {
                double number1 = -1.2; double number2 = -4.2;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetAddition();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetAddition_Inputplus5andplus7_Returnsplus12()
            {
                double number1 = 5; double number2 = 7;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetAddition();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetAddition_Inputminus8andminus3_Returnsminus11()
            {
                double number1 = -8; double number2 = -3;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetAddition();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetSubtraction_Input5and3_Returns2()
            {
                double number1 =5; double number2 = 3;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetSubtraction();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetSubtraction_Inputminus3andminus8_Returnsminus11()
            {
                double number1 = -3; double number2 = -8;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetSubtraction();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetSubtraction_Inputminus3point2andminus0_Returnsminus3point2()
            {
                double number1 = -3.2; double number2 = 0;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetSubtraction();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetSubtraction_Inputminus1point2andminus3point4_Returnsminus3pointminus4point6()
            {
                double number1 = -1.2; double number2 =-3.4;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetSubtraction();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetMultiplication_Inputminus4andminus9_Returnsminus24()
            {
                double number1 = -3; double number2 = -8;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetMultiplication();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetMultiplication_Inputminus2and0_Returns0()
            {
                double number1 = -2; double number2 = 0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetMultiplication();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetMultiplication_Input8and0_Returns0()
            {
                double number1 = 8; double number2 = 0;
                double expectedResult = number1*number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetMultiplication();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetMultiplication_Input7andminus3_Returnsminus21()
            {
                double number1 = 7; double number2 = 3;
                double expectedResult = number1*number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetMultiplication();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetDivison_Input8andminus2_Returns4()
            {
                double number1 = 8; double number2 = 2;
                double expectedResult = number1/number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetMultiplication();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetDivison_Input4point2and2point1_Returns2()
            {
                double number1 = 4.2; double number2 = 2.1;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetMultiplication();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetDivison_Input6and0_Returnscantdivide()
            {
                double number1 = 6; double number2 = 0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetMultiplication();
                Assert.AreEqual(expectedResult, actualResult);
            }
            public void GetDivison_Input10and1_Return10()
            {
                double number1 = 10; double number2 = 1;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                double actualResult = testCalc.GetMultiplication();
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}

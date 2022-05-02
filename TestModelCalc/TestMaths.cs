using ModelCalc;
using NUnit.Framework;

namespace TestModelCalc
{
    public class Tests
    {
        [Test]
        public void Add_NominalCase_Success()
        {
            //given
            Maths math = new Maths();
            int op1 = 2;
            int op2 = 3;
            int expectedResult = 5;
            int actualResult = 0;

            //when
            actualResult = math.Add(op1, op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Sub_NominalCase_Success()
        {
            //given
            Maths math = new Maths();
            int op1 = 10;
            int op2 = 3;
            int expectedResult = 7;
            int actualResult = 0;

            //when
            actualResult = math.Sub(op1, op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Mul_NominalCase_Success()
        {
            //given
            Maths math = new Maths();
            int op1 = 10;
            int op2 = 3;
            int expectedResult = 30;
            int actualResult = 0;

            //when
            actualResult = math.Mul(op1, op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Div_NominalCase_Success()
        {
            //given
            Maths math = new Maths();
            int op1 = 10;
            int op2 = 3;
            int expectedResult = 30;
            int actualResult = 0;

            //when
            actualResult = math.Mul(op1, op2);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
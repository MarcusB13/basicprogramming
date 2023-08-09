using System;
using Xunit;
using System.IO;

namespace Basic_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddSeparator()
        {
            string ExpectedResult = "M-a-r-c-u-s";
            string InputString = "Marcus";

            string Result = basic.Program.AddSeparator(InputString, "-");
            Assert.Equal(ExpectedResult, Result);
        }

        public void TestAdd()
        {
            int ExpectedResult = 12;
            int InputNumberOne = 7;
            int InputNumberTwo = 2;
            int InputNumberThree = 3;

            int result = basic.Program.add(InputNumberOne, InputNumberTwo, InputNumberThree);
            Assert.Equal(ExpectedResult, result);

            int TestWrongResult = basic.Program.add(2, 4, 1);
            Assert.NotEqual(ExpectedResult, TestWrongResult);
        }

        public void TestIsResultTheSame()
        {
            bool ExpectedResult = true;

            bool result = basic.Program.IsResultTheSame(1 / 3, 2 / 6);
            Assert.Equal(ExpectedResult, result);

            ExpectedResult = false;
            result = basic.Program.IsResultTheSame(1 / 6, 2 / 6);
            Assert.Equal(ExpectedResult, result);
        }

        public void TestCubeOf()
        {
            double ExpectedResult = 125;
            double Input = 5;

            double result = basic.Program.CubeOf(Input);
            Assert.Equal(ExpectedResult, result);
        }

        public void TestFullSequenceOfLetters()
        {
            string ExpectedResult = "defghijklmn";
            string Input = "dn";

            string result = basic.Program.FullSequenceOfLetters(Input);
            Assert.Equal(ExpectedResult, result);
        }
    }
}



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

        [Fact]
        public void TestAdd()
        {
            int ExpectedResult = 27;
            int InputNumberOne = 7;
            int InputNumberTwo = 2;
            int InputNumberThree = 3;

            int result = basic.Program.add(InputNumberOne, InputNumberTwo, InputNumberThree);
            Assert.Equal(ExpectedResult, result);

            int TestWrongResult = basic.Program.add(2, 4, 1);
            Assert.NotEqual(ExpectedResult, TestWrongResult);
        }

        [Fact]
        public void TestIsResultTheSame()
        {
            bool ExpectedResult = true;

            bool result = basic.Program.IsResultTheSame(1 / 3, 2 / 6);
            Assert.Equal(ExpectedResult, result);

            bool secondExpectedResult = false;
            bool seconResult = basic.Program.IsResultTheSame((double) 1 / 6, (double) 2 / 6);
            Assert.Equal(secondExpectedResult, seconResult);
        }

        [Fact]
        public void TestCubeOf()
        {
            double ExpectedResult = 125;
            double Input = 5;

            double result = basic.Program.CubeOf(Input);
            Assert.Equal(ExpectedResult, result);
        }

        [Fact]
        public void TestFullSequenceOfLetters()
        {
            string ExpectedResult = "defghijklmn";
            string Input = "dn";

            string result = basic.Program.FullSequenceOfLetters(Input);
            Assert.Equal(ExpectedResult, result);
        }

        [Fact]
        public void TestOddOneOut()
        {
            int? ExpectedResult = 6;
            int[] Input = { 2, 6, 5, 2, 7, 5, 7, 8, 3, 9, 9, 3, 8 };

            int? result = basic.Program.FindTheOddOne(Input);
            Assert.Equal(ExpectedResult, result);
        }
    }
}


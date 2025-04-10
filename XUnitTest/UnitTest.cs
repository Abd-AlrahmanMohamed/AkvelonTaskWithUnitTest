using AkvelonApp;
using Xunit;

namespace XUnitTest
{
    public class UnitTest
    {
        [Fact]
        public void Test_InputContainsSumbols()
        {
            var input = "@ # $ % & ^ *";
            var result = Result.GetOutput(input);
            Assert.Equal(0, result.Count);
        }

        [Fact]
        public void Test_InpuIsNull()
        {
            var input = "";
            var result = Result.GetOutput(input);
            Assert.Equal(0, result.Count);
        }
        [Fact]
        public void Test_InputNotEqualThree()
        {
            var input = "Mary has";
            var result = Result.GetOutput(input);
            Assert.NotEqual(3, result.Count);
        }
        [Fact]
        public void Test_InputMatchTheWordBuzz()
        {
            var input = "Mary had a little lamb";
            var result = Result.GetOutput(input);
            Assert.True(result.FinalOutput.Contains("Buzz"));
        }
        [Fact]
        public void Test_InputIsGreaterThanFive()
        {
            var input = "Mary had a little lamb";
            var result = Result.GetOutput(input);
            Assert.Equal(5,result.Count);
        }
    }
}

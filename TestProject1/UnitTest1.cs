using CheckBracketsMatch;
using System;
using Xunit;

namespace TestProject1
{
    /// <summary>
    /// xUnit text 
    /// was for.NetCore 
    /// changed to .NetFramework from the "Edit Project file"
    /// targetframework = net48 (for dotNet  framework 4.8)
    /// </summary>
    public class UnitTest1
    {
        //[Fact]
        [Theory]
        [InlineData("(())")]
        [InlineData("{[]}")]
        [InlineData("{}([])")]
        public void Test1(string str)
        {
            Program p = new Program();
            bool result = p.Checker(str);

            Assert.True(result);


        }
    }
}

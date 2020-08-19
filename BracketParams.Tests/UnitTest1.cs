using System;
using Xunit;
using BracketsParams;

namespace BracketParams.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("()((({[}])()))",true)]
        [InlineData("{}[]{{}}()", true)]
        [InlineData("zxcv{(bxcvb)}dfb{sd vz[dfbf]}", true)]
        [InlineData("(fdb) bdfb{}dlfgbf{{{fb){}", false)]
        [InlineData("sdfds()fbadb(dfbgd_)bfdb{ljfbd{bdfb}", false)]
        public void BracketTestMustReturnTrueValue(string input,bool expected)
        {
            char[] inputBrackets = { '(', ')', '{', '}', '[', ']' };
            Assert.Equal(Brackets.BracketTest(input, inputBrackets), expected);
        }
    }
}

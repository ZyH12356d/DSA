using DSA.Core.StackAlgo;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.Stack
{
    public class PostFixTest
    {
        private PostFixConverter _postFixConverter = new PostFixConverter();
        
        [Fact]
        public void testEmpty()
        {
            Assert.Equal("", _postFixConverter.transform(""));
            Assert.Equal(null, _postFixConverter.transform(null));
        }
        [Fact]
        public void testSimpleCase()
        {
            Assert.Equal("ab+", _postFixConverter.transform("a+b"));
            Assert.Equal("ab*", _postFixConverter.transform("a*b"));
            Assert.Equal("AB*", _postFixConverter.transform("A*B"));
        }
        [Fact]
        public void testPrecedenceLevel()
        {
            Assert.True(_postFixConverter.isHigerorEqualPrecedence('+', '-'));
            Assert.True(_postFixConverter.isHigerorEqualPrecedence('*', '+'));
            Assert.False(_postFixConverter.isHigerorEqualPrecedence('+', '*'));

        }
        [Fact]
        public void testPrecedenceCase()
        {
            Assert.Equal("abc*+", _postFixConverter.transform("a+b*c"));
            Assert.Equal("ab*c+", _postFixConverter.transform("a*b+c"));
            Assert.Equal("abc*+de*+", _postFixConverter.transform("a+b*c+d*e"));
            Assert.Equal("abc*-de*+", _postFixConverter.transform("a-b*c+d*e"));
        }
        [Fact]
        public void testCaseWithParenthesis()
        {
            Assert.Equal("ab+c*", _postFixConverter.transform("(a+b)*c"));
            Assert.Equal("ab+cd+*", _postFixConverter.transform("(a+b)*(c+d)"));
            Assert.Equal("abc*+de+*", _postFixConverter.transform("(a+b*c)*(d+e)"));
        }
        

    }
}

using DSA.Core.StackAlgo;
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

    }
}

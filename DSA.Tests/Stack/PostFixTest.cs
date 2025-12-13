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
        //public PostFixTest(PostFixConverter postFixConverter) 
        //{ 
        //    _postFixConverter = postFixConverter;
        //}
        [Fact]
        public void testEmpty()
        {
            Assert.Equal("", _postFixConverter.transform(""));
            Assert.Equal(null, _postFixConverter.transform(null));
        }

    }
}

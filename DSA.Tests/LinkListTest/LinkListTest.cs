using DSA.Core.LinkList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.LinkListTest
{
    public class LinkListTest
    {
        LinkList _linkList = new();
        [Fact]
        public void testInsertWhenEmpty()
        {
            
            _linkList.append(100);
            IEnumerator<int> iterator = _linkList.createdIterator();
        }
    }
}

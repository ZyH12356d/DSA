using DSA.Core.StackAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.Stack.ExpressionEvalution
{
    public class ExpressionEvaluatorTest
    {
        Dictionary<char, int> variables = new();
        public ExpressionEvaluatorTest() 
        {
            variables.Add('a', 2);
            variables.Add('b', 3);
            variables.Add('c', 5);
            variables.Add('d', 7);
        }
        [Fact]
        public void  testEval() 
        {
            ExpressionEvaluator evaluator = new ExpressionEvaluator();
            var result = evaluator.excute("a+b*c", variables);
            Assert.Equal(17, result);
            result = evaluator.excute("(a+b)*c", variables);
            Assert.Equal(25, result);
            result = evaluator.excute("(a+b)*(c+d)", variables);
            Assert.Equal(60, result);
            result = evaluator.excute("(a-b)*(c+d)", variables);
            Assert.Equal(-12, result);
        }
    }
}

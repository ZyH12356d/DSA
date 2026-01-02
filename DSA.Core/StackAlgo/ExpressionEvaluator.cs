using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Core.StackAlgo
{
    public class ExpressionEvaluator
    {
        public int excute(string input , Dictionary<char, int> variables)
        {
            Stack stack = new();
            PostFixConverter converter = new PostFixConverter();
            var postfix = converter.transform(input);
            for(int i=0; i<postfix.Length; i++)
            {
                char c = postfix[i];
                if (converter.isOperand(c))
                {
                    var value = variables[c];
                    stack.Push(value);
                }
                else if (converter.isOperator(c))
                {
                    var op2 = (int) stack.Pop();
                    var op1 = (int) stack.Pop();
                    switch (c)
                    {
                        case '+':
                            stack.Push(op1 + op2);
                            break;
                        case '-':
                            stack.Push(op1 - op2);
                            break;
                        case '*':
                            stack.Push(op1 * op2);
                            break;
                        case '/':
                            stack.Push(op1 / op2);
                            break;
                    }
                }
            }
            return (int)stack.Pop();
        }
    }
}

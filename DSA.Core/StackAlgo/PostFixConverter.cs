using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DSA.Core.StackAlgo
{
    public class PostFixConverter
    {
        /* 
			   operand --> output it. 
                            ’(’ --> push it on the stack. 
                            ’)’ --> pop operators from the stack to the output 
                            until a ’(’ is popped; do not output either 
                            of the parentheses. 
               operator --> pop higher- or equal-precedence operators 
                            from the stack to the output; stop before 
                            popping a lower-precedence operator or 
                            a ’(’. Push the operator on the stack.
			* */
        public static bool isOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^')
            {
                return true; 
            }
            return false;
        }
        public bool isOperand(char c)
        {
            return char.IsLetterOrDigit(c);
        }
        public string transform(string infix)
        {

            string postfix = string.Empty;
            if(string.IsNullOrEmpty(infix))
            {
                return infix;
            }
            Stack stack = new Stack();
            
            for (int i = 0; infix.Length > i; i++)
            {
                char c = infix[i];
                if (isOperand(c))
                {
                    postfix += c;
                }
                else if (isOperator(c))
                {
                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
            {
                postfix += stack.Pop();
            }


            return postfix;
        }
    }
}

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
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
            {
                return true;
            }
            return false;
        }
        public string transform(string infix)
        {
            if (infix == null || infix.Length == 0)
            {
                return infix;
            }
            //Stack stack = new Stack();
            //var postfix = "";
            //for (int i = 0; i < infix.Length; i++)
            //{ 
            //    var c = infix[i];
            //    if (isOperand(c)) 
            //    {

            //    }


            //}
            return infix;
        }
    }
}

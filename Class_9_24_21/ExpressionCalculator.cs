using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9_24_21
{

    public class ExpressionCalculator
    {
        
        public double CarculateEpression(string expression)
        {
            Stack<char> operationsStack = new Stack<char>();
            Stack<double> numsStack = new Stack<double>();
            bool isNextNegative = false;
            foreach (char temp in expression)
            {
                if (temp == '/')
                    operationsStack.Push(temp);
                if (temp == '*')
                    operationsStack.Push(temp);
                if (temp == '+')
                    operationsStack.Push(temp);
                if (temp == '-')
                {
                    isNextNegative = true;
                    if(numsStack.Count - operationsStack.Count != 0)
                        operationsStack.Push('+');
                }

                if (temp >= '0' && temp <= '9')
                {
                    if (numsStack.Count == operationsStack.Count)
                    {
                        if (isNextNegative == true)
                        {
                            numsStack.Push(-(Convert.ToInt32(temp) - '0'));
                            isNextNegative = false;
                        }
                        else
                            numsStack.Push(Convert.ToInt32(temp) - '0');
                    }
                    else
                    {
                        double num = numsStack.Pop();
                        num *= 10;
                        if (num >= 0)
                            num += Convert.ToInt32(temp) - '0';
                        else
                            num -= Convert.ToInt32(temp) - '0';
                        numsStack.Push(num);
                    }
                }
                
            }
            while (numsStack.Count != 1)
            {
                double bufNum, bufNum1;
                bufNum = numsStack.Pop();
                bufNum1 = numsStack.Pop();

                char bufSymbol = operationsStack.Pop();

                if (bufSymbol == '/')
                    numsStack.Push(bufNum1 / bufNum);
                if (bufSymbol == '*')
                    numsStack.Push(bufNum * bufNum1);
                if (bufSymbol == '+')
                {
                    if(operationsStack.Count == 0)
                    {
                        numsStack.Push(bufNum + bufNum1);
                        break;
                    }
                    char bufPeek = operationsStack.Peek();
                    if (bufPeek == '+' || bufPeek == '-')
                        numsStack.Push(bufNum + bufNum1);
                    else
                    {
                        double numPeek = numsStack.Peek();
                        if (bufPeek == '/')
                            numsStack.Push(bufNum1 / numPeek);
                        else
                            numsStack.Push(bufNum1 * numPeek);
                        operationsStack.Pop();

                        numsStack.Push(bufNum);
                        operationsStack.Push('+');
                    }

                }
                

            }
            return numsStack.Pop();
        }
    }
}

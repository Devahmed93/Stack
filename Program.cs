using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            Console.WriteLine("enter your input");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            foreach (string token in arr)
            {
                int val;
                if (int.TryParse(token,out val))
                {
                    s.push(val);

                }
                else
                {
                    int rhs = s.pop();
                    int lhs = s.pop();
                    switch (token)
                    {
                        case "+":
                            s.push(lhs + rhs);
                            break;
                        case "-":
                           s.push(Math.Abs(lhs - rhs));
                            break;
                        case "*":
                            s.push(Math.Abs(lhs * rhs));
                            break;
                        case "/":
                            s.push(Math.Abs(lhs / rhs));
                            break;

                        default:
                            break;
                    }
                }


            }
            Console.WriteLine("the result is\t" + s.pop());






        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stack
    {
      static  int capacity = 1000;
        int top;
        int[] stack = new int [capacity];
        public Stack()
        {
            top = -1;
        }
        public bool push (int data)
        {
            if (top==capacity-1)
            {
                Console.WriteLine("Stack overflow");
                return false;

            }
            else
            {
                stack[++top]=data;
                return true;
            }


        }
        public int pop()
        {
            if (top<0)
            {
                Console.WriteLine("stack underflow");
                return 0;

            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Operations
{
    public class Stack_operations
    {
        const int MAX = 10;
        int top;
        int[] stack = new int[MAX];
        public Stack_operations()
        {
            top = -1;
        }
        public void Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                
            }
            else
            {
                stack[++top] = data;
                Console.WriteLine("Pushed Element is" +" "+ data); ;
            }
        }

        public int  Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                Console.WriteLine("Poped Element :"+" "+stack[top]);
                int value = stack[top--];
                return value;
            }
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        public void Display()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return ;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       10/23/18
/// Purpose:    Array Based Stack Implementation
/// </summary>

namespace ArrayBasedStack
{
    class Stack
    {
        #region -- Class Fields
        int size;                           //Contains how many integers are currently in the stack
        int top;                            //Value on top of stack
        static int capacity = 10;                //The maximum number of integers in the stack can be
        int[] stack = new int[capacity];    //Contains the actual integers in the stack
        #endregion -- Class Fields

        #region -- Constructors
        /// <summary>
        /// Default No Arg
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// One Arg Constructor
        /// </summary>
        /// <param name="topVal"></param>
        public Stack(int topVal)
        {
            top = topVal;
        }
        #endregion -- Constructors

        #region -- Methods
        /// <summary>
        /// Pop Method
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }//end of if
            else
            {
                int value = stack[top--];
                return value;
            }//end of else
        }//end of Pop()

        /// <summary>
        /// Push Method
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Push(int data)
        {
            if (top >= capacity)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }//end of if
            else
            {
                stack[++top] = data;
                return true;
            }//end of else
        }//end of Push()

        /// <summary>
        /// Peek Method
        /// </summary>
        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }//end of if
            else
                Console.WriteLine("\nThe value on the top of this Stack is: {0}", stack[top]);

        }//end of Peek()

        /// <summary>
        /// Method to display stack elements
        /// </summary>
        internal void ShowStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("\nThe elements in this Stack are:");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        #endregion -- Methods


    }
}

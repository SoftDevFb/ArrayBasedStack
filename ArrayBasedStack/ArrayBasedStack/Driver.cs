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
    class Driver
    {
        static void Main(string[] args)
        {
            Stack newStack = new Stack();

            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.ShowStack();
            newStack.Peek();
            Console.WriteLine("\nValue popped from this Stack : {0}", newStack.Pop());
            Console.WriteLine("\nThe after pop results are shown below...");
            newStack.ShowStack();
            Console.ReadKey();
        }
    }
}

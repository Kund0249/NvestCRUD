using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.GenericDemo
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            int Ch;
            do
            {
                Console.Write("Select => ");
                Ch = Convert.ToInt32(Console.ReadLine());
            } while (Ch != 0);

            Random random = new Random();

            int n = random.Next();

            Console.WriteLine(n);

            // Stack<int> stack = new Stack<int>();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // stack.Push(4);
            // stack.Push(5);
            // stack.Pop();
            //int ele =  stack.Peek();
            // Console.WriteLine("Ele : " + ele);
            // foreach (int item in stack)
            // {
            //     Console.WriteLine(item);
            // }

        }
    }
}

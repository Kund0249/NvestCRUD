using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.GenericDemo
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>()
            //{ 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            int n = queue.Peek();
            queue.Dequeue();
            //Console.WriteLine(n);
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}

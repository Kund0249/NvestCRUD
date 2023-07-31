using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD
{
    delegate void MyDel();
    class ABC
    {
        public void Fun1()
        {
            Console.WriteLine("Fun1 Invocked");
        }

        public void Fun2()
        {
            Console.WriteLine("Fun2 Invocked");
        }

        public void Fun3()
        {
            Console.WriteLine("Fun3 Invocked");
        }
    }
    class DelegateDemo
    {
        static void Main(string[] args)
        {
            ABC aBC = new ABC();

            MyDel del = new MyDel(aBC.Fun1);
            del += aBC.Fun2;
            del += aBC.Fun3;



            // del.Invoke();
            del();
            del.Invoke();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD
{
    delegate bool IsValid(int n);
    class TestsClass
    {
        public TestsClass()
        {
            NumberList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
            };
        }
        private List<int> NumberList { get; set; }

        public void PrintNumbre(IsValid valid)
        {
            foreach (int n in NumberList)
            {
                if(valid(n))
                Console.WriteLine(n);
            }
        }
    }
    class DelegateExample
    {
        //public static bool MyLogic(int n)
        //{
        //    if (n > 5 && n < 12)
        //        return true;
        //    return false;
        //}
        static void Main(string[] args)
        {
            TestsClass ob = new TestsClass();

           // IsValid del = new IsValid(MyLogic);

            ob.PrintNumbre(x => x > 5 && x < 12);
        }
    }
}

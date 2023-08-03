using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NvestCRUD.Dir_File
{
    class Demo3
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\Admin\Desktop\Sample2";
            if (Directory.Exists(FilePath))
            {
                var files = Directory.EnumerateFiles(FilePath);

                foreach (var file in files)
                {
                    //Console.WriteLine(Path.GetFileName(file));
                }
            }
        }
    }
}

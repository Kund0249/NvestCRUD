using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestCRUD.Dir_File
{
    class Demo2
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\Admin\Desktop\Sample2\SampleText.txt";
            if (File.Exists(FilePath))
            {
                using(StreamReader reader = new StreamReader(FilePath))
                {
                    //string fileContent = reader.ReadLine();
                    //Console.WriteLine(fileContent);

                    //Console.WriteLine(reader.ReadLine());
                    //Console.WriteLine(reader.ReadLine());
                    //Console.WriteLine(reader.ReadLine());

                    string Line;

                    while ((Line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(Line);
                    }
                }
            }
        }
    }
}

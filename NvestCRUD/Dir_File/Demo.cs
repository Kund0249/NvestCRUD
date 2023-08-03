using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NvestCRUD.Dir_File
{
    class Demo
    {
        static void Main(string[] args)
        {
            string FolderPath = @"C:\Users\Admin\Desktop\Sample2";

            // bool isExists = Directory.Exists(FolderPath);

            //if(isExists)
            //    Console.WriteLine("Directory Available.");
            //else
            //    Console.WriteLine("Directory Not Found.");

            //if (isExists)
            //{
            //    //Directory.CreateDirectory(FolderPath);
            //    //Console.WriteLine("Directory Created!");
            //    Directory.Delete(FolderPath);
            //    Console.WriteLine("Directory Deleted!");
            //}

            //if (!Directory.Exists(FolderPath))
            //{
            //    Directory.CreateDirectory(FolderPath);

            //    string filePath = Path.Combine(FolderPath, "SampleText.txt");

            //    File.Create(filePath);
            //    //Console.WriteLine("Directory Created!");
            //    Console.WriteLine("File Created!");
            //}
            DateTime currentdate = DateTime.Now;
            Console.WriteLine(string.Format("{0:d}", currentdate));

            //string filePath = Path.Combine(FolderPath, "SampleText.txt");

            //using(StreamWriter writer = new StreamWriter(filePath,true))
            //{
            //    writer.WriteLine("Some text here...");
            //}

        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
 
namespace InputOutput
{
    class FileUtilityClasses
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"E:\E:\apache-tomcat-9.0.17",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("We have Created our first file using Filestream");
            sw.WriteLine("Filestream is an utility class of input Output namespace");
            sw.WriteLine("FileStream inherits from the abstract class Stream");
            sw.Close();
            fs.Close();
            Console.WriteLine("Data writeen in the file...");
            Console.Read();
        }
    }
}

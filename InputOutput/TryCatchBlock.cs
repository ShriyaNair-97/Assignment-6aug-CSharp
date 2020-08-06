using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    class TryCatchBlock
    {
        static void Main()
        {
            FileStream fs=null;
            StreamWriter sw=null;
            try
            {
                fs = new FileStream(@"E:\file2.txt", FileMode.Open, FileAccess.Read);
                sw = new StreamWriter(fs);

                sw.WriteLine("We have Created our first file using Filestream");
                sw.WriteLine("Filesteeam is an utility class of input Output namespace");
                sw.WriteLine("FileStream inherits from the abstract class Stream");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Data written in the file...");
                sw.Close();
                fs.Close();
            }

        }
    }
}

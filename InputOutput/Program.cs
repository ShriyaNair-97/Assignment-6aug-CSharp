using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo dio = new DriveInfo("c:");
            Console.WriteLine($"The total free space:{ dio.AvailableFreeSpace / 1024}");
            Console.WriteLine($"The total space :{dio.TotalSize / 1024}");
            Console.WriteLine($"The root directory :{ dio.RootDirectory}");
            Console.WriteLine($"The Volume Label : { dio.VolumeLabel}");
            Console.WriteLine($"The drive type: {dio.DriveType}");
            Console.WriteLine($"{dio.IsReady}");
            DriveInfo[] res =DriveInfo.GetDrives();
            foreach (var item in res)
            {
                Console.WriteLine($"The List of the drives{item}");
            }

            //Directory Info Class

            DirectoryInfo dir = new DirectoryInfo(@"E:\FrontEnd\july-21-ques");
            DirectoryInfo[] arr = dir.GetDirectories();
            foreach(var d in arr)
            {
                Console.WriteLine($"FullName:{d.FullName} and name:{d.Name} with parent info: {d.Parent}");
            }
            FileInfo[] fio = dir.GetFiles();
            foreach (var f in fio)
            {
                Console.WriteLine($"FileName:{f.Name} and length of the file :{f.Length}");
            }
            FileInfo fileinfo = new FileInfo(@"E:\ZENSAR_TRAINING\PureBSAssignment\PureBSAssignment");
            if (fileinfo.Exists)
            {
                Console.WriteLine($"Name :{fileinfo.Name} extension:{fileinfo.Extension}");
                Console.WriteLine($"DirectoryName:{fileinfo.DirectoryName}");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}

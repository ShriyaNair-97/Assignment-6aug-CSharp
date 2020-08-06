using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int[] arr2 = { 5, 0, 3 };
            for (int i = 0; i < arr1.Length; i++)
            {
                    try
                    {
                        int ans = arr1[i] / arr2[i];
                        Console.WriteLine(ans);
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex.Message);
                    }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class IntParse
    {
        static void Main()
        {
            Console.WriteLine("Int.Parse method ----------");
            string a = "34567";
            string b = "0";
            string c = null;
            string d = "34567.65";
            string e = "767672163871458736187362";
            int output;
            output = int.Parse(a);
            Console.WriteLine("Result for string a:{0}", output);
            output = int.Parse(b);
            Console.WriteLine("Result for string b:{0}", output);
            output = int.Parse(c);//ArguementNullException
            Console.WriteLine("Result for string c:{0}", output);
            output = int.Parse(d);//FormatException
            Console.WriteLine("Result for string d:{0}", output);
            output = int.Parse(e);
            Console.WriteLine("Result for string e:{0}", output);



            Console.WriteLine("Convert method---------");
            //For Convert.ToInt32 when you pass null value it returns 0.This is the difference between the int.Parse()
            //and Convert.ToInt32().int.Parse() throws ArguementNullException.



            //Similarities between both the methods 
            //1. when you pass any value other than interger they will throw FormatException
            //2.when the value is too long or too short both methods will throw OverflowException
            string a1 = "12989";
            string b1 = "0";
            string c1 = null;
            string d1 = "8909.987";
            string e1 = "767672163871263876128736187362";
            int output1;
            output1 = Convert.ToInt32(a1);
            Console.WriteLine("Result for string a1:{0}", output1);
            output1 = Convert.ToInt32(b1);
            Console.WriteLine("Result for string b1:{0}", output1);
            output1 = Convert.ToInt32(c1);
            Console.WriteLine("Result for string c1:{0}", output1);
            //final1 = Convert.ToInt32(d1);//FormatException
            //Console.WriteLine("Result for string d1:{0}", final1);
            output1 = Convert.ToInt32(e1);
            Console.WriteLine("Result for string e1:{0}", output1);



            Console.Read();
        } 
    }
}

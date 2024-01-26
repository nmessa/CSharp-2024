using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int num;
            double dnum;

            //Generate random integer
            num = r.Next();
            Console.WriteLine(num);

            //Generate a random integer from 0 to 8
            num = r.Next(9);
            Console.WriteLine(num);

            //Generate a random integer from 1 to 5
            num = r.Next(1,6);
            Console.WriteLine(num);

            ////Generate a random floating point number 0.0000 to 0.9999....
            dnum = r.NextDouble();
            Console.WriteLine(dnum);
        }
    }
}
//Output
//1764071435
//3
//5
//0.455846664708036

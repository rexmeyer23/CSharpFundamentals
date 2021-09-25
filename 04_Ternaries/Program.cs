using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ternaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 77;

            //(Condition/Boolean) ? trueResult : falseResult 
            string result = (age > 17) ? "You are an adult" : "You are not an adult";
            Console.WriteLine(result);

            bool boolResult = (age > 17) ? true : false;
            Console.WriteLine(boolResult);
            Console.ReadKey();
            //Save result as a string since it delivers as a string
        }
    }
}

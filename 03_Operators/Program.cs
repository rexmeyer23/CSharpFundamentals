using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 7;
            int numTwo = 20;

            //Addition
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            //Subtraction
            int difference = numTwo - numOne;
            Console.WriteLine(difference);

            //Multiplication
            int product = numOne * numTwo;
            Console.WriteLine(product);

            //Division
            int quotient = numOne / numTwo;
            Console.WriteLine(quotient);

            //Remainder
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            //TimeSpan
            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1997, 5, 6);
            TimeSpan timeSpan = today - someDay;
            Console.WriteLine(timeSpan);

            //Conversions - how one variable is transformed to another type of variable
            //Casting - take an object, attempt to force it to change types, 
            //type name = (castType)value;
            int five = 5;
            double doubleFive = (double)five;
            Console.WriteLine(doubleFive);

            char a = 'a';
            int valueA = (int)a;
            Console.WriteLine(valueA);
            Console.WriteLine(a);

            //string myString = "This is a string.";
            //byte myByte = (byte)myString;

            decimal myMoney = 5.87m;
            int intMoney = (int)myMoney;//5

            //Conversion - takes value of a particular type, changes it into another, more forgiving, longer to execute, not as prone to errors, more likely to succeed
            //type =  Convert.ToType(value);

            int intFive = 5;
            decimal decimalFive = Convert.ToDecimal(intFive);

            decimal decimalTwo = 2.55m;
            int intTwo = Convert.ToInt32(decimalTwo); //3

            //Parsing
            //type name = type.Parse(string);
            string decimalString = "5.69878";
            decimal decimalValue = decimal.Parse(decimalString);

            //look up keywords 'is', 'as', and 'type of' regarding conversion


            //Comparison Operators
            Console.WriteLine("Enter your age.");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter your name.");
            string userName = Console.ReadLine();

            bool equals = (age == 41);
            Console.WriteLine("User is 41: " + equals);
            //bools can easily look like a string, so computer won't have issues


            bool notEquals = age != 41;
            Console.WriteLine($"User is not 41: {notEquals}");
            Console.WriteLine(notEquals);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine("Lists are equal: " + listsAreEqual);//False becase they are two completely different objects in computer memory

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 55;
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 99;

            int numberOne = 12;
            int numberTwo = 21;

            bool OrValue = equals || notEquals;

            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;

            bool andValue = equals && notEquals;
            tOrT = true && true;
            tOrF = true && false;
            fOrT = false && true;
            fOrF = false && false;

            //&& - both sides of the comparison has to be true in order to deliver a true bool
            int x = 13;
            bool test = x < 44 && x > 10;// asking is 13 less than 44 and is 13 greater than 10
            Console.WriteLine(test);

            //|| - ONLY one side of the comparison has to be true in order to deliver a true bool
            int y = 10;
            bool test2 = y > 20 || y < 5;//asking is greater than 20 or is 10 lass than 15
            Console.WriteLine(test2);


            //Console.ReadLine() will always be a string
            //string can't be added to variables?
            //Console.ReadLine() expresses a strinh, pauses a test run
            Console.ReadKey();
            //Console.ReadKey() is usually at end of program, single character instead of string

        }
    }
}

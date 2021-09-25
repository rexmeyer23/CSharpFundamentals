using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Rex");
            int methodReturn = AddTwoNumbers(1, 2);
            //can also use other refernce types like strings methodRerturn = AddTwoNumbers(1, 2).ToString ();
            Console.WriteLine(methodReturn);

            AddTwoNumbers(3.05, 2.56);
            AddTwoNumbers(3, 2.55);//double value = int + double
            //int value = (int)AddTwoNumbers(3.66, 1);//double value = double + int  can't return an int due to precision loss
            //You'll never really use above, almost always want precision

            //DateTime birthday = new DateTime(1892,11,24));
            int age = CalculateAge(new DateTime(1892, 11, 24));
            Console.WriteLine($"My age is: {age}");

            //double methodDouble = 3.05;
            //double methodReturnTwo = AddTwoNumbers(methodDouble, methodReturn);
            //Console.WriteLine(methodReturnTwo);
            

            //Overload means there are mulitple options in a method
            //int numOne = 1000;
            //int numTwo = 2000;
            //int sum = numOne + numTwo;
            //Console.WriteLine(sum);

            //int numThree= 5000
            //int numFour = 10000
            //int sumTwo = numThree + numFour;
            //Console.WriteLine(sumTwo);

        }

        //1) Access Modifier - public or private
        //2) Return Type - perfoms action, i.e. void - doesn't return anything
        //3) Method Signature - methods are what does the work and what gets executed
            //Name - i.e. SayHello
            //Parameters - what goes inside paranthesis, say when building method, say arguments when it is being called
        //4) body - the actual code, what goes inside the curly braces

        //Build a method in order to call a method
        //Below is the built method
        [TestMethod]
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello World! And Hello {name}!");
            // Console.WriteLine doesn't retunr anything, just writes to the console
        }

        [TestMethod]
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        
        [TestMethod]
        public double AddTwoNumbers(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        [TestMethod]
        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            //double floorValue = Math.Floor(totalAgeInYears);
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }

        
    }
}

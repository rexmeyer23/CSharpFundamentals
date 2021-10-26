using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsConsole
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee (int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary
            //collection of key value pairs
            //systems.collections.generic name for all collection we use

            //dictionaries are used normally to look up something
            //collections are more dynamic, can add to it
            Dictionary<int, Employee> _employeeDictionary = new Dictionary<int, Employee>();

            Employee employee1 = new Employee(1,"James", 75000);
            Employee employee2 = new Employee(2, "Matt", 45000);
            Employee employee3 = new Employee(3, "Todd", 150000 );

            _employeeDictionary.Add(employee1.ID, employee1);
            _employeeDictionary.Add(employee2.ID, employee2);
            _employeeDictionary.Add(employee3.ID, employee3);
            //have to add key and object value for dictionary
            //using ID prop is key to other values

            Employee isEmployee2 =_employeeDictionary[2];
            //how we find a specific value based on key
            Console.WriteLine(isEmployee2.Name);
            Console.ReadKey();

            foreach(KeyValuePair<int, Employee> kvp in _employeeDictionary)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Employee emp = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ", emp.ID, emp.Name, emp.Salary);
                Console.WriteLine("====================================================================");
            }
            Console.ReadKey();
            Employee employeeError = new Employee(1, "John", 900000);
            if (_employeeDictionary.ContainsKey(employeeError.ID))
            {
                Console.WriteLine("Dictionary already contains key.");
            }
            else
            {
                _employeeDictionary.Add(employeeError.ID, employeeError);
            }

            Employee emp2;
            if (_employeeDictionary.TryGetValue(100, out emp2))
            //out is a keyword in C# which is used for the passing the arguments to methods as a reference type. It is generally used when a method returns multiple values.
            {
                Console.WriteLine(emp2.Name);
            }
            else
            {
                Console.WriteLine("Key not found.");
            }
            Console.ReadKey();

            _employeeDictionary.Remove(1);

            _employeeDictionary.Clear();

            int count = _employeeDictionary.Count(kvp => kvp.Value.Salary > 100000);
            Console.WriteLine(count);
            Console.ReadKey();

            //foreach(KeyValuePair<int, Employee> kvp in _employeeDictionary)
            //{
            //    if(kvp.Value.Salary > 100000)
            //    {
            //        count2++;
            //    }
            //}
            //.Count get numbers of key value pairs in dictionary
            //its a propery in dictonary class
            //--------------------------------------------------------------------

            //Queues
            //first in, first out
            //analogy like a bank, 1st person in line is 1st to leave
            //opposite of stack

            Queue<Employee> _employeeQueue = new Queue<Employee>();

            Employee employee4 = new Employee(1, "James", 75000);
            Employee employee5 = new Employee(2, "Matt", 45000);
            Employee employee6 = new Employee(3, "Todd", 150000);

            //Adding to a queue
            _employeeQueue.Enqueue(employee4);
            _employeeQueue.Enqueue(employee5);
            _employeeQueue.Enqueue(employee6);

            //remove from our queue
            Employee emp3 = _employeeQueue.Dequeue();
            //dequeue removes item from queue, does the first in list
            Console.WriteLine(emp3.Name); //Print James to console
            Console.ReadKey();

            bool isEmp4 = _employeeQueue.Contains(employee4);
            Console.WriteLine(isEmp4);//Prints false to console

            foreach(Employee emp in _employeeQueue)
            {
                _employeeQueue.Dequeue();
            }
            //--------------------------------------------------------

            Employee employee7 = new Employee(1, "James", 75000);
            Employee employee8 = new Employee(2, "Matt", 45000);
            Employee employee9 = new Employee(3, "Todd", 150000);

            //Stack
            //last in, first out
            Stack<Employee> _employeeStack = new Stack<Employee>();

            _employeeStack.Push(employee7);
            _employeeStack.Push(employee8);
            _employeeStack.Push(employee9);

            Employee topOfStack = _employeeStack.Pop();
            //returns object, does not take in an argument
            Console.WriteLine(topOfStack.Name);
            Console.ReadKey();

            Employee emp10 = _employeeStack.Peek();
            //returns object at top of stack without removing it
            Console.WriteLine(emp10.Name);//prints Todd;

            //Hashset


        }
        //polymorphism in C# is providing an ability to take more than one form, and it's one of the main pillar concepts of object-oriented programming after encapsulation and inheritance. Generally, polymorphism is a combination of two words, poly, and another one is morphs.
        //two types:
        //compile time polymorphism and run time polymorphism
        //compile time errors are when you time something wrong in code and get error line
        //compile time polymorphism defining multiple methods with the same name but with different parameters. 
        //run time polymorphism By runtime polymorphism we can point to any derived class from the object of the base class at runtime that shows the ability of runtime binding 
        //polymorphism is used through inheritance in C#
    }
}

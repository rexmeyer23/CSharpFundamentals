using _07_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_ClassesTests
{
    [TestClass]
    public class PersonMethodTest
    {
        [TestInitialize]
        public void Arrange()
        {
            _personRepo = new PersonRepository();
        }
        //public void Test_AddPerson()
       // { 
            //Arrange
            //PersonRepository _repo = new PersonRepository();
            //Person person1 = new Person();

            //Act
            //List<Person> localList = _repo.ReturnListOfPeople();
            //int count = localList.Count;

            //_repo.AddPerson2(person);

            //List<Person> updatedLocalList = _repo.ReturnListOfPeople();
            //int newCount = updatedLocalList.Count;

            //bool result = newCount == (count + 1) ? true : false;

            //Assert
            //Assert.IsTrue(result);

        //}
        [TestMethod]
        public void Test_AddPerson2()
        {   //AAA
            //Arrange
            PersonRepository _repo = new PersonRepository();
            Person person1 = new Person();
            
            //Act
            bool result = _repo.AddPerson2(person1);

            //Assert
            Assert.IsTrue(result);
        }

            //3 As of Test Method
            //AAA
            //ARRANGE = Setting up test data required to test our method.
            //What do I need to test this method.
            //PersonRepository _repo = new PersonRepository();
            //Person personTest = new Person();


            //ACT = Calling our method and saving what it returns (if it returns anything) to a variable.

            //List<Person> localList = _repo.ReturnListOfPeople();
            //int count = localList.Count;

            //bool actual = _repo.AddPerson2(personTest);


            //ASSERT - After we have run our method, we need to compare what the
            //method returned or the result of the method running to the expected
            //using Assert Methods.
            //Assert.IsTrue(actual);
            //not null - does exist, is null - does not exist

        
        //[TestInitialize] //not test method, method that has data in it
        //runs before every individual test is run
        private PersonRepository _personRepo;
        [TestMethod]
        public void Test_DeletePersonByFirstName()
        {

            //Arrange
            Person person = new Person();
            person.FirstName = "Nabil";
            _personRepo.AddPerson2(person);

            //Act
            bool actual = _personRepo.DeletePersonByFirstName("Nabil");
            bool expected = true;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        
    }
}

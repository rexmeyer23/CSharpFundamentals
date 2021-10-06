using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{ //research collections: dictionaires, queues, arrays, hash sets
    //common methods associated with each
    public class PersonRepository
    { //inside of class global

        private List<Person> _listOfPeople = new List<Person>();
        public bool AddPerson2(Person person)
        {
            int beforeCount = _listOfPeople.Count;
            _listOfPeople.Add(person);
            int afterCount = _listOfPeople.Count;
            if (afterCount == (beforeCount + 1))
            {
                return true;
            }
            return false;
        }
        //challenge 5 - create a method that can delete a specific person from that list by a person's name
        public bool DeletePersonByFirstName(string name)
        {
            foreach(Person p in _listOfPeople)
            {
                if(p.FirstName == name)
                {
                    _listOfPeople.Remove(p);
                    return true;
                }
            }
            return false;
        }
            //_listOfPeople.Add(new Person());
            //creates an empty person object to stick on end of list
            //_listOfPeople.Add(new Person("Rex", "Meyer", new DateTime(1998, 03, 04), ));
            //do not pass object as stated above
    }
        //public List<Person> ReturnListOfPeople()
        //{
            //return _listOfPeople;
        //}
        //public void RemovePersonByName(string firstName)
        //{
            //remember foreach loop can't be endless
            //foreach (Person p in _listOfPeople)
            //{
                //if (p.FirstName == firstName) 
                //{
                    //_listOfPeople.Remove(p);
                //}
            //}
        //}

        //public Person UpdatePerson(Person oldPerson, Person newPerson) 
        //{ 
         //foreach(Person p in _listOfPeople)
                //p is the person object
            //{
               //if (p == oldPerson)
                //{
                  //p.FirstName = newPerson.FirstName;
                    //expressions in code work from right to left
                    //p.LastName = newPerson.LastName;
                    //p.DateOfBirth = newPerson.DateOfBirth;
                    //return p;
                //}

            //}
           //return null;
        //}



        //public void SomeMethod()
        //{ inside of here is local
        //    _listOfPeople
        //int x = 5;
        //}
    }

   


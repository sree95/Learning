using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PeopleRepository
    {
        public Person[] GetPerson()
        {

            var people = new Person[]
            {
                new Person() {FirstName = "John", LastName = "Rod", Rating = 5, StartDate = new DateTime(1980,10,5) },
                new Person() {FirstName = "Kenny", LastName = "Todd", Rating = 4, StartDate = new DateTime(1979,1,5) },
                new Person() {FirstName = "Todd", LastName = "Danni", Rating = 3, StartDate = new DateTime(1981,8,5) },
                new Person() {FirstName = "Just", LastName = "Dust", Rating = 5, StartDate = new DateTime(1983,7,5) },
                new Person() {FirstName = "Mark", LastName = "Anderson", Rating = 5, StartDate = new DateTime(1991,5,22) },
                new Person() {FirstName = "Brad", LastName = "Reba", Rating = 5, StartDate = new DateTime(1989,8,12) },
                new Person() {FirstName = "Tina", LastName = "Coach", Rating = 5, StartDate = new DateTime(1978,5,24) }
            };

            return people;                 

        }


        public Person GetPerson(string lastName)
        {
            var people = new List<Person>()
            {
                new Person() { FirstName="John", LastName="Koenig",
                    StartDate = new DateTime(1975, 10, 17), Rating=6 },
                new Person() { FirstName="Dylan", LastName="Hunt",
                    StartDate = new DateTime(2000, 10, 2), Rating=8 },
                new Person() { FirstName="John", LastName="Crichton",
                    StartDate = new DateTime(1999, 3, 19), Rating=7 },
                new Person() { FirstName="Dave", LastName="Lister",
                    StartDate = new DateTime(1988, 2, 15), Rating=9 },
                new Person() { FirstName="John", LastName="Sheridan",
                    StartDate = new DateTime(1994, 1, 26), Rating=6 },
                new Person() { FirstName="Dante", LastName="Montana",
                    StartDate = new DateTime(2000, 11, 1), Rating=5 },
                new Person() { FirstName="Isaac", LastName="Grampus",
                    StartDate = new DateTime(1977, 9, 10), Rating=4 }
            };

            Person selPerson = people.Where(s => s.LastName == lastName).FirstOrDefault();
            return selPerson;
        }


        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(List<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }
    }
}

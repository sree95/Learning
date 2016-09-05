using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRepository.CSV
{
    public class CSVRepository : IPersonRepository
    {
        string path;

        public CSVRepository()
        {
            var fileName = ConfigurationManager.AppSettings["CSVFileName"];
            path = AppDomain.CurrentDomain.BaseDirectory + fileName;
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>();

            if (File.Exists(path))
            {
                using (var sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        var elements = line.Split(',');

                        var person = new Person()
                        {
                            FirstName = elements[0],
                            LastName = elements[1],
                            StartDate = DateTime.Parse(elements[2]),
                            Rating = Int32.Parse(elements[3])
                        };

                        people.Add(person);
                    }
                }
            }

            return people;
        }

        public Person GetPerson(string lastName)
        {
            Person p = new Person();

            if (File.Exists(path))
            {
                using (var sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        var elements = line.Split(',');
                        if (lastName.ToLower() == elements[1].ToLower())
                        {
                            p.FirstName = elements[0];
                            p.LastName = elements[1];
                            p.StartDate = DateTime.Parse(elements[2]);
                            p.Rating = Int32.Parse(elements[3]);
                        }
                        
                    }
                }
            }
            return p;
        }

        public void UpdatePeople(IEnumerable<Person> updatePeople)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatePerson)
        {
            throw new NotImplementedException();
        }
    }
}

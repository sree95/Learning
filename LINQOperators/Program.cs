using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperators
{
    class Program
    {
        protected Program()
        {

        }

        static void Main()
        {
            CallerFunc();                        
        }

        private static void CallerFunc()
        {
            //OfTypeExample();
            //ProcessSorting();
            //SetOperations();
            //SetDistinct();
            //Quantifiers();
            //PrimeNumberCheck();
            Projection();
            
        }

        

        private static void Projection()
        {
            string[] famousQuotes = 
            {
                "Advertising is legalized laying",
                "Advertising is the greatest art of the twentieth century"
            };

            var query = (from e in famousQuotes from e1 in e.Split(' ') select e1).Distinct();

            var query2 = famousQuotes.SelectMany(e => e.Split(' ')).Distinct();

            LoopingwithGenerics(query2);
            
        }

        private static void PrimeNumberCheck()
        {
            List<int> validPrimePick = new List<int> { 2, 5, 8, 9, 6, 11, 13, 15, 18, 19, 21, 23, 27, 29 };

            //var prime = validPrimePick.Where()
        }

        private static void EvenNumberWithQantifiers()
        {
            List<int> validPrimePick = new List<int> { 2, 5, 8, 9, 6, 11, 13, 15, 18, 19, 21, 23, 27, 29 };

            var even = validPrimePick.Where(e => e % 2 == 0);

            LoopingwithGenerics(even);
        }

        static void Quantifiers()
        {
            Book book = new Book { Auther = "Herman", Name = "Moby Dick" };

            var bookValidationRules = new List<Func<Book, bool>>
            {
                e1 => !string.IsNullOrEmpty(e1.Name),
                e1 => !string.IsNullOrEmpty(e1.Name)
            };

            var isBookValid = bookValidationRules.All(r => r(book));
          
        }

        static void SetDistinct()
        {
            List<Book> book = new List<Book>()
            {
                new Book {Auther = "OneAuther" ,Name = "OneName" },
                new Book {Auther = "TwoAuther" ,Name = "ThreeName" },
                new Book {Auther = "OneAuther" ,Name = "OneName" }
            };

            var query = book
                .Select(b => new
                {
                    b.Auther,
                    b.Name
                })
                .Distinct();

            LoopingwithGenerics(query.Select(c => c.Name));

        }

        static void SetOperations()
        {
            int[] twos = { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] threes = { 3, 6, 9, 12, 15, 18, 21 };

            //Intersection
            var intersection = twos.Intersect(threes);

            LoopingwithGenerics(intersection);

            //Exception

            var exception = twos.Except(threes);

            LoopingwithGenerics(exception);

            //Union

            var union = twos.Union(threes);

            LoopingwithGenerics(union);

        }

        static void ProcessSorting()
        {
            var query = Process.GetProcesses()
                .OrderBy(p => p.WorkingSet64)
                .ThenByDescending(c => c.Threads.Count);

            LoopingwithGenerics(query);
        }

        static void OfTypeExample()
        {
            IList list = new ArrayList();

            list.Add("Dash");
            list.Add(new object());
            list.Add("Kentaki");
            list.Add(new object());

            IEnumerable query = from aList in list.OfType<string>()
                                select aList;

            LoopingwithoutGenerics(query);

        }

        static void LoopingwithoutGenerics(IEnumerable obj)
        {
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }

        static void LoopingwithGenerics<T>(IEnumerable<T> obj)
        {
            foreach (T item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}

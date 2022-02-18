using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Week1
{
    public class SearchStringInAString
    {
        public static void SearchString()
        {
            var listOfPersons = new List<Person> {
                new Person { GivenName = "Johny", LastName = "Roberts" },
                new Person { GivenName = "Mary", LastName = "Smith" },
                new Person { GivenName = "Mary", LastName = "Rohn" },
                new Person { GivenName = "Abc", LastName = "Xyq" } ,
            };

            List<string> searchTerms = new List<string> { "ohn", "xyq" };

            var result = new List<Person>();



            // I neach of the column it finds a given string and return the person
            // It take first three letter of the search term and picks up the person who given name pr last name has those three letters
            // searchTerms.Contains will match exact three letters. SearchTerms here is a List/Array not a string so Contains will do extract match
            // but Esists will do match per passed predicate and here I passed first three letter as predicate to Exists

            result.AddRange(listOfPersons.Where(p => searchTerms.Exists(t => p.GivenName.ToLower().Contains(t.Substring(0, 3).ToLower()))
                || searchTerms.Exists(t => p.LastName.ToLower().Contains(t.Substring(0, 3).ToLower()))));


            //foreach (var term in searchTerms)
            //{
            //    result.AddRange(listOfPersons.Where(_ => _.GivenName.ToLower().Contains(term.ToLower())
            //                    || _.LastName.ToLower().Contains(term.ToLower())).ToList());
            //}
        }
    }

    public class Person
    {
        public string GivenName { get; set; }
        public string LastName { get; set; }
    }
}

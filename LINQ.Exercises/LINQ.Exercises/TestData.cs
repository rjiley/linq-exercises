﻿using System;
using System.Collections.Generic;

namespace LINQ.Exercises
{
    /// <summary>
    /// Data used for tests.
    /// Don't change it, order and content of each test data set is important.
    /// </summary>
    internal static class TestData
    {

        /// <summary>
        /// The following Data was using for the: Element, Aggregate and Restriction exercises.
        /// Don't change it, order and content of each test data set is important.
        /// </summary>
        /// 
        internal static IEnumerable<int> Numbers
        {
            get
            {
                return new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };
            }
        }

        internal static ICollection<string> Animals
        {
            get
            {
                return new[] { "tiger", "lion", "swordfish", "penguin", "elephant", "shark" };
            }
        }

        internal static IList<Person> People
        {
            get
            {
                return new[]
                {
                    new Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
                    new Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                    new Person("Jill", "Lill", new DateTime(2001, 5, 21)),
                    new Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                };
            }
        }

        internal class Person
        {
            public string FirstName { get; private set; }

            public string LastName { get; private set; }

            public DateTime Born { get; private set; }

            public Person(string firstname, string lastname, DateTime born)
            {
                this.FirstName = firstname ?? string.Empty;
                this.LastName = lastname ?? string.Empty;
                this.Born = born;
            }

            public override string ToString()
            {
                return string.Format("{{ {0} {1}; {2:yyyy-MM-dd} }}", FirstName, LastName, Born);
            }

            public override bool Equals(Object obj)
            {
                Person person = obj as Person;
                if (person == null)
                {
                    return false;
                }
                
                return FirstName.Equals(person.FirstName) && LastName.Equals(person.LastName) && Born.Equals(person.Born);
            }
        }

        /// <summary>
        /// The following Data was using for the partioning Tests        
        /// </summary>
        /// 

        internal static IEnumerable<int> PartioningNumbers
        {
            get
            {
                return new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
            }
        }

      


    }
}

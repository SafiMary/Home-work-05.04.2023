using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_05._04._2023
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() {
           
        }
        public static int ComparePerson(Person x, Person y)
        {
            return y.Age.CompareTo(x.Age);
        }


    }
}

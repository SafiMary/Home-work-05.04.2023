using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Home_work_05._04._2023

{
    internal class Program
    {
        static List<Person> Ask(int n) { 
        var ans = new List<Person>();
        for (int i = 0; i<n; i++)
			{
                ans.Add(CreatePerson());
               
			}
            return ans;
        }
        static Person CreatePerson()
        {
            string name;
            int age = 0;
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            do { 
                try
                {
                    Console.WriteLine("Введите возраст");
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Возраст введен не корректно!");
                }
            }while((age <= 0) && (age > 120));
            var person = new Person();
            person.Age = age;   
            person.Name = name; 
            return person;

            }
   

        static void Main(string[] args)
    {
        
            var PersonList = Ask(3);
            PersonList.Sort(Person.ComparePerson);
            foreach (Person person in PersonList)
            {
                Console.WriteLine($"Имя {person.Name} возраст {person.Age}");
            }



        }

    }
    }


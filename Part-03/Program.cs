using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            //TODO: not so urgent

            //FIXME: more urgent


            //int n1 =0, n2= 1, n3 = 2;            
            int n1 = 0;
            int n2 = 1;
            int n3 = 2;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; }
        public int Age { get; set; }

        public Person(int id, string name, DateTime birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = DateTime.Parse(birthDate.ToShortDateString());
            Age = DateTime.Now.Year - birthDate.Year;
        }
    }
}
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            
        }

        public void GetWeekDay(Weekdays weekdays)
        {
            int weekday = (int)weekdays;
        }
    }

    #region Person
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
    #endregion Person

    #region Employee
    public class Employee : Person
    {
        public string Role { get; set; }

        public Employee(string firstName, string lastName, string role) : base(firstName, lastName)
        {
            Role = role;
        }

        public new string GetFullName()
        {
            return string.Format("Mr. / Mr(s). {0} {1}", FirstName, LastName);
        }
    }
    #endregion Employee

    public enum Weekdays
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }
}
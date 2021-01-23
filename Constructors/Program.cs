using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1,FirstName="elif",LastName="ertürk",City="istanbul"};//sondaki parantez aslında ctoru temsil eder.


            Customer customer2 = new Customer (2,"elif","ertürk","istanbul" );

            Console.WriteLine(customer2.FirstName);
        }

       
    }

    class Customer
    {

        //default ctor araka planda aslında bu hep çalışır.

        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalışır.");
        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

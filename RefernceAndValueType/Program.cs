using System;

namespace RefernceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolen value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;//sayi1 in değeri = sayi2 nin değerine
            sayi2 = 100;
            Console.WriteLine(sayi1); //cevap 20 olur çünkü orada değer ataması yyapılıyor. sayi1 e sayi 2nin değeri atanıyor yani 20 


            //arrays,class,interface... reference types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;//sayilar 1in adresi eşittir sayilar 2 nin adresi
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);//bu sefer cevap 1000 olur çünkü referans tiplerde bir adres mantığı vardır. sayilar1 in yeni adresi artık sayilar2 oldugundan sayilar2 de yaptığımız değişiklik sayilar 1 içinde geçerli olur artık sayilar1 sayilar2

            //new dediğimizde heap de veri oluşur ve adres degeri atanır.


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);
            


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCartNumber = "2343455";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer; //base classlara referans ataması yapılır.
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCartNumber);//Burada boxing yapmış olduk person3 e customerdaki bir özelliği kullandırmış olduk.


            //istediğimiz zaman müşteri veya çalışan ile çalışmak istediğimizde boxing kullanabiliriz.
            PersonManager personManager = new PersonManager();
            personManager.Add(employee); //kızmıyor.


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string CreditCartNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) //bu sayede hem person hem employe hemde customer gönderebilirim
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

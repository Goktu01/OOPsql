using ConsoleApp54.Abstract;
using ConsoleApp54.Concrete;
using ConsoleApp54.Entities;
using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BaseCustomerManager customerManager = new NeroManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 6, 4), FirstName = "Engin", LastName = "Demirog", ID = 12 });

        }
    }
}

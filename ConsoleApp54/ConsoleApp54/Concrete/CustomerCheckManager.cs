using ConsoleApp54.Abstract;
using ConsoleApp54.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp54.Concrete
{
    public class CustomerCheckManager : IPersonCheckService
    {
     public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}

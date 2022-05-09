using ConsoleApp54.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp54.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}

using ConsoleApp54.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp54.Entities
{
    public class Customer:IEntity
    {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
        }
    }


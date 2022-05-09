using ConsoleApp54.Abstract;
using ConsoleApp54.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp54.Concrete
{
    public class StarBucksManager : BaseCustomerManager
    {
        private Abstract.IPersonCheckService _personCheckService;
           public StarBucksManager(Abstract.IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {

            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else 
            { 
            throw new Exception("invalid");
            }
        }

     
    }
}
 
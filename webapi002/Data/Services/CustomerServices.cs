using System;
using System.Collections.Generic;
using System.Linq;
using webapi002.Data.Model;
using webapi002.Data.ViewModels;

namespace webapi002.Data.Services
{
    public class CustomerServices
    {
        // to add customer to the database       
        
            private AppDbContext _context; 

            public CustomerServices(AppDbContext context)
        {
            _context = context;
        }


        public void AddCustomer(CustomerVm customer)
        {
            var _customer = new CustomerInfo()
            {
                name = customer.name,
                lname = customer.lname,
                address = customer.address,
                city = customer.city,
                birthday = DateTime.Now
            };
            _context.CustomerInfos.Add(_customer);
            _context.SaveChanges();      
        }

        public List<CustomerInfo> GetAllCustomers()
        {
            var theData = _context.CustomerInfos.ToList();
            return theData;          

        }
        public CustomerInfo GetCustomerInfo(int customerid) =>  _context.CustomerInfos.FirstOrDefault(n => n.id == customerid);
    }
}

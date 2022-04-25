using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi002.Data.Model;


// This calss manages the database connection

namespace webapi002.Data
{
    public class AppDbContext : DbContext
    {     
        //overloaded constructor  , ctor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }       

        // the tables names

        public DbSet<CustomerInfo> CustomerInfos { get; set;  }  // the sql table name here 

    }
}

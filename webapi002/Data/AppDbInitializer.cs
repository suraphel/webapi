using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using webapi002.Data.Model;

namespace webapi002.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder )
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            { 
               var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.CustomerInfos.Any())
                {
                    context.CustomerInfos.AddRange(
                        new CustomerInfo()
                    {
                        
                        name = "Suraphel",
                        address = "Sars gate 36",
                        city = "Oslo",
                        birthday = DateTime.Now.AddYears(-40),
                    },
                    (new CustomerInfo()
                    {
                      
                        name = "MSuraphel",
                        address = "Bole",
                        city = "AA",
                        birthday = DateTime.Now.AddYears(-20),

                    }));

                    context.SaveChanges();
                }
            
            }
        }

    }
}

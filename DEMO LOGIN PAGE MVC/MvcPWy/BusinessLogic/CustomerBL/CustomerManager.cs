using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPWy.Models;

namespace MvcPWy.BusinessLogic.CustomerBL
{
    public class CustomerManager
    {
               public static List<Customer> GetAllUniqueHobbies()
               {
                   var customersContext = new ApplicationDbContext();
                   var uniquehobbies = customersContext.Customers.GroupBy(cust => cust.MainHobby).Select(grp => grp.FirstOrDefault()).ToList();
                   return uniquehobbies;
               }

               public static List<Customer> GetAllUniquePreferredColors()
               {
                   var customersContext = new ApplicationDbContext();
                   var uniquepreferredcolors = customersContext.Customers.GroupBy(cust => cust.PrefferedColor).Select(grp => grp.FirstOrDefault()).ToList();
                   return uniquepreferredcolors;
               }

    }
}
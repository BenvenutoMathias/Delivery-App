using System;
using Microsoft.AspNetCore.Identity;

namespace DeliveryApp.Models 
{

        public class ApplicationUser : IdentityUser
        {
            
            public string FirstName { get; set; }
            public string LastName { get; set; }
            /* Phone Number */
            public int Number { get; set; }
        
        }

}
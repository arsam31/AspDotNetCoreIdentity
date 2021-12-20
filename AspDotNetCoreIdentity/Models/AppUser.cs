using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreIdentity
{
    public class AppUser : IdentityUser
    {
        public string City { get; set; }
        public string Country { get; set; }
        public int? MyProperty { get; set; }
    }
}

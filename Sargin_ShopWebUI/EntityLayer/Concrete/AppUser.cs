using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
    }
}

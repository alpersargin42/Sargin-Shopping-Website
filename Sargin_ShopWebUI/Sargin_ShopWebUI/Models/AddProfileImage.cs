using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Sargin_ShopWebUI.Models
{
    public class AddProfileImage
    {
        public int AdvertiserID { get; set; }
        public string AdvertiserName { get; set; }
        public string AdvertiserAbout { get; set; }
        public string AdvertiserMail { get; set; }
        public string AdvertiserPassword { get; set; } 
        public string AdvertiserPassword1 { get; set; }
        public IFormFile AdvertiserImage { get; set; }
        public bool AdvertiserStatus { get; set; }
    }
}

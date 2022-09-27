using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sargin_ShopWebUI.Models
{
    public class UserSıgnInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
        public string password { get; set; }
    }
}

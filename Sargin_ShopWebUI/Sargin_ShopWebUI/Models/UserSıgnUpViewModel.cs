using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sargin_ShopWebUI.Models
{
    public class UserSıgnUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Lütfen Ad Soyad Giriniz.")]
        public string nameSurname { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifre Giriniz.")]
        public string password { get; set; }
        [Display(Name = "Şifre Tekrar")]
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz.")]
        [Compare("password",ErrorMessage = "Şifreler uyuşmuyor!")]
        public string confirmPassword { get; set; }
        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen Mail Giriniz.")]
        public string Mail { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz.")]
        public string UserName { get; set; }



    }
}

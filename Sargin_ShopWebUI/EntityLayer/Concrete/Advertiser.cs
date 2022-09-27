using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Advertiser
    {
        [Key]
        public int AdvertiserID { get; set; }
        public string AdvertiserName { get; set; }
        public string AdvertiserAbout { get; set; }
        public string AdvertiserMail { get; set; }
        public string AdvertiserPassword { get; set; }
        public string AdvertiserPassword1 { get; set; }
        public bool AdvertiserStatus { get; set; }
        public string AdvertiserImage { get; set; }
        public List<Pruduct> Pruducts { get; set; }
        public virtual ICollection<Message2> AdvertiserSender { get; set; }
        public virtual ICollection<Message2> AdvertiserReceiver { get; set; }
    }
}

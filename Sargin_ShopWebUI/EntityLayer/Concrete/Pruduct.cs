using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Pruduct
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public string ProductContent { get; set; }
        public string ProductThumbnailImage { get; set; }
        public string ProductImage { get; set; }
        public string ProductPrice { get; set; }
        public bool ProductStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int AdvertiserID { get; set; }
        public bool ProductOffer { get; set; }
        public string Marka { get; set; }
        public Advertiser Advertiser { get; set; }
        public List<Comment> Comments { get; set; }
    }
}

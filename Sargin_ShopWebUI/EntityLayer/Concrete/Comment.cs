using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int ProductScore { get; set; }
        public bool CommentStatus { get; set; }
        public int ProductID { get; set; }
        //public Pruduct Pruduct { get; set; }

    }
}

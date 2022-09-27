using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace BussinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CategoryDelete(Category category);
        //void CategoryUpdate(Category category);
        List<Comment> GetList(int id);
        //Category GetById(int id);
    }
}

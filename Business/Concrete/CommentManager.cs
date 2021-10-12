using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Delete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public List<Comment> GetAll(int id)
        {
            return _commentDal.GetAll(x => x.BlogId == id);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public void Insert(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}

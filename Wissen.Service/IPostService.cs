using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wissen.Model;

namespace Wissen.Service
{
   public interface IPostService
    {
        void Insert(Post entity);
        void Update(Post entity);
        void Delete(int id);
        void Delete(Post entity);
        Post Fİnd(int id);
        Post Find(Expression<Func<Post, bool>> where);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAll(Expression<Func<Post, bool>> where);
       
    }
}

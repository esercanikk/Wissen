using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wissen.Data;
using Wissen.Model;

namespace Wissen.Service
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> postRepository;
        public PostService(IRepository<Post> postRepository)
        {
            this.postRepository = postRepository;
        }
        public void Delete(int id)
        {
            var entity = postRepository.Find(id);
            if (entity != null)
            {
                postRepository.Delete(entity);
                postRepository.SaveChanges();
            }
        }

        public void Delete(Post entity)
        {
            postRepository.Delete(entity);
        }

        public Post Find(Expression<Func<Post, bool>> where)
        {
            return postRepository.Find(where);
        }

        public Post Fİnd(int id)
        {
            return postRepository.Find(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return postRepository.GetAll(r => true);
        }

        public IEnumerable<Post> GetAll(Expression<Func<Post, bool>> where)
        {
            return postRepository.GetAll(where);
        }

        public void Insert(Post post)
        {
            postRepository.Insert(post);
            postRepository.SaveChanges();
        }
        public void Update(Post post)
        {
            postRepository.Update(post);
            postRepository.SaveChanges();
        }
    }
}

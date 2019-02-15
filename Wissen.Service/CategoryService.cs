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
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> repository;
        public CategoryService(IRepository<Category> repository)
        {
            this.repository = repository;
        }
        public void Delete(int id)
        {
            var categoryToDelete = repository.Find(id);
            if (categoryToDelete != null)
            {
                repository.Delete(categoryToDelete);
            }
        }

        public Category Find(Expression<Func<Category, bool>> where)
        {
            return repository.Find(where);
        }

        public Category Fİnd(int id)
        {
            return repository.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<Category> GetAll(Expression<Func<Category, bool>> where)
        {
            return repository.GetAll(where);
        }

        public void Insert(Category category)
        {
            repository.Update(category);
        }

        public void Update(Category category)
        {
            repository.Update(category);
        }
    }
}

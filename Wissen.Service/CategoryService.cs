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
        private readonly IRepository<Category> categoryRepository;
        public CategoryService(IRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Delete(int id)
        {
            var entity = categoryRepository.Find(id);
            if (entity != null)
            {
                categoryRepository.Delete(entity);
                categoryRepository.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            categoryRepository.Delete(entity);
            categoryRepository.SaveChanges();
        }

        public Category Find(Expression<Func<Category, bool>> where)
        {
            return categoryRepository.Find(where);
        }

        public Category Fİnd(int id)
        {
            return categoryRepository.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public IEnumerable<Category> GetAll(Expression<Func<Category, bool>> where)
        {
            return categoryRepository.GetAll(where);
        }

        public void Insert(Category category)
        {
            categoryRepository.Insert(category);
            categoryRepository.SaveChanges();
        }

        public void Update(Category category)
        {
            categoryRepository.Update(category);
            categoryRepository.SaveChanges();
        }
    }
}

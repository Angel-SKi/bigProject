using BLL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICategoryService
    {
        public Category GetCategoryById(int id);
        public List<Category> GetAllCategories();
        public void DeleteCategory(int id);
        public void InsertCategory(Category entity);
        public void UpdateCategory(Category entity);
    }
}

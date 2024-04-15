using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public void DeleteCategory(int id)
        {
            _categoryRepository.Delete(id);
        }

        public List<Category> GetAllCategories()
        {
            var query = _categoryRepository.GetAll();
            var categories = query.ToList();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            var query = _categoryRepository.GetAll();
            var categoryEntity = query.FirstOrDefault(category => category.Id == id);

            if (categoryEntity == null)
            {
                throw new InvalidOperationException("No Category found.");
            }
            return categoryEntity;
        }

        public void InsertCategory(Category entity)
        {
            if (entity == null) throw new ArgumentNullException("Category cannot be null.");
            _categoryRepository.Create(entity);
        }

        public void UpdateCategory(Category entity)
        {
            _categoryRepository.Update(entity);
         
        }
    }
}

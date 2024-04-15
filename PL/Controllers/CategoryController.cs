using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpPost("InsertCategory")]
        public Category InsertCategory([FromBody] Category category)
        {
            _categoryService.InsertCategory(category);

            return category;
        }

        [HttpPut]
        [Route("UpdateCategory")]
        public Category UpdateCategory([FromBody] Category category)
        {
            _categoryService.UpdateCategory(category);
            return category;
        }

        [HttpDelete]
        [Route("DeleteCategory")]
        public void DeleteCategory(int categoryId)
        {
            _categoryService.DeleteCategory(categoryId);
        }

        [HttpGet("GetCategoryById")]
        public Category GetCategoryById(int idCategory)
        {
            var category = _categoryService.GetCategoryById(idCategory);
            return category;
        }

        [HttpGet("GetAllCategories")]
        public List<Category> GetAllCategories()
        {
            return _categoryService.GetAllCategories();
        }
    }
}

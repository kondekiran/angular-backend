using ShoppingApplication.Interfaces;
using ShoppingApplication.Models;
using ShoppingApplication.RepositoryLayer;

namespace ShoppingApplication.ServiceLayer
{
    public class CategoryServices : ICategory
    {
        private ApplicationDbContext _Dbcontext;
        public CategoryServices(ApplicationDbContext dbcontext)
        {
            _Dbcontext = dbcontext;
        }
        public List<category> GetCategories()
        {
            return _Dbcontext.category.ToList();
        }
    }
}

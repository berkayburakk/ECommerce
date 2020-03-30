using ECommerce.Models;

namespace ECommerce.DataAccess.Repository.IRepository
{
    public interface ISubCategoryRepository:IRepository<SubCategory>
    {
        void Update(SubCategory category);

    }
}

using ECommerce.Models;

namespace ECommerce.DataAccess.Repository.IRepository
{
    public interface ISubCategoryRepository:IRepository<CoverType>
    {
        void Update(CoverType category);

    }
}

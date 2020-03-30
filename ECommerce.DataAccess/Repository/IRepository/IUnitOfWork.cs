using System;

namespace ECommerce.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
        IProductRepository Product{ get; }
        
        ISubCategoryRepository SubCategory { get; }
       
        void Save();
    }
}

using System;

namespace ECommerce.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
       
        void Save();
    }
}

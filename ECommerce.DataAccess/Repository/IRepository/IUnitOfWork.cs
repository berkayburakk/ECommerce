using ECommerce.DataAccess.Repository.IRepository;
using System;

namespace ECommerce.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
        IProductRepository Product{ get; }
        
        ICoverTypeRepository CoverType { get; }
        ICompanyRepository Company { get; }
        IApplicationUserRepository ApplicationUser { get; }
       
        void Save();
    }
}

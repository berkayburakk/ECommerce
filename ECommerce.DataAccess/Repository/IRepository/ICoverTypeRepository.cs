using System;
using System.Collections.Generic;
using System.Text;
using ECommerce.DataAccess.Repository.IRepository;
using ECommerce.Models;

namespace ECommerce.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);

    }
}

using System.Linq;
using ECommerce.DataAccess.Data;
using ECommerce.DataAccess.Repository.IRepository;
using ECommerce.Models;

namespace ECommerce.DataAccess.Repository
{
    public class SubCategoryRepository :Repository<SubCategory>,ISubCategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public SubCategoryRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(SubCategory subCategory)
        {
            var objFromDb = _db.SubCategories.FirstOrDefault(s => s.Id == subCategory.Id);

            if (objFromDb != null)
            {
                objFromDb.Name = subCategory.Name;


            }


        }
    }
}

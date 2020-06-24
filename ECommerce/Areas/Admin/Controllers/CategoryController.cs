using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.DataAccess.Data;
using ECommerce.DataAccess.Repository.IRepository;
using ECommerce.Models;
using ECommerce.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                //id null ise demekki anlayacağız ki kategori sıfırdan eklenecek

                return View(category);
            }
            // id null olmadığı zaman demekki bizim bir kategorimiz var ve o id ile onu güncelleyeceğiz

            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }


        /*
         * “ValidateAntiForgeryToken” kısaca .NET platformunun dış saldırılara karşı aldığı,
         * bilgi isteyen kişi gerçekten sen misin diye kontrol eden önlemidir.

         *Dizayn ettiğimiz siteye kullanıcılardan gelen isteklere (request),
         *isteklerin doğruluğunu “Token”ler aracılığıyla anlayıp ona göre cevap verir.
         *Sayfa Post edildiğinde Asp.Net Token post gövdesi içerisinde uzun ve karmaşık yapıda “Token” gönderir.
         
         *Bunu alan server tarafındaki controller’ımız kendisinde de bulunan token 
         *ile post ile gelen token’i karşılaştırır. Eğer tokenler eşleşiyorsa demektir
         *ki request dışarıdan değil de; bizim uygulamamızdan geliyor 🙂 işleme devam edilir.
         *Eğer eşleşme gerçekleşmiyorsa request gönderen karşı tarafa cevap (response) verilmez.
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    _unitOfWork.Category.Add(category); 
                    
                }
                else
                {
                    _unitOfWork.Category.Update(category); 
                }
                _unitOfWork.Save();

                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();

            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {

            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Silerken bir hata oluştu" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Silme işlemi başarılı" });

        }

        #endregion
    }
}
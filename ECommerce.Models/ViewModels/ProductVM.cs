using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ECommerce.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product{ get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> SubCategoryList { get; set; }
    }
}

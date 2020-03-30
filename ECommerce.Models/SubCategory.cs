using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Alt Kategori Adı")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
      
       

    }
}

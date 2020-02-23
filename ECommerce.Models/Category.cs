using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

    }
}

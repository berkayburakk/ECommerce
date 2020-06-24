using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        [DisplayName("Kapak Tipi")]
        public string Name { get; set; }
      
       

    }
}

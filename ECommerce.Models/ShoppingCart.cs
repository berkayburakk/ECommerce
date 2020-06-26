using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Count = 1;
        }
        [Key]
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Display(Name ="Adet")]
        [Range(1,1000,ErrorMessage ="1 ile 1000 arasında bir değer giriniz.")]
        public int Count { get; set; }

        [Display(Name = "Fiyat")]
        [NotMapped]
        public double Price { get; set; }

    }
}

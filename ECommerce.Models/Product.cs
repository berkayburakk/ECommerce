using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Başlık")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [Required]
        [DisplayName("ISBN Numarası")]
        public string ISBN { get; set; }
        [Required]
        [DisplayName("Yazar")]
        public string Author { get; set; }
        [Required]
        [Range(1, 10000)]
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public int CoverTypeId { get; set; }

        [ForeignKey("CoverTypeId")]
        [DisplayName("Kapak Tipi")]
        public CoverType CoverType { get; set; }

    }
}
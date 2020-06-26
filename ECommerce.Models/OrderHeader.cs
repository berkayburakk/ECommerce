using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name="Sipariş Tarihi")]
        [Required]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Kargo Tarihi")]
        [Required]
        public DateTime ShippingDate { get; set; }
        [Display(Name = "Toplam Tutar")]
        [Required]
        public Double OrderTotal { get; set; }
        [Display(Name = "Kargo Numarası")]
        public string TrackingNumber { get; set; }
        [Display(Name = "Kargo")]
        public string Carrier { get; set; }
        [Display(Name = "Sipariş Durumu")]
        public string OrderStatus { get; set; }
        [Display(Name = "Ödeme Durumu")]
        public string PaymentStatus { get; set; }
        [Display(Name = "Ödeme Tarihi")]
        public DateTime PaymentDate { get; set; }
        [Display(Name = "Son Ödeme Tarihi")]
        public DateTime PaymentDueDate { get; set; }
        public string TransactionId { get; set; }

        [Display(Name = "Telefon Numarası")]
        [Required]
        public string PhoneNumber { get; set; }
        [Display(Name = "Cadde")]
        [Required]
        public string StreetAddress { get; set; }
        [Display(Name = "Şehir")]
        [Required]
        public string City { get; set; }
        [Display(Name = "İlçe")]
        [Required]
        public string State { get; set; }
        [Display(Name = "Posta Kodu")]
        [Required]
        public string PostalCode { get; set; }
        [Display(Name = "Ad")]
        [Required]
        public string Name { get; set; }


    }
}

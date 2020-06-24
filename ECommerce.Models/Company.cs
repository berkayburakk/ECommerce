using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Adı")]
        public string Name { get; set; }
        [DisplayName("Cadde Adı")]
        public string StreetAddress { get; set; }
        [DisplayName("İl")]
        public string City { get; set; }
        [DisplayName("İlçe")]
        public string State { get; set; }
        [DisplayName("Posta Kodu")]
        public string PostalCode { get; set; }
        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [DisplayName("Yetkili Şirketmi")]
        public bool IsAuthorizedCompany { get; set; }
    }
}

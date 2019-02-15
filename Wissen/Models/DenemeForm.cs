using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wissen.Models
{
    public class DenemeForm
    { // hata msj türkçeye göndermek için
        [Required(ErrorMessage ="{0} alanı gereklidir")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakter uzunluğunda olabilir")]
        [Display(Name ="Ad")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        [Display(Name = "Mail")]
        public string Email { get; set; }
        [Required]
        [Phone]
        [MaxLength(20)]
        [Display(Name = "Telefon No")]

        public string Phone { get; set; }

    }
}
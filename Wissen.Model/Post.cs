using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wissen.Model
{
   public class Post:BaseEntity
    {
        [Display(Name = "Başlık")]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Açıklama")]
       [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name ="Kategori İd")]
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}

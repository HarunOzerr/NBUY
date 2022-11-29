using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(3, ErrorMessage = "{0} alanının uzunluğu {1} karakterinden kısa olmamalıdır.")]
        public string Name { get; set; }


        [DisplayName("Açıklama")]
        [MaxLength(50, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(10, ErrorMessage = "{0} alanının uzunluğu {1} karakterinden kısa olmamalıdır.")]
        public string Description { get; set; }
        public Article Article { get; set; }


        [DisplayName("Özel Not")]
        [MaxLength(500, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(10, ErrorMessage = "{0} alanının uzunluğu {1} karakterinden kısa olmamalıdır.")]
        public string Note { get; set; }

        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool IsActive { get; set; }

    }
}

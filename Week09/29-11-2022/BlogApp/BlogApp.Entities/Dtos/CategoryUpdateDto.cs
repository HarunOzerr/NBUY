using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Article Article { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities.Abstract
{
    public abstract class EntityBase
        //Abstract class ancak miras verebilir yeni nesne yaratılamaz.
    {
        public int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
        public bool IsDeleted { get; set; } = false; //default değeri zaten false. Görünür olsun diye belirttik.
        public bool IsActive { get; set; } = true;
    }
}

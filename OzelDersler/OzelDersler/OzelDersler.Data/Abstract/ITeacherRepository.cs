﻿using OzelDersler.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Abstract
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        List<Teacher> GetTeachersByBranch();
        Task<List<Teacher>> GetHomePageTeachersAsync();
    }
}

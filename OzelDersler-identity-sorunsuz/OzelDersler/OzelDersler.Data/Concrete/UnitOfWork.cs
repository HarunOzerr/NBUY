﻿using OzelDersler.Data.Abstract;
using OzelDersler.Data.Concrete.EfCore.Contexts;
using OzelDersler.Data.Concrete.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OzelDerslerContext _context;

        public UnitOfWork(OzelDerslerContext context)
        {
            _context = context;
        }

        private EfCoreStudentRepository _studentRepository;
        private EfCoreTeacherRepository _teacherRepository;
        public ITeacherRepository Teachers => _teacherRepository = _teacherRepository ?? new EfCoreTeacherRepository(_context);

        public IStudentRepository Students => _studentRepository = _studentRepository ?? new EfCoreStudentRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

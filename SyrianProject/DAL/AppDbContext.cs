﻿using Microsoft.EntityFrameworkCore;
using SyrianProject.Models;

namespace SyrianProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<DoctorComponent> DoctorComponents { get; set; }
        public DbSet<DepartmentComponent> DepartmentComponents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryComponent> CategoryComponents { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using School.TopTeacher.Models;
using School.TopTeacher.Persistance.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Persistance
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSubject> CourseSubject { get; set; }
        public DbSet<TeacherSubject> TeacherSubject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;" +
                "Database=School;" +
                "Trusted_Connection=True;" +
                "User Id=sa;" +
                "Password=7410");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(CourseSubjectConfig).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

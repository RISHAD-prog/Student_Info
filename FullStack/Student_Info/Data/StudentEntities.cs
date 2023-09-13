using Microsoft.EntityFrameworkCore;
using Student_Info.Models;

namespace Student_Info.Data
{
    public class StudentEntities : DbContext
    {
        public StudentEntities(DbContextOptions<StudentEntities> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ClassInfo> ClassInfos { get; set; }
    }
}

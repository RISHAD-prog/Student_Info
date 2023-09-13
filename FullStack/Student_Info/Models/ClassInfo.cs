using System.ComponentModel.DataAnnotations;

namespace Student_Info.Models
{
    public class ClassInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModificationDate { get; set; }
        public virtual List<Student> Students { get; set; }
        public ClassInfo()
        {
            Students = new List<Student>();
        }
    }
}

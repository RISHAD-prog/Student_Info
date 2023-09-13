using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Info.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Gender { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [ForeignKey("ClassInfo")]
        public int ClassId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModificationDate { get; set; }
        public virtual ClassInfo ClassInfo { get; set; }
    }
}

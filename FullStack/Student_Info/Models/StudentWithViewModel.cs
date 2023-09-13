namespace Student_Info.Models
{
    public class StudentWithViewModel
    {
        
            public Student? Info { get; set; }
            public List<ClassInfo>? ClassDetails { get; set; }

            public ClassInfo? SingleClassInfo { get; set; }
    }
}

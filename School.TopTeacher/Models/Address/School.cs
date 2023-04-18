namespace School.TopTeacher.Models.Address
{
    public class School : BaseEntity
    {
        public string Name { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
    }
}

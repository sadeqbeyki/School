namespace School.TopTeacher.Models
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Grade> Grades { get; set; }
        public ICollection<TeacherSubject> Teachers { get; set; }
        public ICollection<CourseSubject> CourseSubjects { get; set; }
    }
}
namespace School.TopTeacher.Models
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }=string.Empty;

        public List<Grade> Grades { get; set; }=new List<Grade>();
        public List<TeacherSubject> TeacherSubjects { get; set; }=new List<TeacherSubject>();
        public List<CourseSubject> CourseSubjects { get; set; }=new List<CourseSubject> { };
    }
}
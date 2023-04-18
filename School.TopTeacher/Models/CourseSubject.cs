namespace School.TopTeacher.Models
{
    public class CourseSubject
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}

namespace School.TopTeacher.Models
{
    public class Grade : BaseEntity
    {
        public float Value { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
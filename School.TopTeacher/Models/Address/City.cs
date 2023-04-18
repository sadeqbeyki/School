using School.TopTeacher.Models;

namespace School.TopTeacher.Models.Address
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<School> Schools { get; set; } = new List<School>();
    }
}
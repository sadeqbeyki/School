using School.TopTeacher.Models;

namespace School.TopTeacher.Models.Address
{
    public class County : BaseEntity
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}
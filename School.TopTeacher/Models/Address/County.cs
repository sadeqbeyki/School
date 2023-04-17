namespace School.Create.Models.Address
{
    public class County : BaseEntity
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}
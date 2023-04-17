namespace School.Create.Models.Address
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<School> Schools { get; set; } = new List<School>();
    }
}
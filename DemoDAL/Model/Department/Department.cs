using DemoDAL.Model.Shared;


namespace DemoDAL.Model.Department
{
    public class Department : BaseEntity
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}

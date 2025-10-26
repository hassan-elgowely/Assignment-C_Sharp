namespace DemoPL.ViewModels.DepartmentVM
{
    public class DepartmentUpdateVM
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateOnly DateCreatedOn { get; set; }
    }
}

namespace DemoPL.ViewModels.DepartmentViewModel
{
    public class UpdateDepartmentViewModel
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateOnly DateCreated { get; set; }
    }
}

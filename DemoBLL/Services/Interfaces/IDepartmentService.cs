using DemoBLL.DTOS.DepartmentModule;

namespace DemoBLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        int AddDepartment(AddDepartmentDTO addDepartmentDTO);
        bool DeleteDepartment(int id);
        IEnumerable<GetAllllDepartmentDTO> GetAllllDepartment();
        GetDepartmentByIdDTO? GetDepartmentDetailsById(int id);
        int UpdateDepartment(UpdateDepartmentDTO updateDepartmentDTO);
    }
}
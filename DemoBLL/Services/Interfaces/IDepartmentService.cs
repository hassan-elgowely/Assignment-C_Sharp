using DemoBLL.DTOS.DepartmentModule;

namespace DemoBLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        IEnumerable<GetAllDepartmentDTO> GetAllDepartment();
        GetDepartmentDetailsDTO? GetDepartmentDetails(int id);
        int AddDepartment(AddDepartmentDTO addDepartmentDTO);
        int UpdateDepartment(UpdateDepartmentDTO updateDepartmentDTO);
        bool DeleteDepartment(int id);
    }
}
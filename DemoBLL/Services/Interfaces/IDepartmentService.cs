using DemoBLL.DTOS.DepartmentModule;

namespace DemoBLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        int AddDepartment(DepartmentAddDTO departmentaddDto);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentGetAllDTO> GetAllDepartment();
        DepartmentDetailsDTO? GetDepartmentById(int id);
        int UpdateDepartment(DepartmentUpdateDTO departmentUpdateDTO);
    }
}
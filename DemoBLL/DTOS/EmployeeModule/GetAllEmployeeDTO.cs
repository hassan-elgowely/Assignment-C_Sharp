using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.DTOS.EmployeeModule
{
    public class GetAllEmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        [DataType(DataType.Currency)] // for display
        public decimal Salary { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        [EmailAddress]                // for display appliction validation
        public string? Email { get; set; }
        [Display(Name="Emp Gender")]
        public string EmpGender { get; set; }
        [Display(Name = "Employee Type")]
        public string EmployeeType { get; set; }
    }
}

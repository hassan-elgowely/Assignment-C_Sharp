using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Models
{
    public class EntityBase
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; } // nullable ==> has default value
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; } // nullable ==> has default value
        public bool IsDeleted { get; set; } // soft delete ==> just flag to hide data from DB when = ture , default = false
    }
}

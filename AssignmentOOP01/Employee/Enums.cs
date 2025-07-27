using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01.Employee
{
    [Flags]
    internal enum Gender : byte
    {
        M = 1,
        Male = 1,
        F = 2,
        Female = 2
    }

    [Flags]
    internal enum SecurityPrivileges : byte
    {
        guest = 1, Developer = 2, secretary = 4 , DBA = 8 , SecurityOfficer = 16 
    }
}

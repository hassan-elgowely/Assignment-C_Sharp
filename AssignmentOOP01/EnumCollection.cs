using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    [Flags]
    enum WeekDays : byte
    {
        Monday = 1, Tuesday = 2, Wednesday = 4, Thursday = 8, Friday = 16, Saturday = 32, Sunday = 64
    }

    enum Season :byte
    {
        Spring = 1 , Summer , Autumn , Winter 
    }

    [Flags]
    enum Permissions : byte
    {
        Read =1,
        Write =2,
        Delete =4,
        Execute =8
    }
    [Flags]
    enum Colors : byte
    {
        Red = 1,Green = 2,Blue =4
    }
}

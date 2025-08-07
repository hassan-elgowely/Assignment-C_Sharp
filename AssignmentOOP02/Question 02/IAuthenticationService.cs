using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP02.Question_02
{
    interface IAuthenticationService
    {
        string? UserName { get; set; }
        string? Password { get; set; }
        string? Role { get; set; }

        public bool AuthenticateUser();
        public bool AuthorizeUser();



    }
}

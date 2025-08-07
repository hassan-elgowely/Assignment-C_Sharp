using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP02.Question_02
{
    internal class AuthenticationService : IAuthenticationService
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get ; set ; }



        public bool AuthenticateUser()
        {
            string? UserName = "Ahmed";
            string? Password = "102030";

            if (UserName == this.UserName &&  Password == this.Password) 
                return true;
            else
                return false;
        }

        public bool AuthorizeUser()
        {
            string? UserName = "Ahmed";
            string Role = "Admin";
            if (Role == this.Role && UserName == this.UserName) 
                return true;
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FodyPermissionsSpike.Services
{
    public class UserResolver
    {
        // this should return a fully loaded user object with roles et al.
        // we could wire this up to return the IUserPrincipal
        public string GetUser() => "User1";
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People_MVC.Models.ViewModel
{
    public class RoleViewModel
    {
        public CreateRoleViewModel CreateRoleViewModel { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public List<User> AllUsers { get; set; } = new List<User>();
    }
}

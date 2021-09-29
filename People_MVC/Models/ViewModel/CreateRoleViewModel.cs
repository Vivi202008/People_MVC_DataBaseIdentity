using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace People_MVC.Models.ViewModel
{
    public class CreateRoleViewModel
    {
        public string RoleId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<User> RolesUsers { get; set; } = new List<User>();
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace People_MVC.Models
{
    public class Role:IdentityRole
    {
        [Key]
      public int RoleId { get; set; }
      public string RoleName {get; set;  }

        public List<User> Users { get; set; }

    }
}

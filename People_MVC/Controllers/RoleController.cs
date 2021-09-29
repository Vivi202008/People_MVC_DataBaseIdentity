using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using People_MVC.Models;
using People_MVC.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People_MVC.Controllers
{
       [Authorize(Roles = "SuperAdmin")]
        public class RoleController : Controller
        {
            private readonly RoleManager<IdentityRole> roleManager;
            private readonly UserManager<User> userManager;

            public RoleController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
            {
                this.roleManager = roleManager;
                this.userManager = userManager;
            }

        public IActionResult Role()
        {
            RoleViewModel RoleVM = new RoleViewModel();
            RoleVM.Roles = roleManager.Roles.ToList();
            RoleVM.AllUsers = userManager.Users.ToList();
            return View(RoleVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CreateRoleViewModel createRoleVM)
        {
            var role = await roleManager.FindByIdAsync(createRoleVM.RoleId);
            role.Name = createRoleVM.Name;
            await roleManager.UpdateAsync(role);
            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, createRoleVM.Name))
                {
                    createRoleVM.RolesUsers.Add(user);
                }
            }
            return View(createRoleVM);
        }
  [HttpPost]
        public async Task<IActionResult> Create(RoleViewModel newRole)
        {
            IdentityRole identityRole = new IdentityRole
            { 
                Name = newRole.CreateRoleViewModel.Name
            };
            var result = await roleManager.CreateAsync(identityRole);
            if (result.Succeeded)
            {
                return RedirectToAction("Role");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int RoleId)
        {
            var role = await roleManager.FindByIdAsync(RoleId.ToString());
            await roleManager.DeleteAsync(role);
            return RedirectToAction("Role");
        }
        }
    }


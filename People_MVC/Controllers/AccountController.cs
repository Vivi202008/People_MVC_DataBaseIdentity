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
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(CreateUserViewModel registerUser)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    var newUser = new User
                    {
                        FirstName = registerUser.FirstName,
                        LastName = registerUser.LastName,
                        Email = registerUser.Email,
                        Birthday = registerUser.Birthday
                    };
                    var result = await userManager.CreateAsync(newUser, registerUser.ConfirmPassword);
                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(newUser, false);
                        return RedirectToAction("Index", "Person");
                    }

                }
                return View();
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginUser)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginUser.UserName, loginUser.Password,false,false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Person");
                }
                ModelState.AddModelError("", "Unable To Login " + result.ToString());
                return View();  
            }
            else
            {
                ViewBag.LoginErrorMsg = "Wrong username or password,";
                return View();
            }
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

         public IActionResult AccessDenied()
          {
                    return View();
          }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamPortal.Models;
using ExamPortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExamPortal.Controllers
{

    public class ExaminerController : Controller
    {
        private readonly ITestRepository testRepository;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public ExaminerController(ITestRepository testRepository, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.testRepository = testRepository;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [Authorize(Roles = "Examiner")]
        public IActionResult Dashboard()
        {
            
            
            return View(testRepository.ListTests());
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //public async Task<IActionResult> Register(RegisterUserViewModel model, string roleName)
        //{
        //    return await RegisterUser(model, "Examiner");

        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    DOB = model.DOB
                };

                var result = await userManager.CreateAsync(user, model.Password);

                string roleName = "Examiner";

                var role = await roleManager.FindByNameAsync(roleName);

                if (role == null)
                {
                    return NotFound(role);
                }

                var addRole = await userManager.AddToRoleAsync(user, role.Name);
                

                if (result.Succeeded && addRole.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: true);
                    return RedirectToAction("dashboard");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    foreach (var error in addRole.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }

            }

            return View(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamPortal.Models;
using ExamPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ExamPortal.Controllers
{


    public class CandidateController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ITestRepository testRepository;

        public CandidateController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, ITestRepository testRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.testRepository = testRepository;
        }

        public IActionResult Dashboard()
        {
            return View(testRepository.ListTests());
        }

        public IActionResult Register()
        {
            return  View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    DOB = model.DOB
                };

                var result = await userManager.CreateAsync(user, model.Password);
                string roleName = "Candidate";
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


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using G191210068_Web_Muhasebe.Models;
using G191210068_Web_Muhasebe.Models.Data;
using G191210068_Web_Muhasebe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly MuhasebeDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(MuhasebeDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
             _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);//id
            var users = _userManager.Users.Where(x=>x.Id!=userId);
            return View(users);
        }
       
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByIdAsync(id);

            
            var roles = await _userManager.GetRolesAsync(user);

            ViewBag.role = roles;
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteConfirmed(string id )
        {

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> ManageUserRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            List<IdentityRole> allRoles = _roleManager.Roles.ToList();
            List<string> userRoles = await _userManager.GetRolesAsync(user) as List<string>;
            List<UserRoleViewModel> assignRoles = new List<UserRoleViewModel>();
            allRoles.ForEach(role => assignRoles.Add(new UserRoleViewModel
            {
                HasAssign = userRoles.Contains(role.Name),
                RoleId = role.Id,
                RoleName = role.Name
            }));

            return View(assignRoles);
        }
        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(List<UserRoleViewModel> model, string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            foreach (UserRoleViewModel role in model)
            {
                if (role.HasAssign)
                    await _userManager.AddToRoleAsync(user, role.RoleName);
                else
                    await _userManager.RemoveFromRoleAsync(user, role.RoleName);
            }
            return RedirectToAction("Edit", new { id = id });


        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            ViewBag.userID = id;
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            // GetClaimsAsync retunrs the list of user Claims
            var userClaims = await _userManager.GetClaimsAsync(user);
            // GetRolesAsync returns the list of user Roles
            var userRoles = await _userManager.GetRolesAsync(user);

            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Claims = userClaims.Select(c => c.Value).ToList(),
                Roles = userRoles
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }
    }
}


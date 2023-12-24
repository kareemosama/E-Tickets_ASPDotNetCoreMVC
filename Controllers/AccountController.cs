using eTickets.Data;
using eTickets.Data.Static;
using eTickets.Data.ViewModel;
using eTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManger, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _userManger = userManger;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Login() => View(new LoginVM());

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM) 
        {
            if (!ModelState.IsValid) return View(loginVM);

            var user = await _userManger.FindByEmailAsync(loginVM.EmailAddress);
            if(user != null)
            {
                var passwordCheck = await _userManger.CheckPasswordAsync(user,loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Index", "Movies");
                    }
                }
                TempData["Error"] = "Wrond credentials. Please TryAgain!";
                return View(loginVM);
            }

            TempData["Error"] = "Wrond credentials. Please TryAgain!";
            return View(loginVM);
            
        }

        public IActionResult Register() => View(new RegisterVM());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM) 
        {
            if (!ModelState.IsValid) return View(registerVM);

            var user = await _userManger.FindByEmailAsync(registerVM.EmailAddress);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerVM);
            }
            var newUser = new ApplicationUser()
            {
                FullName = registerVM.FullName,
                Email = registerVM.EmailAddress,
                UserName= registerVM.EmailAddress
            };
            var newUserResponse = await _userManger.CreateAsync(newUser,registerVM.Password);
            if (!newUserResponse.Succeeded)
            {
                TempData["Error"] = newUserResponse.Errors.FirstOrDefault().Description; 
                return View(registerVM);
            }
            if (newUserResponse.Succeeded) await _userManger.AddToRoleAsync(newUser, UserRoles.User);

            return View("RegisterCompleted");
        }

        [HttpPost]
        public async Task<IActionResult> Logout() 
        { 
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Movies");
        }

        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        } 

    }
}

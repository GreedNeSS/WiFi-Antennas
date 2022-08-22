using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.BLL.Interfaces;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserViewModel userViewModel, [FromServices] IAccessUserService accessUserService,
            [FromServices] ITokenCreator tokenCreator)
        {
            if (userViewModel != null)
            {
                UserDTO user = new UserDTO { Login = userViewModel.Login, Password = userViewModel.Password };

                if (accessUserService.IsAllowed(user))
                {
                    Response.Redirect("/home/index");
                    return SignIn(tokenCreator.GetClaimsPrincipal(user));
                }
                else
                {
                    ModelState.AddModelError("", "Некорректный логин или пароль");
                }
                
            }

            return View(userViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            Response.Redirect("/auth/login");
            return SignOut(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}

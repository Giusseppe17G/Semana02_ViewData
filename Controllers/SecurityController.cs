using Microsoft.AspNetCore.Mvc;

namespace Semana02_UESAN_FirstMVC.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            ViewData["Bienvenida"] = "Iniciar sesión en el sistema";
            ViewData["Año]"] = 2022;
            return View();
        }
    }
}

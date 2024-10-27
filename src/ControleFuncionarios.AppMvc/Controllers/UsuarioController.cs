using Microsoft.AspNetCore.Mvc;

namespace ControleFuncionarios.AppMvc.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

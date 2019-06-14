using Microsoft.AspNetCore.Mvc;

namespace Projeto_final.Controllers
{
    public class SacController : Controller
    {
         [HttpGet]
          public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }
    }
}
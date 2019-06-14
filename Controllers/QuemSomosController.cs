using Microsoft.AspNetCore.Mvc;

namespace Projeto_final.Controllers
{
    public class QuemSomosController : Controller
    {

        [HttpGet]
        public IActionResult Index(){

            ViewData["NomeView"] = "QuemSomos";
            return View();
        
        }
    }
}
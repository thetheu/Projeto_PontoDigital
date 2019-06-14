using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projetinho_final.Repositorios;
using Projeto_final.Repositorios;

namespace Projeto_final.Controllers
{
    
    public class AdministradorController : Controller
    {
        public IActionResult Index(){
            return View();
        }



        public IActionResult Listar(){
            CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();

            ViewData["cadastro"] = cadastroRepositorio.Listar();

            return View();
        }
    }
}
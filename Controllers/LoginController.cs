using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projetinho_final.Repositorios;
using Projeto_final.Models;
using Projeto_final.Repositorios;

namespace Projeto_final.Controllers
{
    public class LoginController : Controller
    {
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();

        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
            private const string SESSION_EMAILADM = "_EMAILADM";
            private const string SESSION_CLIENTEADM = "_CLIENTEADM";
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Logar(IFormCollection form)
        {
            var cadastre = form["email"];
            var senha = form["senha"];
            var cadastreRetornado = "adm@admin.com";
            var senhaRetornado = "adm";
            var lista = cadastroRepositorio.Listar();
            

            if(cadastre.Equals(cadastreRetornado) && senha.Equals(senhaRetornado) ){
                
                foreach (var item in lista)
            {
                if (lista != null && item.Senha.Equals(senha) && item.Email.Equals(cadastre))
                {
                    HttpContext.Session.SetString(SESSION_EMAILADM, cadastre);
                    HttpContext.Session.SetString(SESSION_CLIENTEADM, item.Nome);
                    System.Console.WriteLine("POOOOOOOOOOOOOOOOOOOOOOOOIIIIIIIIIIIIIII");
                }
            }
            return RedirectToAction("Index", "Administrador");

            }else{

            foreach (var item in lista)
            {
                if (lista != null && item.Senha.Equals(senha) && item.Email.Equals(cadastre))
                {
                    HttpContext.Session.SetString(SESSION_EMAIL, cadastre);
                    HttpContext.Session.SetString(SESSION_CLIENTE, item.Nome);
                }
            }
            return RedirectToAction("Index", "Comentario");
        }
    }









        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}
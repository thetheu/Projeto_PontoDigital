using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projetinho_final.Repositorios;
using Projeto_final.Models;
using Projeto_final.Repositorios;

namespace Projeto_final.Controllers
{
    public class ComentarioController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";

        public IActionResult Index() 
        {
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            return View();
        }

        [HttpPost]
        public IActionResult Depoimento (IFormCollection form)
        {
            Comentario comentario = new Comentario();
            CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();

            var email = HttpContext.Session.GetString(SESSION_EMAIL);
            var cadastroRetornado = cadastroRepositorio.ObterPor(email);

            comentario.Cadastro = cadastroRetornado;
            comentario.Texto = form["comentario"];
            

            ComentarioRepositorio cr = new ComentarioRepositorio();
            cr.InserirComentario(comentario);

            return RedirectToAction("Index", "Home");

        }

    }
}
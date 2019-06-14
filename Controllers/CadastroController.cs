using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projetinho_final.Repositorios;
using Projeto_final.Models;
using Projeto_final.Repositorios;

namespace Projeto_final.Controllers
{
    public class CadastroController : Controller
    {
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        
        [HttpPost]
        public IActionResult RegistrarUsuario(IFormCollection form)
        {   
            Cadastro cadastro = new Cadastro();
            cadastro.Nome = form["nome"];
            cadastro.Email = form["email"];
            cadastro.Senha = form["senha"];
            cadastro.DataNascimento = DateTime.Parse(form["dataNascimento"]);

            cadastroRepositorio.RegistrarUsuario(cadastro);

            ViewData["NomeView"] = "Home";
            return RedirectToAction("Index", "Login");
       }








    }
}
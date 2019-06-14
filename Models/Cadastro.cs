using System;

namespace Projeto_final.Models
{
    public class Cadastro
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Administrador {get;set;}
        public DateTime DataNascimento {get;set;}
   

        public Cadastro(string nome, string email, string senha, DateTime dataNascimento){
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;

        }
         public Cadastro(int id, string nome, string email, string senha, DateTime dataNascimento){
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;

        }

        public Cadastro()
        {
        }
    }
}
using System;

namespace Projeto_final.Models
{
    public class Comentario
    {
        public int Id {get;set;}
        public Cadastro Cadastro {get;set;}
        public string Texto {get;set;}
        public DateTime DataCricacao {get;set;}
        public bool Status {get;set;}

    }
}
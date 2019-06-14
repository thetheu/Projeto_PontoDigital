using System;
using System.Collections.Generic;
using System.IO;
using Projeto_final.Models;

namespace Projeto_final.Repositorios
{
    public class ComentarioRepositorio
    {
        private const string PATH = "Database/Depoimentos.csv";

        public List<Comentario> listaDeClientes = new List<Comentario>();

        public void InserirComentario(Comentario comentario){
            if (File.Exists (PATH))
            {
                comentario.Id = File.ReadAllLines (PATH).Length + 1;   
            }else{
                comentario.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine ($"{comentario.Id};{comentario.Cadastro.Nome};{comentario.Texto};{comentario.Status};{DateTime.Now};");
            sw.Close();
        }
    }
}
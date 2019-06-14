using System;
using System.Collections.Generic;
using System.IO;
using Projeto_final.Models;

namespace Projetinho_final.Repositorios
{
    public class CadastroRepositorio
    {

        public List<Cadastro> listaDeClientes = new List<Cadastro>();
        private const string PATH = "Database/Cadastros.csv";
        public void RegistrarUsuario(Cadastro cadastro){

            if (!File.Exists(PATH))
            {   
                cadastro.Id = File.ReadAllLines(PATH).Length + 1;
            }else{
                cadastro.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine($"{cadastro.Id};{cadastro.Nome};{cadastro.Email};{cadastro.Senha};{cadastro.DataNascimento}");
            sw.Close();
        }

        
        // public List<Cadastro> Listar()
        // {
        //     string[] cadastro = File.ReadAllLines(PATH);
        //     Cadastro cadastru;

        //     foreach (var item in cadastro)
        //     {
        //         if (item != null)
        //         {
        //             string [] dados = item.Split(";");
        //             Cadastro cadastre = new Cadastro();

        //             cadastre.Id = int.Parse(dados[0]);
        //             cadastre.Nome = dados[1];
        //             cadastre.Email = dados[2];
        //             cadastre.Senha = dados[3];
        //             cadastre.DataNascimento = DateTime.Parse(dados[4]);
        //             cadastre.Administrador = dados[5];

        //             listaDeClientes.Add(cadastre);
                    
        //             continue;
        //         }
        //     }
        //     return listaDeClientes;
        // }

         public List<Cadastro> Listar () {
            List<Cadastro> listaDeUsuarios = new List<Cadastro> ();
            string[] linhas = File.ReadAllLines ("Database/Cadastros.csv");
            Cadastro cadastro;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    //sair do foreach
                    continue;
                }

                string[] linha = item.Split (";");

                //pegou os dados do csv 
                cadastro = new Cadastro (
                    id: int.Parse (linha[0]),
                    nome: linha[1],
                    email: linha[2],
                    senha: linha[3],
                    dataNascimento: DateTime.Parse (linha[4])
                );
                listaDeUsuarios.Add (cadastro);
            }
            return listaDeUsuarios;
        }

        public Cadastro ObterPor (string email)
        {
            foreach (var item in Listar())
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Cadastro ObterPorSenha (string senha)
        {
            foreach (var item in Listar())
            {
                if (item.Email == senha)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
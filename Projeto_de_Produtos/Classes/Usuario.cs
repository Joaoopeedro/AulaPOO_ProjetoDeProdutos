using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Usuario :  Iusuario
    {
        private int Codigo { get; set; }=1;

        private string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        private DateTime DataDeCadastro { get; set; }

        public List<Usuario> usuario = new List<Usuario>();

        public string Cadastrar()
        {
           Console.WriteLine("Digite seu nome");
           string nickname = Console.ReadLine();
           Nome=nickname;
           Console.WriteLine("Digite seu email");
           string EmailDeUsuario = Console.ReadLine();
           Email=EmailDeUsuario;
           Console.WriteLine("Digite sea senha");
           string senhaDeUsuario = Console.ReadLine();
           Senha=senhaDeUsuario;
           return "Cadastro feito com sucesso!!! ";
        }

        public string Deletar(Usuario usuario)
        {
          Codigo=0; 
          Nome=null; 
          Email=null; 
          Senha=null; 
          return "Cadastro deletado com sucesso!!! ";
        }
    }
}
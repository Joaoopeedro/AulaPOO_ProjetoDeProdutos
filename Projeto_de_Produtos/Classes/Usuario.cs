using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Usuario :  Iusuario
    {
        private int Codigo { get; set; }=1;

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public DateTime DataDeCadastro { get; set; }= DateTime.Now;

        
        
        

        public List<Usuario> ListaUsuario = new List<Usuario>();

        public string Cadastrar(Usuario usuario)
        {
          ListaUsuario.Add(usuario);
           
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
using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Marca : Imarca
    {
        private int Codigo { get; set; }

        public string NameMarca { get;  set; }

        public DateTime DataCadastro { get; set; }


        List<Marca> ListaMarcas = new List<Marca>();

        public Marca (){
            Console.WriteLine("Qual a marca do produto ??");
            NameMarca = Console.ReadLine();
        }
        public Marca(string _nomeMarca){
            NameMarca = _nomeMarca;
            DataCadastro = DateTime.Now;
        }

        public string Cadastrar(Marca marca)
        {
           ListaMarcas.Add(marca);
           return "Marca cadastrada com sucesso!!";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }

        public string Deletar(Marca marca)
        {
            ListaMarcas.RemoveAll(x => x.NameMarca == marca.NameMarca);
            return "Marca removida com sucesso!!";
        }
    }
}
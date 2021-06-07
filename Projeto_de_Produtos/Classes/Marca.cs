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
            ListaMarcas.Remove(marca);
            return "Marca removida com sucesso!!";
        }
    }
}
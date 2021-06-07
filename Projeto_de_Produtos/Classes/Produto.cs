using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Produto : Iproduto
    {
        private int Codigo { get; set; }
        private string NameProduto { get; set; }
        private float Preco { get; set; }
        private DateTime DataCadastro { get; set; }
        private Marca Marca { get; set; }
        private Usuario CadastradoPor { get; set; }
        private List<Produto> ListaDeProdutos { get; set; }

        List<Produto> ListaProduto = new List<Produto>();

        public string Cadastrar(Produto produto)
        {
            ListaDeProdutos.Add(produto);
            return "Produto cadastrado com sucesso!!";
        }

        public List<Produto> Listar()
        {
            return ListaDeProdutos;
        }

        public string Deletar(Produto produto)
        {
            ListaDeProdutos.Remove(produto);
            return "Produto removido com sucesso";
            
        }
    }
}
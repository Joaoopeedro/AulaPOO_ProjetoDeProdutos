using System.Collections.Generic;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Interfaces
{
    public interface Iproduto
    {
        string Cadastrar(Produto produto);
        List<Produto> Listar();
        string Deletar(Produto produto);
    }
}
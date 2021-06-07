using System.Collections.Generic;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Interfaces
{
    public interface Imarca
    {
        string Cadastrar(Marca marca);
        List<Marca> Listar();
        string Deletar(Marca marca);
    }
}
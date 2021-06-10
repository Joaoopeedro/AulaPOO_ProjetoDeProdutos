using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos.Interfaces
{
    public interface Ilogin
    {
        void login();

        string Logar(Usuario usuario);
        string Deslogar();
 
    }
}
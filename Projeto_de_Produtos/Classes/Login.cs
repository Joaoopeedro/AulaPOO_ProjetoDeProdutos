using System;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Login : Ilogin
    {
        private bool Logado { get; set; }
        public Login()
        {
            Usuario u = new Usuario();
            Produto p = new Produto();
            Marca m = new Marca();
            bool checar = true;


            int opcao;
            do
            {



                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($@"
O QUE VOCÊ DESEJA REALIZAR?

1- CADASTRAR USUARIO
2- FAZER LOGIN
3- DESLOGAR
4- CADASTRAR MARCA
5- LISTAR MARCAS
6- DESLOGAR MARCAS
7- CADASTRAR PRODUTO
8- LISTAR PRODUTO
9- DELETAR PRODUTO
");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(u.Cadastrar());

                        break;

                    case 2:
                        do
                        {

                            Console.WriteLine("Digite seu email: ");
                            string emailLogar = Console.ReadLine().ToLower();
                            Console.WriteLine("Digite sua senha: ");
                            string senhaLogar = Console.ReadLine();
                            if (u.usuario.Find(x => x.Email == emailLogar).Senha == senhaLogar)
                            {
                                Console.WriteLine(Logar(u));
                                checar = false;

                            }

                            else
                            {
                                Console.WriteLine("Email ou senha incorretos");
                            }
                        } while (checar == true);
                        checar = true;


                        break;

                    case 3:
                        Console.WriteLine(Deslogar());

                        break;

                    case 4:



                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    case 7:

                        break;

                    case 8:

                        break;

                    case 9:

                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            } while (opcao != 3);

        }

        public string Deslogar()
        {
            return "Você foi deslogado";
        }

        public string Logar(Usuario usuario)
        {
            if (Logado == false)
            {
                Logado = true;
                return "Login feito com sucesso!!!";

            }
            return "Você já esta logado";
            throw new System.NotImplementedException();
        }

        public void login()
        {
            throw new System.NotImplementedException();
        }
    }
}
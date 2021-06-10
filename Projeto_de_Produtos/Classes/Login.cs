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
6- DELETAR MARCAS
7- CADASTRAR PRODUTO
8- LISTAR PRODUTO
9- DELETAR PRODUTO
");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        if (m.ListaMarcas.Count > 0)
                        {
                            Console.WriteLine(u.Cadastrar());

                        }
                        else
                        {
                            Console.WriteLine("Você não tem nenhuma marca cadastrada. Cadastre uma marca antes de cadastrar um produto");
                        }

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
                        Marca m1 = new Marca();
                        Console.WriteLine("Qual o nome da marca? ");
                        m1.NameMarca = Console.ReadLine();
                        Console.WriteLine(m.Cadastrar(m1));



                        break;

                    case 5:

                        m.Listar();

                        break;

                    case 6:
                        Marca m3 = new Marca();
                        Console.WriteLine("Qual marca você deseja deletar? ");
                        m3.NameMarca = Console.ReadLine();
                        Console.WriteLine(m.Deletar(m3));


                        break;

                    case 7:

                        Produto p2 = new Produto();
                        Console.WriteLine("Qual é o Produto ??");
                        p2.NameProduto = Console.ReadLine();
                        do
                        {


                            Console.WriteLine("Qual  marca do produto ??");
                            string marcaProduto = Console.ReadLine();
                            p2.Marca = m.ListaMarcas.Find(x => x.NameMarca == marcaProduto);
                        } while (p2.Marca == null);
                        Console.WriteLine(p.Cadastrar(p2));


                        break;

                    case 8:

                        Console.WriteLine(p.ListaDeProdutos.Count);
                        if (p.ListaDeProdutos.Count <= 0)
                        {
                            Console.WriteLine("Sua lista esta vazia!!!");
                        }
                        else
                        {

                            Console.WriteLine($"LISTA DE PRODUTOS");
                            foreach (Produto np in p.ListaDeProdutos)
                            {
                                Console.WriteLine($"Nome do Produto: {np.NameProduto} | ");
                            }

                        }

                        break;

                    case 9:

                        Produto p3 = new Produto();
                        
                        Console.WriteLine("Qual produto você deseja deletar??");
                        p3.NameProduto = Console.ReadLine();
                        Console.WriteLine(p.Deletar(p3));

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
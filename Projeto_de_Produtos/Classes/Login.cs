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
            
            int opcao;
            int opcao2;
            Usuario usuarioEncontrado = null;

            do
            {


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
{u.DataDeCadastro}
===================
| MENU DE CADASTRO|

1- CADASTRAR USUARIO
2- FAZER LOGIN
");
                Console.ResetColor();
                opcao2 = int.Parse(Console.ReadLine());
                switch (opcao2)
                {
                    case 1:
                        if (u.ListaUsuario.Count == 0)
                        {
                            Usuario cadastroUsuario = new Usuario();
                            Console.WriteLine("Digite seu nome");
                            cadastroUsuario.Nome = Console.ReadLine();
                            Console.WriteLine("Digite seu email");
                            cadastroUsuario.Email = Console.ReadLine();
                            Console.WriteLine("Digite sea senha");
                            cadastroUsuario.Senha = Console.ReadLine();
                            Console.WriteLine(u.Cadastrar(cadastroUsuario));

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Você já esta cadastrado! ");
                            Console.ResetColor();
                        }

                        break;
                    case 2:

                        Console.WriteLine("Digite seu email: ");
                        string emailLogar = Console.ReadLine().ToLower();
                        Console.WriteLine("Digite sua senha: ");
                        string senhaLogar = Console.ReadLine();
                        usuarioEncontrado = u.ListaUsuario.Find(x => x.Email == emailLogar && x.Senha == senhaLogar);
                        if (usuarioEncontrado != null)
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(Logar(u));
                            Console.ResetColor();
                            

                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Email ou senha incorretos");
                            Console.ResetColor();
                        }

                        break;
                    default:
                        Console.WriteLine("Opção invalida");

                        break;
                }
            } while (usuarioEncontrado == null);


            do
            {



                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($@"
{u.DataDeCadastro}1

===========================
O QUE VOCÊ DESEJA REALIZAR?


1- CADASTRAR MARCA
2- LISTAR MARCAS
3- DELETAR MARCAS
4- CADASTRAR PRODUTO
5- LISTAR PRODUTO
6- DELETAR PRODUTO
7- DESLOGAR
");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Marca m1 = new Marca();
                        Console.WriteLine("Qual o nome da marca? ");
                        m1.NameMarca = Console.ReadLine();
                        Console.WriteLine(m.Cadastrar(m1));



                        break;

                    case 2:

                        m.Listar();

                        break;

                    case 3:
                        Marca m3 = new Marca();
                        Console.WriteLine("Qual marca você deseja deletar? ");
                        m3.NameMarca = Console.ReadLine();
                        Console.WriteLine(m.Deletar(m3));


                        break;

                    case 4:
                        if (m.ListaMarcas.Count > 0)
                        {
                            Produto p2 = new Produto();
                            Console.WriteLine("Qual é o Produto? ");
                            p2.NameProduto = Console.ReadLine();
                            Console.WriteLine("Qual o valor do produto?");
                            p2.Preco = float.Parse(Console.ReadLine());
                            do
                            {
                                Console.WriteLine("Qual  marca do produto? ");
                                string marcaProduto = Console.ReadLine();
                                p2.Marca = m.ListaMarcas.Find(x => x.NameMarca == marcaProduto);
                                if (p2.Marca == null)
                                {
                                    Console.WriteLine("Essa marca nao foi cadastrada");
                                    Console.WriteLine("MARCAS DISPONIVEIS!");
                                    foreach (Marca item in m.ListaMarcas)
                                    {
                                        Console.WriteLine(item.NameMarca);
                                    }

                                }
                            } while (p2.Marca == null);
                            p2.CadastradoPor = usuarioEncontrado;
                            Console.WriteLine(p.Cadastrar(p2));

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Você não tem nenhuma marca cadastrada. Cadastre uma marca antes de cadastrar um produto ");
                            Console.ResetColor();
                        }



                        break;

                    case 5:

                        
                        if (p.ListaDeProdutos.Count <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sua lista esta vazia!!!");
                            Console.ResetColor();
                        }
                        else
                        {

                            Console.WriteLine($"LISTA DE PRODUTOS");
                            foreach (Produto np in p.ListaDeProdutos)
                            {
                                Console.WriteLine($"Nome do Produto: {np.NameProduto} | Marca: {np.Marca.NameMarca} | Preço: {np.Preco:C2}| Usuario: {np.CadastradoPor.Nome} ");
                            }

                        }

                        break;

                    case 6:

                        Produto p3 = new Produto();

                        Console.WriteLine("Qual produto você deseja deletar??");
                        p3.NameProduto = Console.ReadLine();
                        Console.WriteLine(p.Deletar(p3));

                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Deslogar());
                        Console.ResetColor();

                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            } while (opcao != 7);

        }

        public string Deslogar()
        {
            return "Você foi deslogado!";
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
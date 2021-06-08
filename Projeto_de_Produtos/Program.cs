﻿using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Classes;

namespace Projeto_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Produto p = new Produto();
            
            do
            {



                Console.WriteLine($@"
OQUE VOCÊ DESEJA REALIZAR

1- CADASTRAR
2- VER LISTA
3- DELETAR
0- SAIR DO PROGRAMA");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Produto p2 = new Produto();

                    Console.WriteLine("Qual é o Produto ??");
                    p2.NameProduto = Console.ReadLine();
                    Console.WriteLine(p.Cadastrar(p2));


                }
                else if (opcao == 2)
                {
                    // List<Produto> ListaProdutos = p.ListaDeProdutos;
                    Console.WriteLine(p.ListaDeProdutos.Count);
                    if (p.ListaDeProdutos.Count <= 0)
                    {
                        Console.WriteLine("Sua lista esta vazia!!!");
                    }
                    else
                    {
                        Console.WriteLine($"LISTA DE PRODUTOS");
                        foreach (Produto p2 in p.ListaDeProdutos)
                        {
                            Console.WriteLine($"Nome do Produto: {p2.NameProduto} || ");
                        }

                    }
                }
                else if (opcao == 3)
                {
                    Produto p3 = new Produto();
                    Console.WriteLine("Qual produto você deseja deletar??");
                    p3.NameProduto = Console.ReadLine();
                    if (p3.NameProduto == p3.NameProduto)
                    {
                        Console.WriteLine(p.Deletar(p3));

                    }else
                    {
                        Console.WriteLine("Produto inexistente");
                    }
                
                }

            } while (opcao != 0);
            Console.WriteLine("Até logo !! ");
        }
    }
}

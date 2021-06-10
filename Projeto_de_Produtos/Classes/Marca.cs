using System;
using System.Collections.Generic;
using Projeto_de_Produtos.Interfaces;

namespace Projeto_de_Produtos.Classes
{
    public class Marca : Imarca
    {
        private int Codigo { get; set; }

        public string NameMarca { get; set; }

        public DateTime DataCadastro { get; set; }


        public List<Marca> ListaMarcas = new List<Marca>();

        public Marca()
        {
            // Console.WriteLine("Qual o nome da marca  ??");

        }
        public Marca(string _nomeMarca)
        {
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
            if (ListaMarcas.Count > 0)
            {
                Console.WriteLine("LISTA DE MARCAS");
                foreach (Marca m2 in ListaMarcas)
                {
                    Console.WriteLine($@"
 
[NOME MARCA]: { m2.NameMarca}");
                }
            }
            else
            {
                Console.WriteLine("Não há nenhum item na lista");
            }
            return ListaMarcas;
        }

        public string Deletar(Marca marca)
        {

            int marcaDeletado = ListaMarcas.RemoveAll(x => x.NameMarca == marca.NameMarca);
            if (marcaDeletado == 1)
            {

                return "Marca removida com sucesso!!";
            }
            else
            {
                return "Marca inexistente";
            }
        }
    }
}
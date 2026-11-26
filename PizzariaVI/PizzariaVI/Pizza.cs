using System;
using System.Collections.Generic;
using System.Text;

namespace PizzariaVI
{
    public class Pizza : Produto
    {
        public string Sabor;
        public string Tamanho;

        public Pizza()
        {
            Nome = "Pizza";
            Sabor = "Não informado";
            Tamanho = "Média";
            Preco = 0;
        }

        public Pizza(string sabor, string tamanho, double preco)
        {
            Nome = "Pizza";
            Sabor = sabor;
            Tamanho = tamanho;
            Preco = preco;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Pizza: " + Sabor);
            Console.WriteLine("Tamanho: " + Tamanho);
            Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
        }
    }
}

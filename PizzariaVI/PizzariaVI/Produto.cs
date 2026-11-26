using System;
using System.Collections.Generic;
using System.Text;

namespace PizzariaVI
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto()
        {
            Nome = "Produto não informado";
            Preco = 0;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine("Produto: " + Nome);
            Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
        }
    }
}

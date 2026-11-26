using System;
using System.Collections.Generic;
using System.Text;


namespace PizzariaVI
{
    public class Bebida : Produto
    {
        public string Tipo;

        public Bebida()
        {
            Nome = "Bebida";
            Tipo = "Não informado";
            Preco = 0;
        }

        public Bebida(string tipo, double preco)
        {
            Nome = "Bebida";
            Tipo = tipo;
            Preco = preco;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Bebida: " + Tipo);
            Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
        }
    }
}


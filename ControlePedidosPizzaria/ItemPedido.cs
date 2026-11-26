using System;

namespace ControlePedidosPizzaria
{
    public class ItemPedido
    {
        public Produto Produto;
        public int Quantidade;

        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public double CalcularSubtotal()
        {
            return Produto.Preco * Quantidade;
        }

        public void ExibirItem()
        {
            Console.WriteLine("----------------------------------");
            Produto.ExibirInformacoes();
            Console.WriteLine("Quantidade: " + Quantidade);
            Console.WriteLine("Subtotal: R$ " + CalcularSubtotal().ToString("F2"));
        }
    }
}

namespace PizzariaVI
{
    class Program
    {
        static List<Produto> cardapio = new List<Produto>();
        static List<ItemPedido> pedido = new List<ItemPedido>();

        static void Main(string[] args)
        {
            cardapio.Add(new Pizza("Calabresa", "Grande", 45.00));
            cardapio.Add(new Pizza("Mussarela", "Média", 35.00));
            cardapio.Add(new Pizza("Frango com Catupiry", "Grande", 48.00));
            cardapio.Add(new Pizza("Portuguesa", "Média", 42.00));
            cardapio.Add(new Bebida("Coca-Cola 2L", 12.00));
            cardapio.Add(new Bebida("Guaraná 2L", 10.00));
            cardapio.Add(new Bebida("Água Mineral", 4.00));
            cardapio.Add(new Bebida("Suco de Laranja", 8.00));

            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("========== PIZZARIA DO C# ==========");
                Console.WriteLine("1 - Visualizar Produtos / Adicionar ao Pedido");
                Console.WriteLine("2 - Visualizar Itens do Pedido");
                Console.WriteLine("3 - Remover Itens do Pedido");
                Console.WriteLine("4 - Finalizar Pedido");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("====================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        VisualizarEAdicionar();
                        break;
                    case 2:
                        VisualizarPedido();
                        break;
                    case 3:
                        RemoverItem();
                        break;
                    case 4:
                        FinalizarPedido();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);
        }

        static void VisualizarEAdicionar()
        {
            Console.Clear();
            Console.WriteLine("========== CARDÁPIO ==========\n");

            for (int i = 0; i < cardapio.Count; i++)
            {
                Console.WriteLine("Código: " + (i + 1));
                cardapio[i].ExibirInformacoes();
                Console.WriteLine();
            }

            Console.Write("\nDigite o código do produto que deseja adicionar (0 para voltar): ");
            int codigo = int.Parse(Console.ReadLine());

            if (codigo == 0) return;

            if (codigo < 1 || codigo > cardapio.Count)
            {
                Console.WriteLine("Código inválido!");
                Console.ReadKey();
                return;
            }

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= 0)
            {
                Console.WriteLine("Quantidade inválida!");
                Console.ReadKey();
                return;
            }

            ItemPedido item = new ItemPedido(cardapio[codigo - 1], quantidade);
            pedido.Add(item);

            Console.WriteLine("\nItem adicionado com sucesso!");
            Console.ReadKey();
        }

        static void VisualizarPedido()
        {
            Console.Clear();
            Console.WriteLine("========== ITENS DO PEDIDO ==========\n");

            if (pedido.Count == 0)
            {
                Console.WriteLine("Nenhum item no pedido ainda.");
            }
            else
            {
                double total = 0;
                for (int i = 0; i < pedido.Count; i++)
                {
                    Console.WriteLine("Item #" + (i + 1));
                    pedido[i].ExibirItem();
                    total += pedido[i].CalcularSubtotal();
                }
                Console.WriteLine("\n=====================================");
                Console.WriteLine("TOTAL ATUAL: R$ " + total.ToString("F2"));
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void RemoverItem()
        {
            Console.Clear();
            Console.WriteLine("========== REMOVER ITEM ==========\n");

            if (pedido.Count == 0)
            {
                Console.WriteLine("Não há itens para remover.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine("Item #" + (i + 1));
                pedido[i].ExibirItem();
            }

            Console.Write("\nDigite o número do item que deseja remover: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 1 || numero > pedido.Count)
            {
                Console.WriteLine("Número inválido!");
            }
            else
            {
                pedido.RemoveAt(numero - 1);
                Console.WriteLine("Item removido com sucesso!");
            }

            Console.ReadKey();
        }

        static void FinalizarPedido()
        {
            Console.Clear();
            Console.WriteLine("========== FINALIZAR PEDIDO ==========\n");

            if (pedido.Count == 0)
            {
                Console.WriteLine("O pedido está vazio!");
                Console.ReadKey();
                return;
            }

            double total = 0;
            Console.WriteLine("Resumo do pedido:\n");

            for (int i = 0; i < pedido.Count; i++)
            {
                pedido[i].ExibirItem();
                total += pedido[i].CalcularSubtotal();
            }

            Console.WriteLine("\n=====================================");
            Console.WriteLine("TOTAL DO PEDIDO: R$ " + total.ToString("F2"));
            Console.WriteLine("=====================================");
            Console.WriteLine("\nPedido finalizado! Obrigado.");

            pedido.Clear();

            Console.ReadKey();
        }
    }
}

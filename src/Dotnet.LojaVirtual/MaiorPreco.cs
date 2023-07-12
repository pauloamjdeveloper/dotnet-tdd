namespace Dotnet.LojaVirtual
{
    public class MaiorPreco
    {
        public double EncontrarMenorPreco(CarrinhoDeCompras carrinho) 
        {
            if (carrinho.Itens.Count == 0) 
            {
                return 0;
            }

            var maior = carrinho.Itens[0].ValorTotal;

            foreach (var item in carrinho.Itens) 
            {
                if (maior < item.ValorTotal) 
                {
                    maior = item.ValorTotal;
                }
            }

            return maior;
        }
    }
}

namespace Dotnet.LojaVirtual.Tests
{
    public class MaiorPrecoTest
    {
        [Fact]
        public void EncontrarMenorPreco_DeveRetornarZeroSeCarrinhoVazio()
        {
            var carrinho = new CarrinhoDeCompras();

            Assert.Equal(0.0, carrinho.MaiorValor(), 0.0001);
        }

        [Fact]
        public void EncontrarMenorPreco_DeveRetornarValorDoItemSeCarrinhoComUmElemento()
        {
            var carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            
            Assert.Equal(900.0, carrinho.MaiorValor(), 0.0001);
        }

        [Fact]
        public void EncontrarMenorPreco_DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            var carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

            Assert.Equal(1500.0, carrinho.MaiorValor(), 0.0001);
        }
    }
}
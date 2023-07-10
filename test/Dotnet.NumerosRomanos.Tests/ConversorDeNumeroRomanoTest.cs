namespace Dotnet.NumerosRomanos.Tests
{
    public class ConversorDeNumeroRomanoTest
    {
        [Fact]
        public void ConverteNumero_ValorInteiroZeroEsperado_DeveEntenderOSimboloVazio()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("");
            Assert.Equal(0, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroUmEsperado_DeveEntenderOSimboloI()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("I");
            Assert.Equal(1, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroDoisEsperado_DeveEntenderOSimboloII()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("II");
            Assert.Equal(2, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroTresEsperado_DeveEntenderOSimboloIII()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("III");
            Assert.Equal(3, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroCincoEsperado_DeveEntenderOSimboloV()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("V");
            Assert.Equal(5, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroDezEsperado_DeveEntenderOSimboloX()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("X");
            Assert.Equal(10, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroCinquentaEsperado_DeveEntenderOSimboloL()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("L");
            Assert.Equal(50, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroCemEsperado_DeveEntenderOSimboloC()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("C");
            Assert.Equal(100, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroQuinhentosEsperado_DeveEntenderOSimboloD()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("D");
            Assert.Equal(500, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroMilEsperado_DeveEntenderOSimboloM()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("M");
            Assert.Equal(1000, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroQuatroEsperado_DeveEntenderOSimboloIV()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("IV");
            Assert.Equal(4, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroTrezeEsperado_DeveEntenderOSimboloXIII()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("XIII");
            Assert.Equal(13, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroVinteEOitoEsperado_DeveEntenderOSimboloXXVIII()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("XXVIII");
            Assert.Equal(28, numero);
        }

        [Fact]
        public void ConverteNumero_ValorInteiroTrintaEOitoEsperado_DeveEntenderOSimboloXXXVIII()
        {
            var numeroRomano = new ConversorDeNumeroRomano();
            int numero = numeroRomano.ConverteNumero("XXXVIII");
            Assert.Equal(38, numero);
        }
    }
}
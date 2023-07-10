namespace Dotnet.NumerosRomanos
{
    public class ConversorDeNumeroRomano
    {
        public int ConverteNumero(string numeroEmRomano) 
        {
            int acumulador = 0;
            int ultimoValorDaDireita = 0;

            for (int i = numeroEmRomano.Length - 1; i >= 0; i--) 
            {
                int valorAtual = tabelaDeNumerosRomanos[numeroEmRomano[i].ToString()];

                int multiplicador = 1;

                if (valorAtual < ultimoValorDaDireita) 
                {
                    multiplicador = -1;
                }

                acumulador += valorAtual * multiplicador;
                ultimoValorDaDireita = valorAtual;
            }

            return acumulador;
        }

        private static Dictionary<string, int> tabelaDeNumerosRomanos = new Dictionary<string, int>()
        {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };
    }
}

using Dotnet.NumerosRomanos;

Console.WriteLine("********** Conversor de Número Romano **********");

var numeroRomano = new ConversorDeNumeroRomano();
var valorRecebido = "XIII";

var resultado = numeroRomano.ConverteNumero(valorRecebido);

Console.WriteLine($"O valor {valorRecebido} foi convertido para o número: {resultado}");

Console.ReadLine();
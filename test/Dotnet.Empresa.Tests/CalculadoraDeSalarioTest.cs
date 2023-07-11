namespace Dotnet.Empresa.Tests
{
    public class CalculadoraDeSalarioTest
    {
        [Fact]
        public void CalculadoraDeSalario_DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            var calculadora = new CalculadoraDeSalario();
            var desenvolvedor = new Funcionario("Paulo", 1500.0, Cargo.DESENVOLVEDOR);

            var salario = calculadora.CalcularSalario(desenvolvedor);

            Assert.Equal(1500.0 * 0.9, salario, 0.00001);
        }

        [Fact]
        public void CalculadoraDeSalario_DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            var calculadora = new CalculadoraDeSalario();
            var desenvolvedor = new Funcionario("Paulo", 4000.0, Cargo.DESENVOLVEDOR);

            var salario = calculadora.CalcularSalario(desenvolvedor);

            Assert.Equal(4000.0 * 0.8, salario, 0.00001);
        }

        [Fact]
        public void CalculadoraDeSalario_DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            var calculadora = new CalculadoraDeSalario();
            var dba = new Funcionario("Paulo", 500.0, Cargo.DBA);

            var salario = calculadora.CalcularSalario(dba);

            Assert.Equal(500.0 * 0.85, salario, 0.00001);
        }
    }
}
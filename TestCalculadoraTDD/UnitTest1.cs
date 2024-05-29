namespace CalculadoraTDD;

public class UnitTest1
{
    private readonly Calculadora calc;

    public UnitTest1()
    {
        calc = new Calculadora();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 4, 7)]
    public void TesteSomar(int val1, int val2, int esperado)
    {
        int resultado = calc.Somar(val1, val2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(3, 4, -1)]
    public void TesteSubtrair(int val1, int val2, int esperado)
    {
        int resultado = calc.Subtrair(val1, val2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(3, 4, 12)]
    public void TesteMultiplicar(int val1, int val2, int esperado)
    {
        int resultado = calc.Multiplicar(val1, val2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(3, 3, 1)]
    public void TesteDividir(int val1, int val2, int esperado)
    {
        int resultado = calc.Dividir(val1, val2);

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void TestarDividirPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        calc.Somar(2, 3);
        calc.Subtrair(5, 3);
        calc.Multiplicar(2, 7);
        calc.Dividir(36, 12);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
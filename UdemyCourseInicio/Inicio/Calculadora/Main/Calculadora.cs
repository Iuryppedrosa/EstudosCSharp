namespace UdemyCourseInicio.Inicio;

public class Calculadora : ICalculadoraAvancada
{
    public double Seno(double angulo)
    {
        return Math.Sin(angulo);
    }

    public double Cosseno(double angulo)
    {
        return Math.Cos(angulo);
    }
    public double ExecutarOperacao(Operacao operacao, double a, double b)
    {
        return operacao.Calcular(a, b);
    }
}
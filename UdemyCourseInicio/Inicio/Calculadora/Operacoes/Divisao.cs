namespace UdemyCourseInicio.Inicio;

public class Divisao : Operacao
{
    public override double Calcular(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Nao é possível dividir por zero");
        }

        return a / b;
    }
}
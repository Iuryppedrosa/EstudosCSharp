namespace UdemyCourseInicio.Inicio;

public class MainCalc
{
    public void Calcular()
    {
        Calculadora calculadora = new Calculadora();

    while (true)
    {
        try
        {
            Console.WriteLine("Se deseja entrar na calculadora avancada:");
            Console.WriteLine("1. Entrar");
            Console.WriteLine("2. Sair");

            int escolha1 = int.Parse(Console.ReadLine());
            if (escolha1 == 2)
                break;
            
            Console.WriteLine("Digite o Seno:");
            double angulo1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Cosseno:");
            double angulo2 = double.Parse(Console.ReadLine());

            double resultadoSeno = calculadora.Seno(angulo1);
            double resultadoCosseno = calculadora.Cosseno(angulo2);
            
            Console.WriteLine($"Seno de {angulo1} graus: {resultadoSeno}");
            Console.WriteLine($"Cosseno de {angulo2} graus: {resultadoCosseno}");
            

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
    while (true)
    {
        try
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");

            int escolha = int.Parse(Console.ReadLine());
        
            if(escolha == 5)
                break;
        
            Console.WriteLine("Digite o primeiro numero: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double b = double.Parse(Console.ReadLine());

            Operacao operacao = escolha switch
            {
                1 => new Adicao(),
                2 => new Subtracao(),
                3 => new Multiplicacao(),
                4 => new Divisao(),
                _ => throw new InvalidOperationException("Operação inválida")
            };

            double resultado = calculadora.ExecutarOperacao(operacao, a, b);
            Console.WriteLine($"O resultado é: {resultado}");

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        Console.WriteLine();
    }
        
    }
    
}
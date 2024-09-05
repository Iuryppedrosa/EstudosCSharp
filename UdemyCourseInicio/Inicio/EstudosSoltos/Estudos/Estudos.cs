using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseInicio.Inicio.EstudosSoltos.Estudos
{
    public class Estudos
    {
        public void Formatar()
        {
            string nome = "João";
            string nome2 = "Maria";
            int idade = 20;
            int idade2 = 30;

            // Placeholders
            Console.WriteLine("Primeira pessoa {0}, Idade: {1} \nSegunda pessoa {2}, Idade: {3}", nome, idade, nome2, idade2);

            // Interpolação
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");

            // Concatenação
            Console.WriteLine("Nome: " + nome + ", Idade: " + idade);

            // Todos os scapes do c# do tipo, \a, \b, \n, \r, \t, \v, \\, \', \", \?, \0, \xhh
            // \n = Quebra de linha
            // \t = Tabulação
            // \v = Tabulação vertical
            // \r = Retorno de carro
            // \a = Alerta
            // \b = Retrocesso
            // \0 = Caractere nulo
            // \xhh = Caractere hexadecimal
            // \\ = Barra invertida
            // \' = Aspas simples
            // \" = Aspas duplas
            // \? = Ponto de interrogação
            // \u = Caractere Unicode
            // \U = Caractere Unicode
            Console.WriteLine(idade + "\n" + idade2);
            Console.WriteLine(idade + "\t" + idade2);
        }
        public void ConversaoDeTipos()
        {
            //Conversao IMPLICITA, ocorre quando o compilador a executa sozinho quando compotível
            // byte -> short -> int -> long -> float -> double -> decimal
            //
            var varInt = 100;
            double varDouble = varInt;
            Console.WriteLine(varDouble);

            int numeroInt = 214578;
            long numeroLong = numeroInt;
            float numeroFloat = numeroInt;
            double numeroDouble = numeroInt;
            decimal numeroDecimal = numeroInt;
            Console.WriteLine(numeroInt);
            Console.WriteLine(numeroLong);
            Console.WriteLine(numeroFloat);
            Console.WriteLine(numeroDouble);
            Console.WriteLine(numeroDecimal);

            double varDouble3 = 12.456;
            //int varInt2 = varDouble3;
            int varInt2 = (int)varDouble3;
            Console.WriteLine(varInt2);

            int numero1 = 10;
            int numero2 = 3;

            //float resultado = numero1 / numero2;
            float resultado = (float)numero1 / numero2;
            Console.WriteLine(resultado);
            // resultado = 3 ou 3.33
        }
        public void ConversaoDeTiposString()
        {
            string texto = "123";
            int numero = int.Parse(texto);
            Console.WriteLine(numero);

            string texto2 = "123.45";
            double numero2 = double.Parse(texto2);
            Console.WriteLine(numero2);

            string texto3 = "true";
            bool booleano = bool.Parse(texto3);
            bool booleano3 = Convert.ToBoolean(texto3);
            Console.WriteLine(texto3);
            Console.WriteLine(booleano);
            Console.WriteLine(booleano3);

            int numero3 = 123;
            string texto4 = numero3.ToString();
            string numero3String = Convert.ToString(numero3);
            double numero3Double = Convert.ToDouble(numero3) / 100;   
            Console.WriteLine(texto4);
            Console.WriteLine(numero3String);
            Console.WriteLine(numero3Double);

            double numero4 = 123.45;
            string texto5 = numero4.ToString();
            Console.WriteLine(texto5);

            bool booleano2 = true;
            string texto6 = booleano2.ToString();
            Console.WriteLine(texto6);
        }
        public void EntradaDeDados()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu estado civil: ");
            char estadoCivil = char.Parse(Console.ReadLine());

            Console.WriteLine("Pegando o codigo ASCII da tecla digitada");
            var dadoInformado = Console.ReadKey();

            Console.WriteLine("TesteCommit");

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);
            Console.WriteLine("Estado Civil: " + estadoCivil);
            Console.WriteLine($"Tecla digitada: {dadoInformado.KeyChar}");
        }
        public void EstudandoVariaveis()
        {
            var idade = 20;
            var nome = "João";
            var salario = 1000.50;

            // "c" é para formatar para moeda
            Console.WriteLine($"{nome} tem {idade} anos e recebe {salario.ToString("c")} reais");

            // limitacoes de VAR
            // var numero; // Não é possível declarar uma variável sem atribuir um valor
            // var numero = null; // Não é possível atribuir null a uma variável var
            // var numero = 10; // Não é possível atribuir um valor de um tipo a uma variável var e depois atribuir um valor de outro tipo
            // numero = "teste"; // Não é possível atribuir um valor de um tipo a uma variável var e depois atribuir um valor de outro tipo


            var teste = new MetodoTeste();
            teste.Teste();


        }
        public void EstudosDeConstantes()
        {
            const int ANO = 2022;
            const string NOME = "João";
            const int MES = 6, SEMANA = 4, DIA = 30;

            const int MESES_ANO = 12;
            const int DIAS_SEMANA = 7;

            const float DIAS_POR_MES = (float)DIA / (float)MESES_ANO;
            Console.WriteLine(DIAS_POR_MES);
        }

      

    }
    public class MetodoTeste
    {
        public void Teste()
        {
            Console.WriteLine("Teste");
        }
    }

}

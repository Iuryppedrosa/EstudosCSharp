using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseInicio.Inicio.POO.Models
{
    class Pessoa
    {
        public string? nome;
        public int idade;
        public double altura;
        public string? sexo;

    }

    class Celular
    {
        public string? Modelo;
        public string? Marca;

        // o static faz com que o atributo seja compartilhado por todos os objetos da classe
        public static int Preco;

        public Celular()
        {
           
        }

        static Celular()
        {
            Preco = 1000;
        }

        public void ExibindoCelular(string modelo, string marca, int preco)
        {
            Console.WriteLine("Qual o modelo do seu celular?");
            modelo = Console.ReadLine();

            Console.WriteLine("Qual o modelo do seu celular?");
            marca = Console.ReadLine();

            Console.WriteLine($"O seu modelo é {modelo} e marca {marca} e tem o preco de {preco}");
        }
    }

    class Carro
    {
        public string? marca;
        public string? modelo;
        public int ano;
        public string? cor;
    }

    class Aluno
    {
        public string? Nome;
        public int Idade;
        public double Altura;
        public string? Sexo;
        public string? Aprovado;

        public Aluno(string nome)
        {
            Nome = nome;

        }

        public Aluno(string nome, int idade, double altura, string sexo, string aprovado) : this(nome)
        {
            Idade = idade;
            Altura = altura;
            Sexo = sexo;
            Aprovado = aprovado;
        }
    }

    public class Cliente
    {
        public string? Nome;
        public int Idade;
        public double Altura;
        public string? Sexo;
        public string? Cpf;

        public Cliente(string Nome)
        {
            this.Nome = Nome;
        }

        public Cliente(string Nome, int Idade, double Altura, string Sexo, string Cpf) : this(Nome)
        {
            this.Idade = Idade;
            this.Altura = Altura;
            this.Sexo = Sexo;
            this.Cpf = Cpf;
        }

        public void ExibindoComThis(Cliente cl)
        {
            Console.WriteLine("Nome2: " + cl.Nome);
            Console.WriteLine("Idade2: " + cl.Idade);
            Console.WriteLine("Altura2: " + cl.Altura);
            Console.WriteLine("Sexo2: " + cl.Sexo);
            Console.WriteLine("Cpf2: " + cl.Cpf);
        }
        public void Exibindo()
        {
            ExibindoComThis(this);
        }
    }

    public class Funcionario
    {
        public string? Idade;
        public string Nome;
        public string Cargo;

        public Funcionario(string? idade, string nome, string cargo)
        {
            Idade = idade;
            Nome = nome;
            Cargo = cargo;
        }

        public Funcionario()
        {

        }
    }

    public class Cadastro
    {
        public Funcionario Registrar()
        {
            Funcionario funcionario = new Funcionario("20", "Maria", "Analista");
            return funcionario;
        }

        public Funcionario Registrar(Funcionario func)
        {
            func.Cargo = "Gerente";
            return func;
        }

        public void ExibirDados(Funcionario func)
        {
            Console.WriteLine("----------*----------");
            Console.WriteLine("Nome: " + func.Nome);
            Console.WriteLine("Idade: " + func.Idade);
            Console.WriteLine("Cargo: " + func.Cargo);
        }

        public void ExibirDados(Funcionario func, string texto)
        {
            Console.Write($"----*----\n{texto}\n");
            Console.WriteLine("Nome: " + func.Nome);
            Console.WriteLine("Cargo: " + func.Cargo + "\n------*-------");
        }
    }

    public class CalculoExemploPassagemDeArgumentosPorValorEPorFeferencia
    {
        public void Dobrar(int y)
        {
            y *= 2;
            Console.WriteLine("Valor do parametro Y no metodo dobrar: " + y);
        }

        public void Dobrar(ref int y)
        {
            y *= 2;
            Console.WriteLine("Valor do parametro Y no metodo dobrar: " + y);
        }
    }

    public class MetodoParaTestarRefOUT
    {
        public double CalcularAreaPerimetro(double raio, out double area)
        {
            area = Math.PI * Math.Pow(raio, 2);
            double perimetro = 2 * Math.PI * raio;
            return perimetro;
        }
    }

    public class ClassParaTestarMetodoStatic
    {

        public static void MetodoStatic()
        {
            Console.WriteLine("Metodo Static");
        }
    }

    public class ContaCorrente
    {
        public int Conta;
        public string? Nome;
        public static float Juros;

        public float JurosAnual()
        {
            return Juros * 12;
        }
    }

}

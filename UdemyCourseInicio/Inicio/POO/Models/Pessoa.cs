using System;
using System.Collections.Generic;
using System.Linq;
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
}

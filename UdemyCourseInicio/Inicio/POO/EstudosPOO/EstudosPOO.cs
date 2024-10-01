using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCourseInicio.Inicio.POO.Models;

namespace UdemyCourseInicio.Inicio.POO.EstudosPOO
{
    class EstudosPOO
    {
        // se nao houver um construtor, o C# cria um construtor vazio
        // se omitir a palavra public, o C# entende que é privado
        public void CriandoPessoa()
        {

            Pessoa pessoa = new Pessoa();
            pessoa.nome = "João";
            pessoa.idade = 25;
            pessoa.altura = 1.80;
            pessoa.sexo = "Masculino";

            var carro = CriandoCarro();

            Console.WriteLine("Nome: " + pessoa.nome);
            Console.WriteLine("Idade: " + pessoa.idade);
            Console.WriteLine("Altura: " + pessoa.altura);
            Console.WriteLine("Sexo: " + pessoa.sexo);
            Console.WriteLine("Multiplicador de idade: " + MultiplicadorDeIdade(2, pessoa.idade));
            DonoDoCarro(carro, pessoa);
        }

        public Carro CriandoCarro()
        {
            Carro carro = new()
            {
                marca = "Fiat",
                modelo = "Uno",
                ano = 2022,
                cor = "Vermelho"
            };

            Console.WriteLine("Marca: " + carro.marca);
            Console.WriteLine("Modelo: " + carro.modelo);
            Console.WriteLine("Ano: " + carro.ano);
            Console.WriteLine("Cor: " + carro.cor);
            return carro;
        }

        public int MultiplicadorDeIdade(int multiplicador, int idade)
        {
            return idade * multiplicador;
        }

        public void DonoDoCarro(Carro carro, Pessoa pessoa)
        {
            Console.WriteLine($"A pessoa {pessoa.nome} tem o carro {carro.modelo}");

        }

        public Aluno criandoAluno()
        {
            Aluno aluno = new Aluno("Maria", 20, 1.70, "Feminino", "Aprovado");
            Console.WriteLine("-------Exibindo Aluno -------------");
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Idade: " + aluno.Idade);
            Console.WriteLine("Altura: " + aluno.Altura);
            Console.WriteLine("Sexo: " + aluno.Sexo);
            Console.WriteLine("Aprovado: " + aluno.Aprovado);
            return aluno;
        }

        public void CriandoAluno2()
        {
            Aluno aluno2 = new("Josefa");
            Console.WriteLine("-------Exibindo Aluno 2-------------");
            Console.WriteLine("Nome: " + aluno2.Nome);
            if (aluno2.Idade == 0)
            {
                Console.WriteLine("Idade não informada");
            }
            if (aluno2.Altura == 0)
            {
                Console.WriteLine("Altura não informada");
            }
            if (aluno2.Sexo == null)
            {
                Console.WriteLine("Sexo não informado");
            }
            if (aluno2.Aprovado == null)
            {
                Console.WriteLine("Aprovado não informado");
            }
        }

        public void CriandoCliente()
        {
            Cliente cl = new Cliente("Maria", 20, 1.70, "Feminino", "123.456.789-00");
            Console.WriteLine("-------Exibindo Cliente -------------");
            Console.WriteLine($"Nome: {cl.Nome}\nIdade: {cl.Idade}\nAltura: {cl.Altura}\nSexo: {cl.Sexo}\nCpf: {cl.Cpf}");

            Cliente cl2 = new Cliente("Josefa", 25, 1.80, "Feminino", "987.654.321-00");
            Console.WriteLine("-------Exibindo Cliente 2-------------");
            cl2.Exibindo();
        }

    }
}


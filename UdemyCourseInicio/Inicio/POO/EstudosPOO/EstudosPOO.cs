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



    }
}


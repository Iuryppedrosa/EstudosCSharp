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

        public int MetodoComRetorno(int a, int b)
        {
            Console.WriteLine($"---------*----------\nResultado: {a + b}");
            return a + b;
        }

        public void ExemploPratico()
        {
            Cadastro cadastro = new Cadastro();
            Funcionario func = cadastro.Registrar();
            cadastro.ExibirDados(func);

            var novoCargo = cadastro.Registrar(func);
            cadastro.ExibirDados(novoCargo, "Cargo Alterado: ");
        }

        public void TestandoPassagemDeArgumentosPorREFeValor()
        {
            int x = 20;
            Console.WriteLine("Valor de x antes de passar por dobrar: " + x);
            CalculoExemploPassagemDeArgumentosPorValorEPorFeferencia calc = new CalculoExemploPassagemDeArgumentosPorValorEPorFeferencia();
            calc.Dobrar(x);
            Console.WriteLine("Valor de x depois de passar por dobrar: " + x);

            int z = 20;
            Console.WriteLine("Valor de Z antes de passar por dobrar: " + z);
            CalculoExemploPassagemDeArgumentosPorValorEPorFeferencia calc2 = new CalculoExemploPassagemDeArgumentosPorValorEPorFeferencia();
            // ref é uma palavra reservada que indica que o argumento é passado por referência e será usado
            // pois é passado a referencia para o lugar de memoria onde a variavel está armazenada
            // passa-se a copia do endereço de memoria
            calc.Dobrar(ref z);
            Console.WriteLine("Valor de Z depois de passar por dobrar: " + z);

            Console.WriteLine("---------*---------");
            Console.WriteLine("Passagem de argumentos por referencia com OUT (retorna 2 valores): ");
            MetodoParaTestarRefOUT metodoParaTestarRefOUT = new MetodoParaTestarRefOUT();
            Console.WriteLine("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double perimetro = metodoParaTestarRefOUT.CalcularAreaPerimetro(raio, out double area);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimetro: " + perimetro);

        }

        public void TestandoMetodoStatic()
        {
            // não é necessário instanciar a classe para chamar o método
            ClassParaTestarMetodoStatic.MetodoStatic();

        }

        public unsafe void CamposStatic()
        {
            Celular celular = new Celular();
            //int preco = Celular.Preco = 2000;
            //celular.ExibindoCelular(celular.Marca, celular.Modelo, Celular.Preco = 2000);
            celular.ExibindoCelular(celular.Marca, celular.Modelo, Celular.Preco);
            fixed (char* ptrMarca = celular.Marca, ptrModelo = celular.Modelo)
            {
                Console.WriteLine($"Endereço de memória da Marca: {(long)ptrMarca:X}");
                Console.WriteLine($"Endereço de memória da Modelo: {(long)ptrModelo:X}");
            }

            fixed (int* ptrPreco = &Celular.Preco)
            {
                Console.WriteLine($"Endereço de memória do Preço: {(long)ptrPreco:X}");
            }
        }

        public void CriandoConta()
        {
            // compartilha o campo com todas as instancias da classe.
            ContaCorrente.Juros = 0.05f;
            ContaCorrente c1 = new ContaCorrente();
            c1.Conta = 1234;
            c1.Nome = "Maria";
            // campo static -> c1.Juros = 0.05f;

            ContaCorrente c2 = new ContaCorrente();
            c2.Conta = 5678;
            c2.Nome = "Josefa";
            //campo static -> c2.Juros = 0.10f;

            Console.WriteLine($"Cliente: {c1.Nome} - Juros Anual: {c1.JurosAnual()}");
            Console.WriteLine($"Cliente: {c2.Nome} - Juros Anual: {c2.JurosAnual()}");
        }
    }
}


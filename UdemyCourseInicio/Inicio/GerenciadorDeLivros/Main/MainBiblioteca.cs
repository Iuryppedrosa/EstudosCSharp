using System.Xml;

namespace UdemyCourseInicio.Inicio.GerenciadorDeLivros;

public class MainBiblioteca
{
    public void MainProgramBiblio()
    {
        Biblioteca biblioteca = new Biblioteca();
        bool sair = false;
        
        while (!sair)
        {
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Listar Livros");
            Console.WriteLine("3. Procurar Livro");
            Console.WriteLine("4. Emprestar Livro");
            Console.WriteLine("5. Devolver Livro");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o título: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Digite o autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Digite a data de publicação (dd/MM/yyyy): ");
                    DateTime dataPublicacao = DateTime.Parse(Console.ReadLine());
                    Console.Write("O livro é ficção? (s/n): ");
                    char tipo = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    Livro novoLivro = tipo == 's'
                        ? new LivroFiccao(titulo, autor, dataPublicacao)
                        : (Livro)new LivroNaoFiccao(titulo, autor, dataPublicacao);
                    
                    biblioteca.AdicionarLivro(novoLivro);
                    break;
                case 2:
                    biblioteca.ListarLivros();
                    break;
                case 3:
                    Console.WriteLine("Digite o titulo do Livro: ");
                    string tituloProcurar = Console.ReadLine();
                    biblioteca.ProcurarLivro(tituloProcurar);
                    break;
                case 4:
                    Console.WriteLine("Digite o titulo do Livro: ");
                    string tituloEmprestar = Console.ReadLine();
                    biblioteca.EmprestarLivro(tituloEmprestar);
                    break;
                case 5:
                    Console.WriteLine("Digite o titulo do livro: ");
                    string tituloDevolver = Console.ReadLine();
                    biblioteca.DevolverLivro(tituloDevolver);
                    break;
                case 6:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opcao inválida");
                    break;
                
            }
        }
        
    }
    
}
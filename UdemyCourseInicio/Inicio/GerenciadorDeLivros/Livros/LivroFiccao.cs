namespace UdemyCourseInicio.Inicio.GerenciadorDeLivros;

public class LivroFiccao : Livro
{
    public LivroFiccao(string titulo, string autor, DateTime dataPublicacao)
        : base(titulo, autor, dataPublicacao){}

    public override void ExibirInfo()
    {
        Console.WriteLine($"Ficcao: {Titulo} por {Autor} publicado em {DataPublicacao.ToShortDateString()}");
    }
}
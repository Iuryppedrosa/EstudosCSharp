namespace UdemyCourseInicio.Inicio.GerenciadorDeLivros;

public class LivroNaoFiccao : Livro
{
    public LivroNaoFiccao(string titulo, string autor, DateTime dataPublicacao)
        : base(titulo, autor, dataPublicacao){}

    public override void ExibirInfo()
    {
        Console.WriteLine($"Nao-Ficcao: {Titulo} por {Autor} publicado em {DataPublicacao.ToShortDateString()}");
    }
}
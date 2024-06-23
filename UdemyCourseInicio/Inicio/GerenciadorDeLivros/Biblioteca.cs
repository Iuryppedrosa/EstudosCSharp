namespace UdemyCourseInicio.Inicio.GerenciadorDeLivros;

public class Biblioteca
{
    private List<Livro> livros;

    public Biblioteca()
    {
        livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ListarLivros()
    {
        foreach (var livro in livros)
        {
            livro.ExibirInfo();
            Console.WriteLine(livro.Emprestado ? "Emprestado" : "Disponível");
            
        }
    }

    public void ProcurarLivro(string titulo)
    {
        var livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if(livro != null)
        {
            livro.ExibirInfo();
            Console.WriteLine(livro.Emprestado ? "Emprestado" : "Disponível");
        }
        else
        {
            Console.WriteLine("Livro nao encontrado");
        }
    }

    public void DevolverLivro(string titulo)
    {
        var livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null && livro.Emprestado)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("Livro nao encontrado ou nao foi emprestado");
        }
    }

    public void EmprestarLivro(string titulo)
    {
        var livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (livro != null && !livro.Emprestado)
        {
            livro.Emprestar();
            Console.WriteLine("Livro emprestado com sucesso");
        }
        else
        {
            Console.WriteLine("Livro nao encontrado ou já emprestado.");
        }
    }
}
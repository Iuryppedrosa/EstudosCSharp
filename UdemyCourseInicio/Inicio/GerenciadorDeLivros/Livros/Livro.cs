
namespace UdemyCourseInicio.Inicio.GerenciadorDeLivros
{
    public abstract class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime DataPublicacao { get; set; }
        public bool Emprestado { get; set; }
        public DateTime? DataEmprestimo { get; set; }
        
        
        public Livro(string titulo, string autor, DateTime dataPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            DataPublicacao = dataPublicacao;
            Emprestado = false;
            DataEmprestimo = null;
        }

        public void Emprestar()
        {
            Emprestado = true;
            DataEmprestimo = DateTime.Now;
        }

        public void Devolver()
        {
            Emprestado = false;
            DataEmprestimo = null;
        }

        public abstract void ExibirInfo();
    }
}


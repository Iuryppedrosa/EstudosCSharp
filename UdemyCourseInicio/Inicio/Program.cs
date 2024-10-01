using UdemyCourseInicio.Inicio;
using UdemyCourseInicio.Inicio.EstudosSoltos.Estudos;
using UdemyCourseInicio.Inicio.GerenciadorDeLivros;
using UdemyCourseInicio.Inicio.POO;
using UdemyCourseInicio.Inicio.POO.EstudosPOO;

class Program
{
    static void Main(string[] args)
    {
        MainCalc maincalc = new MainCalc();
        MainBiblioteca mainbiblioteca = new MainBiblioteca();
        Estudos estudos = new Estudos();
        EstudosPOO estudosPOO = new EstudosPOO();
        

        if (args.Length > 0 && args[0] == "Calculadora")
        {
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);
            
            // DateTime data = new DateTime(2022, 06, 06);
            // DateTime dataEhr = new DateTime(2022, 06, 06, 22, 10, 30);
            // Console.WriteLine(dataEhr);
            // Console.WriteLine(data);
            //
            // Console.WriteLine(dataAtual.Year);
            // Console.WriteLine(dataAtual.Month);
            // Console.WriteLine(dataAtual.Day);
            // Console.WriteLine(dataAtual.Hour);
            // Console.WriteLine(dataAtual.Minute);
            // Console.WriteLine(dataAtual.DayOfWeek);
            // Console.WriteLine(dataAtual.DayOfYear);
            // Console.WriteLine(data.AddDays(30));
            maincalc.Calcular();
        }

        else if(args.Length > 0 && args[0] == "Livraria")
        {
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);
            mainbiblioteca.MainProgramBiblio();
            
        }
        else if(args.Length > 0 && args[0] == "EstudosSoltos")
        {
            Console.WriteLine("Iniciando parte de estudos soltos");
            //formatarSaidaConsole.Formatar();
            //estudos.ConversaoDeTipos();
            //estudos.ConversaoDeTiposString();
            //estudos.EntradaDeDados();
            //estudos.EstudandoVariaveis();
            //estudos.EstudosDeConstantes();

            estudos.EstudosGerais();


        }
        else if (args.Length > 0 && args[0] == "POO")
        {
            Console.WriteLine("Iniciando parte de estudos POO");
            estudosPOO.CriandoPessoa();
            estudosPOO.CriandoCarro();
            estudosPOO.criandoAluno();
            estudosPOO.CriandoAluno2();
            estudosPOO.CriandoCliente();


        }
        Console.ReadLine();
    }
}



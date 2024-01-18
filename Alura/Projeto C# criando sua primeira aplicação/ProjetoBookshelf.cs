
internal class Program
{
    private static void Main(string[] args)
    {
        ExecutarOpcoes(Opcoes());

    }

    public static Dictionary<string, List<double>> livros = new Dictionary<string, List<double>>()
    {
        {"Fundação", new List<double>() {10, 4, 9}},
        {"Neuromancer", new List<double>()}
    }; 
    


    public static void Apresentacao()
    {
        Console.WriteLine(@"
            ██████╗░░█████╗░░█████╗░██╗░░██╗░██████╗██╗░░██╗███████╗██╗░░░░░███████╗
            ██╔══██╗██╔══██╗██╔══██╗██║░██╔╝██╔════╝██║░░██║██╔════╝██║░░░░░██╔════╝
            ██████╦╝██║░░██║██║░░██║█████═╝░╚█████╗░███████║█████╗░░██║░░░░░█████╗░░
            ██╔══██╗██║░░██║██║░░██║██╔═██╗░░╚═══██╗██╔══██║██╔══╝░░██║░░░░░██╔══╝░░
            ██████╦╝╚█████╔╝╚█████╔╝██║░╚██╗██████╔╝██║░░██║███████╗███████╗██║░░░░░
            ╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░░░░");
        Console.WriteLine("Bem vindo ao Bookshelf!\n");
    }
    public static int Opcoes()
    {
        Apresentacao();
        Console.WriteLine("Digite 1 para registrar um livro.");
        Console.WriteLine("Digite 2 para mostrar todos os livros.");
        Console.WriteLine("Digite 3 para avaliar um livro.");
        Console.WriteLine("Digite 4 para exibir a média de um livro.");
        Console.WriteLine("Digite -1 para sair.\n");

        Console.Write("Digite a sua opção: ");
        int opcao = int.Parse(Console.ReadLine()!);
        Console.Clear();
        return opcao;
    }
    public static void ExecutarOpcoes(int opcao)
    {
        switch (opcao)
        {
            case -1:
                Console.WriteLine("Obrigado por usar nossa plataforma :)");
                break;

            case 1: RegistarLivro();
                break;

            case 2: ExibirLivrosRegistrados();
                break;

            case 3: AvaliarLivro();
                break;

            case 4: GetMediaLivro();
                break;
        }
    }

    public static void RegistarLivro()
    {
        Console.WriteLine("Registro de bandas");
        Console.Write("Digite o nome do livro que deseja registrar: ");
        string nomeLivro = Console.ReadLine()!;
        livros.Add(nomeLivro, new List<double>());
        Console.WriteLine($"O livro \"{nomeLivro}\" foi registrado.");
        
        Thread.Sleep(1000);
        Console.Clear();

        ExecutarOpcoes(Opcoes());
    }

    public static void ExibirLivrosRegistrados()
    {
        Console.WriteLine("Livros registrados: ");
        foreach(string livro in livros.Keys)
        {
            Console.WriteLine($"Livro: {livro}");
        }

        Console.WriteLine("\nPressione uma tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();

        ExecutarOpcoes(Opcoes());

    }

    public static void AvaliarLivro()
    {
        Console.Write("Informe o nome do livro que deseja avaliar: ");
        string livro = Console.ReadLine()!;
        
        if(livros.ContainsKey(livro))
        {
            Console.Write("Informe a nota da avaliação: ");
            double nota = double.Parse(Console.ReadLine()!);
            livros[livro].Add(nota);
            Console.WriteLine($"Nota {nota} atribuida ao livro\"{livro}\".");
            Thread.Sleep(1000);
        } else
        {
            Console.WriteLine($"O livro: \"{livro}\" não existe.");
        }


        Console.WriteLine("\nPressione uma tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExecutarOpcoes(Opcoes());

    }

    public static void GetMediaLivro()
    {
        Console.Write("Informe o nome do livro que deseja ver a média das avaliações: ");
        string nomeLivro = Console.ReadLine()!;

        if(livros.ContainsKey(nomeLivro)) {

            Console.WriteLine($"A média das avaliações do livro: \"{nomeLivro}\" é: {livros[nomeLivro].Sum() / livros[nomeLivro].Count}");
        } else
        {
            Console.WriteLine($"O livro: \"{nomeLivro}\" não existe.");
        }

        Console.WriteLine("\nPressione uma tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExecutarOpcoes(Opcoes());
    }
}
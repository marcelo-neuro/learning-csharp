namespace ProjetoMusica.classes;

public class Podcast 
{
    public string Nome {  get;}
    public string Host { get;}
    public int TotEpisodios => episodios.Count;
    private List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }


    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} - {Host}");
        
        foreach(Episodio episodio in episodios.OrderBy(n => n.Numero))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Total de episódios: {TotEpisodios}");
    }
}
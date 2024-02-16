namespace ProjetoMusica.classes;
public class Album
{
    public String Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome, List<Musica> musicas)
    {
        Nome = nome;
        this.musicas = musicas;
    }

    public void AdicionarMusica(Musica musica)
    {
        this.musicas.Add(musica);
    }

    public void RemoverMusica(Musica musica)
    {
        this.musicas.Remove(musica);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"Album: {Nome}");
        foreach(Musica musica in this.musicas)
        {
            Console.WriteLine($"\t{musica.Nome} - {musica.Artista.Nome}");
        }
        Console.WriteLine($"Duração total: {DuracaoTotal} minutos.");

    }
}
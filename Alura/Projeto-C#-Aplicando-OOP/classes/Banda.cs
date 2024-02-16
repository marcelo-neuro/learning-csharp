namespace ProjetoMusica.classes;

public class Banda
{
    public string Nome {  get; set; }
    private List<Album> Albums = new List<Album>();

    public Banda(string nome, Album album)
    {
        Nome = nome;
        Albums.Add(album);
    }

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        this.Albums.Add(album);
    }

    public void RemoverAlbum(Album album)
    {
        this.Albums.Remove(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {Nome}");
        foreach(Album album in this.Albums)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}


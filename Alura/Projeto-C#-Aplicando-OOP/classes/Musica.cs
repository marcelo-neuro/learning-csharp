namespace ProjetoMusica.classes;

public class Musica
{
    public string Nome {  get; set; }
    public Banda Artista {  get; }
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida { get => $"{Nome} - {Artista.Nome}"; }

    public Musica(string nome, Banda artista, int duracao, bool disponivel) 
    {
        Nome = nome;
        Artista = artista;
        Duracao = duracao;
        Disponivel = disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Autor: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponível no plano: {(Disponivel ? "sim" : "não")}");
        Console.WriteLine($"Descição Resumida: {DescricaoResumida}");
    }

    
}


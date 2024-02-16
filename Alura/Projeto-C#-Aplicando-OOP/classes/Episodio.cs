namespace ProjetoMusica.classes;

public class Episodio
{
    public string Titulo { get; }
    public string Resumo => $"{Numero}: {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    public int Numero { get;  }
    public int Duracao { get; }
    private List<string> convidados = new();


    public Episodio(string titulo, int numero, int duracao)
    {
        Titulo = titulo;
        Numero = numero;
        Duracao = duracao;
    }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }

    public void RemoverConvidado(string convidado)
    {
        convidados.Remove(convidado);
    }
}

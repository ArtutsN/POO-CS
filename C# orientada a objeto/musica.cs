class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public String DescricaoResumida => $"A musica {Nome} pertence à banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"nome: {Nome}");
        Console.WriteLine($"artista: {Artista.Nome}");
        Console.WriteLine($"duração: {Duracao}");
        if (Disponivel)
        {
            System.Console.WriteLine("disponivel no plano.");
        }
        else
        {
            System.Console.WriteLine("Adquira o plano plus+");
        }
    }

    public void NomeEArtista()
    {
        System.Console.WriteLine($"Nome: {Nome}, artista: {Artista}");
    }
}

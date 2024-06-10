using System.Text.Json;

namespace ScreenSoundAPI.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> MusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        MusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        MusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Músicas favoritas do {Nome}");
        foreach (var musica in MusicasFavoritas)
        {
            Console.WriteLine($"Música {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = MusicasFavoritas
            }
        );
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine("Arquivo Json criado com sucesso!");
        Console.WriteLine(Path.GetFullPath(nomeDoArquivo));
    }
}

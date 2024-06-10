using ScreenSoundAPI.Modelos;
using System.Text.Json;
using ScreenSoundAPI.Filtros;
using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFiltro.FiltrarTodosOsGeneros(musicas);
        //LinqFiltro.ExibirArtistasOrdenados(musicas);
        //LinqFiltro.FiltrarArtistasPorGenero(musicas, "pop");
        LinqFiltro.FiltrarMusicasPorArtista(musicas, "U2");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ops, algo deu errado! {ex.Message}");
    }
}
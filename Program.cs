using ScreenSoundAPI.Modelos;
using System.Text.Json;
using ScreenSoundAPI.Filtros;
using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFiltro.FiltrarTodosOsGeneros(musicas);
        //LinqFiltro.ExibirArtistasOrdenados(musicas);
        //LinqFiltro.FiltrarArtistasPorGenero(musicas, "pop");
        //LinqFiltro.FiltrarMusicasPorArtista(musicas, "U2");
        LinqFiltro.FiltrarMusicasPorTonalidade(musicas, 1);

        //var musicasDoJoao = new MusicasPreferidas("João");
        //musicasDoJoao.AdicionarMusicasFavoritas(musicas[1]);
        //musicasDoJoao.AdicionarMusicasFavoritas(musicas[8]);
        //musicasDoJoao.AdicionarMusicasFavoritas(musicas[377]);
        //musicasDoJoao.AdicionarMusicasFavoritas(musicas[46]);
        //musicasDoJoao.AdicionarMusicasFavoritas(musicas[1560]);
        //musicasDoJoao.ExibirMusicasFavoritas();
        //musicasDoJoao.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ops, algo deu errado! {ex.Message}");
    }
}
using ScreenSoundAPI.Modelos;
using System.Linq;
using System.Net.NetworkInformation;

namespace ScreenSoundAPI.Filtros;

internal class LinqFiltro
{
    public static void FiltrarTodosOsGeneros(List<Musica> musicas)
    {
        var generos = musicas.Select(g => g.Genero).Distinct().ToList();
        foreach (var genero in generos)
        {
            Console.WriteLine(genero);
        }
    }

    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        var artistas = musicas.OrderBy(a => a.Artista).Select(a => a.Artista).Distinct().ToList();
        foreach (var artista in artistas)
        {
            Console.WriteLine(artista);
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistas = musicas.Where(m => m.Genero!.Contains(genero)).Select(a => a.Artista).Distinct().ToList();
        foreach(var artista in artistas)
        {
            Console.WriteLine(artista);
        }
    }
}

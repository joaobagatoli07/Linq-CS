﻿using ScreenSoundAPI.Modelos;
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

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(m => m.Artista!.Equals(artista)).Select(m => m.Nome).ToList();
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine(musica);
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, int tonalidade)
    {
        var musicasComTonalidade = musicas.Where(m => m.Key == tonalidade).Select(m => m.Nome).ToList();
        foreach (var musica in musicasComTonalidade)
        {
            Console.WriteLine(musica);
        }
    }
}

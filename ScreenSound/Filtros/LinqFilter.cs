﻿using ScreenSound.Model;


namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }

    }


    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista)
            .Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical >>>{genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }


    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($" - {musica.Nome}");
        }
    }


    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).Select(musica => musica.Nome).ToList();
        Console.WriteLine($"Exibindo musicas da tonalidade: {tonalidade}");
        foreach(var musica in musicasTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }

    }

}


using ScreenSound.Filtros;
using ScreenSound.Model;
using ScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        //var minhasMusicasPreferidas = new MusicasPreferidas("Lucas");
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[999]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[38]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[400]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[333]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[39]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[403]);
        //minhasMusicasPreferidas.ExibirMusicasFavoritas();
        //minhasMusicasPreferidas.GerarArquivoJson();
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C");


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    }
}
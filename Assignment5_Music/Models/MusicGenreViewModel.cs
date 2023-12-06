using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment5_Music.Models
{
    public class MusicGenreViewModel
    {
        public List<Music>? Musics { get; set; }
        public SelectList? Genres { get; set; }
        public string? MusicGenre { get; set; }
        public string? SearchString { get; set; }
        public SelectList? Performers { get; set; }
        public string? SelectedPerformer { get; set; }

    }
}

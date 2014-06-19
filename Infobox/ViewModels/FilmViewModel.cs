using System.Collections.Generic;
using Infobox.Models;

namespace Infobox.ViewModels
{
    public class FilmViewModel : Film
    {
        public FilmViewModel()
        {
            AvaliableGenres = new MySelectList();

            SelectedGenres = new List<Genre>();
        }

        public MySelectList AvaliableGenres { get; set; }
        
        public IEnumerable<Genre> SelectedGenres { get; set; }
    }
}
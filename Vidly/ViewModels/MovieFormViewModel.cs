using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public MovieImage MovieImage { get; set; }
        public Movie Movie { get; set; }
    }
}
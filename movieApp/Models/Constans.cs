using System;
using System.Collections.Generic;
using System.Text;

namespace movieApp.Models
{
    public static class Constans
    {
        public static string GetMoviesUri(string searchTerm)
        {
            return $"https://www.omdbapi.com/?apikey=e6c06d5b&s=avengers&page=1";
        }

    }
}

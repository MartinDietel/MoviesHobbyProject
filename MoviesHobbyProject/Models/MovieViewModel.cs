﻿using System.Collections.Generic;

namespace MoviesHobbyProject.Models
{
    public class MovieViewModel
    {
        public SavedMovies Movie { get; set; }
        public ICollection<GroupMembers> TeamList { get; set; }
        public ICollection<MovieFavorites> FavoritesCollection { get; set; }

        public int MemID { get; set; }
        public int MovID { get; set; }
        public int FavRating { get; set; }
    }
}

namespace TMDBMovieSearch.Models
{

    public class MovieDetails
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public int?[] genre_ids { get; set; }
        public int id { get; set; }
        public string overview { get; set; }
        public float popularity { get; set; }
        public string poster_path { get; set; }
        public string release_date { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
    }

}

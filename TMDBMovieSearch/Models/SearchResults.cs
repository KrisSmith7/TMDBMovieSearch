namespace TMDBMovieSearch.Models
{
    public class SearchResults
    {
        public int Page { get; set; }
        public MovieDetails[] Results { get; set; }
        public int Total_Pages { get; set; }
        public int total_results { get; set; }
    }

}

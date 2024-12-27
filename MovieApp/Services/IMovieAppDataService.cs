using MovieApp.Models.MovieAppData;

namespace MovieApp.MovieAppData
{
    public interface IMovieAppDataService
    {
        Task<List<NowPlayingType>> GetNowPlayingList();
        Task<List<MovieListType>> GetMovieListList();
        Task<List<TheatresType>> GetTheatresList();
        Task<List<ShowtimesType>> GetShowtimesList();
        Task<List<TheatresNearYouType>> GetTheatresNearYouList();
        Task<List<MyPurchasesType>> GetMyPurchasesList();
    }
}

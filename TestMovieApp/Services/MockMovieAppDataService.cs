using MovieApp.Models.MovieAppData;

namespace MovieApp.MovieAppData
{
    public class MockMovieAppDataService : IMovieAppDataService
    {
        public Task<List<NowPlayingType>> GetNowPlayingList()
        {
            return Task.FromResult<List<NowPlayingType>>(new());
        }

        public Task<List<MovieListType>> GetMovieListList()
        {
            return Task.FromResult<List<MovieListType>>(new());
        }

        public Task<List<TheatresType>> GetTheatresList()
        {
            return Task.FromResult<List<TheatresType>>(new());
        }

        public Task<List<ShowtimesType>> GetShowtimesList()
        {
            return Task.FromResult<List<ShowtimesType>>(new());
        }

        public Task<List<TheatresNearYouType>> GetTheatresNearYouList()
        {
            return Task.FromResult<List<TheatresNearYouType>>(new());
        }

        public Task<List<MyPurchasesType>> GetMyPurchasesList()
        {
            return Task.FromResult<List<MyPurchasesType>>(new());
        }
    }
}

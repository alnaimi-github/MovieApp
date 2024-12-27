using System.Net.Http.Json;
using MovieApp.Models.MovieAppData;

namespace MovieApp.MovieAppData
{
    public class MovieAppDataService: IMovieAppDataService
    {
        private readonly HttpClient _http;

        public MovieAppDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<NowPlayingType>> GetNowPlayingList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/15755be7-cee3-4b74-4382-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<NowPlayingType>>().ConfigureAwait(false);
            }

            return new List<NowPlayingType>();
        }

        public async Task<List<MovieListType>> GetMovieListList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/99cd7568-0b49-4c09-4387-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<MovieListType>>().ConfigureAwait(false);
            }

            return new List<MovieListType>();
        }

        public async Task<List<TheatresType>> GetTheatresList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/5435e256-3846-4895-4385-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<TheatresType>>().ConfigureAwait(false);
            }

            return new List<TheatresType>();
        }

        public async Task<List<ShowtimesType>> GetShowtimesList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/f179620a-3bb6-49cd-4384-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ShowtimesType>>().ConfigureAwait(false);
            }

            return new List<ShowtimesType>();
        }

        public async Task<List<TheatresNearYouType>> GetTheatresNearYouList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/49f543dc-9c4e-43e8-4386-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<TheatresNearYouType>>().ConfigureAwait(false);
            }

            return new List<TheatresNearYouType>();
        }

        public async Task<List<MyPurchasesType>> GetMyPurchasesList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/3f89384c-e58f-429a-4388-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<MyPurchasesType>>().ConfigureAwait(false);
            }

            return new List<MyPurchasesType>();
        }
    }
}

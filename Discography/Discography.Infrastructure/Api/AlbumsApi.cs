using Discography.Domain.Api;
using Discography.Domain.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace Discography.Infrastructure.Api
{
    /// <summary>
    /// Albums API implementation
    /// </summary>
    public class AlbumsApi : IAlbumsApi
    {
        private readonly RestClient _client = new RestClient("https://jsonplaceholder.typicode.com/albums");

        /// <summary>
        /// Get all albums available
        /// </summary>
        /// <returns>Album List</returns>
        public IList<Album> GetAlbumData()
        {
            var request = new RestRequest(Method.GET);
            var response = _client.Execute(request);

            return JsonConvert.DeserializeObject<IList<Album>>(response.Content);
        }
    }
}

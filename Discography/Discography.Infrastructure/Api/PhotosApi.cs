using Discography.Domain.Api;
using Discography.Domain.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace Discography.Infrastructure.Api
{
    public class PhotosApi : IPhotosApi
    {
        private readonly RestClient _client = new RestClient("https://jsonplaceholder.typicode.com/photos");

        /// <summary>
        /// Get all photos by album
        /// </summary>
        /// <param name="AlbumId">Album to filter by</param>
        /// <returns>List of photos</returns>
        public IList<Photo> GetPhotoDataByAlbum(int AlbumId)
        {
            var request = new RestRequest(Method.GET);
            var response = _client.Execute(request);
            // Get all photos
            var allPhotos = JsonConvert.DeserializeObject<IList<Photo>>(response.Content);
            // Filter by album and return
            return allPhotos.Where(p => p.albumId == AlbumId).ToList();
        }
    }
}

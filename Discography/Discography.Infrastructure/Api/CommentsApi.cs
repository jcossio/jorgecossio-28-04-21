using Discography.Domain.Api;
using Discography.Domain.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace Discography.Infrastructure.Api
{
    /// <summary>
    /// Comments API implementation
    /// </summary>
    public class CommentsApi : ICommentsApi
    {
        private readonly RestClient _client = new RestClient("https://jsonplaceholder.typicode.com/comments");

        /// <summary>
        /// Get all comments by photo
        /// </summary>
        /// <param name="PhotoId">Photo id</param>
        /// <returns>List of comments</returns>
        public IList<Comment> GetCommentDataByPhoto(int PhotoId)
        {
            var request = new RestRequest(Method.GET);
            var response = _client.Execute(request);
            // Get all comments
            var allComments = JsonConvert.DeserializeObject<IList<Comment>>(response.Content);
            // Filter by photo and return
            return allComments.Where(p => p.postId == PhotoId).ToList();
        }
    }
}

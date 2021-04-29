using Discography.Domain.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Discography.Web.Pages.Album
{
    public class ViewModel : PageModel
    {
        private readonly IPhotosApi photosApi;
        private readonly ICommentsApi commentsApi;

        /// <summary>
        /// Model for the page
        /// </summary>
        public IEnumerable<Domain.Models.Photo> Photos { get; set; }

        /// <summary>
        /// Page constructor. Inject the api service
        /// </summary>
        /// <param name="photosApi">Photos API</param>
        public ViewModel(IPhotosApi photosApi, ICommentsApi commentsApi)
        {
            // Store it
            this.photosApi = photosApi;
            this.commentsApi = commentsApi;
        }

        /// <summary>
        /// Page get operation
        /// </summary>
        public void OnGet(int? AlbumId)
        {
            // [TODO] Not getting the Album Id at this moment

            // Set the photos property for display
            Photos = photosApi.GetPhotoDataByAlbum(1); // AlbumId);
        }

        /// <summary>
        /// Get the comments for a specified photo
        /// </summary>
        /// <param name="photoId">Photo Id</param>
        /// <returns></returns>
        public ActionResult GetComments(int photoId)
        {
            return new OkObjectResult(commentsApi.GetCommentDataByPhoto(photoId));
        }
    }
}

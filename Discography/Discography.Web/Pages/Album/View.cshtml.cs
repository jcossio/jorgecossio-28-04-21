using Discography.Domain.Api;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Discography.Web.Pages.Album
{
    /// <summary>
    /// Display the photos for a specific album
    /// </summary>
    public class ViewModel : PageModel
    {
        private readonly IPhotosApi photosApi;

        /// <summary>
        /// Model for the page
        /// </summary>
        public IEnumerable<Domain.Models.Photo> Photos { get; set; }

        /// <summary>
        /// Page constructor. Inject the api service
        /// </summary>
        /// <param name="photosApi">Photos API</param>
        public ViewModel(IPhotosApi photosApi)
        {
            // Store it
            this.photosApi = photosApi;
        }

        /// <summary>
        /// Set the photos property based on album
        /// </summary>
        /// <param name="id">Album Id</param>
        public void OnGet(int? id)
        {
            // Set the photos property for display
            Photos = photosApi.GetPhotoDataByAlbum(id.Value);
        }
    }
}

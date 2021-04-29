using Discography.Domain.Api;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Discography.Web.Pages.Album
{
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
        /// Page get operation
        /// </summary>
        public void OnGet()
        {
            // Set the photos property for display
            Photos = photosApi.GetPhotoDataByAlbum(1); //AlbumId);
        }
    }
}

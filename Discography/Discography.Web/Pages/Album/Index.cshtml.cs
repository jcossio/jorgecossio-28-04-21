using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discography.Domain.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Discography.Web.Pages.Album
{
    public class IndexModel : PageModel
    {
        private readonly IAlbumsApi albumsApi;
        /// <summary>
        /// Model for the page
        /// </summary>
        public IEnumerable<Domain.Models.Album> Albums { get; set; }

        /// <summary>
        /// Page constructor. Inject the api service
        /// </summary>
        /// <param name="albumsApi">Albums API</param>
        public IndexModel(IAlbumsApi albumsApi)
        {
            // Store it
            this.albumsApi = albumsApi;
        }

        /// <summary>
        /// Page get operation
        /// </summary>
        public void OnGet()
        {
            // Set the Albums property for display
            Albums = albumsApi.GetAlbumData();
        }
    }
}

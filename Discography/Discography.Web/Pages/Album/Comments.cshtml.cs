using Discography.Domain.Api;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Discography.Web.Pages.Album
{
    /// <summary>
    /// Displays the comments on a specific photo
    /// </summary>
    public class CommentsModel : PageModel
    {
        private readonly ICommentsApi commentsApi;

        /// <summary>
        /// Model for the page
        /// </summary>
        public IEnumerable<Domain.Models.Comment> Comments { get; set; }

        /// <summary>
        /// Constructor that injects the API service
        /// </summary>
        /// <param name="commentsApi">Comments API</param>
        public CommentsModel(ICommentsApi commentsApi)
        {
            // Store it
            this.commentsApi = commentsApi;
        }

        /// <summary>
        /// Set the Comments based on the photo id
        /// </summary>
        /// <param name="id">Photo Id</param>
        public void OnGet(int? id)
        {
            // Set the Comments property for display
            Comments = commentsApi.GetCommentDataByPhoto(id.Value);
        }
    }
}

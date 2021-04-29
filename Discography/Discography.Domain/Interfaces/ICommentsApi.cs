using Discography.Domain.Models;
using System.Collections.Generic;

namespace Discography.Domain.Api
{
    /// <summary>
    /// Comments API interface
    /// </summary>
    public interface ICommentsApi
    {
        IList<Comment> GetCommentDataByPhoto(int PhotoId);
    }
}

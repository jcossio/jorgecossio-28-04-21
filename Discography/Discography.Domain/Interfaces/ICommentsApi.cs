using Discography.Domain.Models;
using System.Collections.Generic;

namespace Discography.Domain.Api
{
    public interface ICommentsApi
    {
        IList<Comment> GetCommentDataByPhoto(int PhotoId);
    }
}

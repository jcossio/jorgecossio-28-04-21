using Discography.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discography.Infrastructure.Api
{
    public interface ICommentsApi
    {
        IList<Comment> GetCommentDataByPhoto(int PhotoId);
    }
}

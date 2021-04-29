using Discography.Domain.Models;
using System.Collections.Generic;

namespace Discography.Infrastructure.Api
{
    public interface IAlbumsApi
    {
        IList<Album> GetAlbumData();
    }
}

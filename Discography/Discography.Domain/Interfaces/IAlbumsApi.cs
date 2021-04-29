using Discography.Domain.Models;
using System.Collections.Generic;

namespace Discography.Domain.Api
{
    public interface IAlbumsApi
    {
        IList<Album> GetAlbumData();
    }
}

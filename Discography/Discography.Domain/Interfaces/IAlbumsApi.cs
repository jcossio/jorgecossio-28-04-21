using Discography.Domain.Models;
using System.Collections.Generic;

namespace Discography.Domain.Api
{
    /// <summary>
    /// Albums API interface
    /// </summary>
    public interface IAlbumsApi
    {
        IList<Album> GetAlbumData();
    }
}

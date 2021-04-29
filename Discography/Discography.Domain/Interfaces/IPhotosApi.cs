using Discography.Domain.Models;
using System.Collections.Generic;

namespace Discography.Domain.Api
{
    /// <summary>
    /// Photos API interface
    /// </summary>
    public interface IPhotosApi
    {
        IList<Photo> GetPhotoDataByAlbum(int AlbumId);
    }
}

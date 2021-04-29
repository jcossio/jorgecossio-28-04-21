using Discography.Domain.Models;
using System.Collections.Generic;

namespace Discography.Domain.Api
{
    public interface IPhotosApi
    {
        IList<Photo> GetPhotoDataByAlbum(int AlbumId);
    }
}

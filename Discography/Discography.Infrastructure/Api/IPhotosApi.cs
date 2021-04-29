using Discography.Domain.Models;
using System.Collections.Generic;

namespace Discography.Infrastructure.Api
{
    public interface IPhotosApi
    {
        IList<Photo> GetPhotoDataByAlbum(int AlbumId);
    }
}

using ImageGallery.Model;
using System.Collections.Generic;

namespace ImageGallery.Client.ViewModels
{
    public class GalleryIndexViewModel
    {
        public IEnumerable<ImageDto> Images { get; private set; }
            = new List<ImageDto>();

        public GalleryIndexViewModel(List<ImageDto> images)
        {
           Images = images;
        }
    }
}

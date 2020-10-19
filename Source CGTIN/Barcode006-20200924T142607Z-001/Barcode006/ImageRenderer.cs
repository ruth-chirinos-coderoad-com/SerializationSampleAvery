using System.Drawing.Imaging;

namespace Barcode006
{
    internal class ImageRenderer
    {
        private ImageFormat imageFormat;

        public ImageRenderer(ImageFormat imageFormat)
        {
            this.imageFormat = imageFormat;
        }
    }
}
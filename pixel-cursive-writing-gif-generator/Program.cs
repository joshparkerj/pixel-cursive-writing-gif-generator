using System;

namespace pixel_cursive_writing_gif_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Drawing.
            Console.WriteLine("Hello World!");
        }

        ///// <summary>
        ///// Code copied from the stack overflow answer here:
        ///// https://stackoverflow.com/a/16598294
        ///// 
        ///// Unfortunately, it appears to depend on windows OS specific apis,
        ///// thus it is unsuitable for use with .net core and aws.
        ///// </summary>
        ////static void SOExample(ICollection<Bitmap> images, string path)
        ////{
        ////    _ = new GifBitmapEncoder();

        ////    foreach (Bitmap bmpImage in images)
        ////    {
        ////        _ = bmpImage.GetHbitmap();
        ////        //BitmapSource src = Imaging.CreateBitmapSourceFromHBitmap(
        ////        //    bmp,
        ////        //    IntPtr.Zero,
        ////        //    Int32Rect.Empty,
        ////        //    BitmapSizeOptions.FromEmptyOptions());
        ////        //gEnc.Frames.Add(BitmapFrame.Create(src));
        ////        //DeleteObject(bmp); // recommended, handle memory leak
        ////    }
        ////    using FileStream fs = new FileStream(path, FileMode.Create);
        ////}


    }
}

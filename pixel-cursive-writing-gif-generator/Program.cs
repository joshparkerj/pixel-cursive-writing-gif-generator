using ImageMagick;
using System;

namespace pixel_cursive_writing_gif_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Code copied from the Magick.NET manual here:
        /// https://github.com/dlemstra/Magick.NET/blob/master/docs/CombiningImages.md
        /// </summary>
        static void CreateAnimatedGif()
        {
            using (MagickImageCollection collection = new MagickImageCollection())
            {
                // Add first image and set the animation delay (in 1/100th of a second) 
                collection.Add("Snakeware.png");
                collection[0].AnimationDelay = 100; // in this example delay is 1000ms/1sec

                // Add second image, set the animation delay (in 1/100th of a second) and flip the image
                collection.Add("Snakeware.png");
                collection[1].AnimationDelay = 100; // in this example delay is 1000ms/1sec
                collection[1].Flip();

                // Optionally reduce colors
                QuantizeSettings settings = new QuantizeSettings();
                settings.Colors = 256;
                collection.Quantize(settings);

                // Optionally optimize the images (images should have the same size).
                collection.Optimize();

                // Save gif
                collection.Write("Snakeware.Animated.gif");
            }
        }
    }
}

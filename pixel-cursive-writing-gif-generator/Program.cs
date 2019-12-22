// <copyright file="Program.cs" company="Bofa">
// Copyright (c) Bofa. All rights reserved.
// </copyright>
// <author>joshparkerj</author>
// <date>12/21/2019</date>
//
namespace Pixel_cursive_writing_gif_generator
{
    using System;
    using ImageMagick;

    /// <summary>
    /// The program is where the magic happens yay.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Our program's starting place huzzah.
        /// </summary>
        /// <param name="args">If someone types something in on the command line after invoking the program, that text will appear as args. Nutty, I know.</param>
        public static void Main(string[] args)
        {
            if (!object.Equals(args, null))
            {
                foreach (string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }

            Console.WriteLine("Hello World!");

            CreateAnimatedGif();
        }

        /// <summary>
        /// Code copied from the Magick.NET manual here:
        /// https://github.com/dlemstra/Magick.NET/blob/master/docs/CombiningImages.md
        ///
        /// I will try to modify this method to write the gif to any stream (such as a network connection)
        /// not just the filesystem.
        /// </summary>
        private static void CreateAnimatedGif()
        {
            using MagickImageCollection collection = new MagickImageCollection
            {
                // Add first image and set the animation delay (in 1/100th of a second)
                "Snakeware.png",
            };
            collection[0].AnimationDelay = 100; // in this example delay is 1000ms/1sec

            // Add second image, set the animation delay (in 1/100th of a second) and flip the image
            collection.Add("Snakeware.png");
            collection[1].AnimationDelay = 100; // in this example delay is 1000ms/1sec
            collection[1].Flip();

            // Optionally reduce colors
            QuantizeSettings settings = new QuantizeSettings
            {
                Colors = 256,
            };
            collection.Quantize(settings);

            // Optionally optimize the images (images should have the same size).
            collection.Optimize();

            // Save gif
            collection.Write("Snakeware.Animated.gif");
        }
    }
}

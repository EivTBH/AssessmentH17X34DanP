using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Assessment
{
    /// <summary>
    /// Task 1 — Display the total size in KB of all of the images and the average size in KB of all of the images.
    ///Also counts and displays the total number of images there are on the USB device which are less than 100KB.
    ///Task 2 — Display the size in KB of the largest image.
    /// </summary>
    internal class ImageAnalyzer
    {
        /// <summary>
        /// Used to store the array of image sizes.
        /// </summary>
        private int[] imageSizes;

        public ImageAnalyzer(int[] sizes)
        {
            imageSizes = sizes;
        }

        /// <summary>
        /// This method is used to calculate the total size of all images.
        /// </summary>
        /// <returns> Total Size</returns>
        public int TotalSize()
        {
            int totalSize = 0;

            foreach (int size in imageSizes) // Loops through each image size in the array.
            {
                totalSize += size; // Adds the size to the total size.
            }

            return totalSize; // Returns the total size.
        }

        /// <summary>
        /// This method is used to calculate the average size of all images.
        /// </summary>
        /// <returns>Average Size</returns>
        public double AverageSize()
        {
            return (double)TotalSize() / imageSizes.Length; // Returns the total size divided by the number of images.
        }

        /// <summary>
        /// This method is used to count the number of images under a certain size.
        /// </summary>
        /// <returns>Total of images under 100kb</returns>
        public int NumImagesUnderSize(int size)
        {
            int numImages = 0;

            foreach (int imageSize in imageSizes) // Loops through each image size in the array.
            {
                if (imageSize < size) // Checks if the size is under the given size.
                {
                    numImages++; // Increases the number to show files under 100kb.
                }
            }

            return numImages; // Returns the number of images under set size.
        }

        /// <summary>
        /// This method is used to find the largest image size.
        /// </summary>
        /// <returns>Largest Size</returns>
        public int LargestSize() // Finds the largest image size.
        {
            int largestSize = 0;

            foreach (int size in imageSizes) // Loops through each image size in the array.
            {
                if (size > largestSize) // Checks if the size is larger than the current largest size.
                {
                    largestSize = size; // Sets the largest size to the current size.
                }
            }

            return largestSize; // Returns the largest size.
        }
    }
}

namespace Assessment

    //These are the methods needed to calculate Task 1 & 2:
    //Task 1 — Display the total size in KB of all of the images and the average size in KB of all of the images.
    //Also counts and displays the total number of images there are on the USB device which are less than 100KB.
    //
    //Task 2 — Display the size in KB of the largest image.

{
    internal class ImageAnalyzer
    {
        private int[] imageSizes; // Stores the array of image sizes

        public ImageAnalyzer(int[] sizes) 
        {
            imageSizes = sizes;
        }

        public int TotalSize() // Calculates the total size of all images
        {
            int totalSize = 0;

            foreach (int size in imageSizes) // Loops through each image size in the array
            {
                totalSize += size; // Adds the size to the total size
            }

            return totalSize; // Returns the total size
        }

        public double AverageSize() // Calculates the average size of all images
        {
            return (double)TotalSize() / imageSizes.Length; // Returns the total size divided by the number of images
        }

        public int NumImagesUnderSize(int size) // Counts the number of images under a certain size
        {
            int numImages = 0;

            foreach (int imageSize in imageSizes) // Loops through each image size in the array
            {
                if (imageSize < size) // Checks if the size is under the given size
                {
                    numImages++; // Increases the number to show files under 100kb
                }
            }

            return numImages; // Returns the number of images under set size
        }

        public int LargestSize() // Finds the largest image size
        {
            int largestSize = 0;

            foreach (int size in imageSizes) // Loops through each image size in the array
            {
                if (size > largestSize) // Checks if the size is larger than the current largest size
                {
                    largestSize = size; // Sets the largest size to the current size
                }
            }

            return largestSize; // Returns the largest size
        }
    }
}
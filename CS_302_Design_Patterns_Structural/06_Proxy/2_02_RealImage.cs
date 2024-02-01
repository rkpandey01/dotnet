using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Proxy
{
    // RealImage class
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadImage();
        }

        private void LoadImage()
        {
            Console.WriteLine($"Loading image: {fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {fileName}");
        }
    }

}

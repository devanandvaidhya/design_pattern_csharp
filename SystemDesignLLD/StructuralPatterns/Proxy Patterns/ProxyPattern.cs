using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.StructuralPatterns.Proxy_Patterns
{
    public class ProxyPattern
    {
        public void MainMethod()
        {
            // Normal object
            //Image img1 = new RealImage("cat.png");
            //Image img2 = new RealImage("dog.png");  

            // proxy object
            Image img1 = new ProxyImage("cat.png");
            Image img2 = new ProxyImage("dog.png");
            //The image is loaded lazily when needed,
            // saving time and resources if the
            // image is never displayed.
            img1.Display();
            img1.Display();
        }
    }

    interface Image
    {
        void Display();
    }

    public class RealImage : Image 
    {
        private string filename;
        public RealImage(string filename) 
        {
            this.filename = filename;
            LoadFilefromDB();  // expensinve operation
        }

        private void LoadFilefromDB()
        {
            Console.WriteLine("Loading file from DB " + filename);
        }

        public void Display()
        {
            Console.WriteLine(" Dispyaing file.... " + filename);
        }
    }

    // proxy class

    public class ProxyImage : Image
    {
        private string filename;
        private RealImage realImage;
        public ProxyImage(string filename)
        {
            this.filename = filename;

        }
        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }
            realImage.Display();
        }
    }
}

using System;
using System.Drawing.Printing;
using System.Drawing;


namespace xerox
{

    /// <summary>
    /// отправка изображения на принтер
    /// </summary>
    class Printer : IOutputImage
    {
       
        
        public void send()
        {
            

            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += PrintPageHandler;
                printDoc.Print();
            }

            void PrintPageHandler(object sender, PrintPageEventArgs e)
            {
                //Замените на e.Graphics.DrawImage или любую другую логику
                //e.Graphics.DrawString("Привет", new Font("Arial", 14), Brushes.Black, 0, 0);

                System.Drawing.Image img = System.Drawing.Image.FromFile("D:\\Foto.jpg");
                Point loc = new Point(100, 100);
                e.Graphics.DrawImage(img, loc);
            }
        }
    }
}

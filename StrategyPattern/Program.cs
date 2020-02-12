using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("* Captura la opción del formato de imagen que deseas subir:   *");
            Console.WriteLine("* 1 = BMP                                                     *");
            Console.WriteLine("* 2 = PNG                                                     *");
            Console.WriteLine("* 3 = JPEG                                                    *");
            Console.WriteLine("***************************************************************");

            string text;
            

            do
            {
                Context context = new Context();
                text = Console.ReadLine();      
                switch (text)
                {
                    case "1":
                        context.SetStrategy(new BmpStrategy());
                        break;
                    case "2":
                        context.SetStrategy(new PngStrategy());
                        break;
                    case "3":
                        context.SetStrategy(new JpegStrategy());
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        context = null;
                        break;
                }

                if (context != null)
                {
                    Console.WriteLine("Captura el nombre de la imagen");
                    string fileName = Console.ReadLine();
                    context.SaveImage(fileName);
                }

            } while (text != null);
        }
    }
}

using System;

namespace StrategyPattern
{
    public class BmpStrategy : IImageStrategy
    {
        public void PrintMessage(string name)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.bmp", name));
        }
    }
}

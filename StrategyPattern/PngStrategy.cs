using System;

namespace StrategyPattern
{
    public class PngStrategy : IImageStrategy
    {
        public void PrintMessage(string name)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.png", name));
        }
    }
}

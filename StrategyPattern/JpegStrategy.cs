using System;

namespace StrategyPattern
{
    public class JpegStrategy : IImageStrategy
    {
        public void PrintMessage(string name)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.jpeg", name));
        }
    }
}

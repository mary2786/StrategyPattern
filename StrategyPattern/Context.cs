namespace StrategyPattern
{
    public class Context
    {
        private IImageStrategy _strategy;

        public void SetStrategy(IImageStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SaveImage(string name)
        {
            _strategy.PrintMessage(name);
        }
    }
}

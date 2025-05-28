using System;

namespace Lab4.Task1.Handlers
{
    public class LevelFourHandler : SupportHandler
    {
        protected override bool CanHandle(int level) => level == 4;
        protected override void ProcessRequest() => Console.WriteLine("Рівень 4: загальні питання.");
    }
}

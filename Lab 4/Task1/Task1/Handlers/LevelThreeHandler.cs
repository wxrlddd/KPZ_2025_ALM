using System;

namespace Lab4.Task1.Handlers
{
    public class LevelThreeHandler : SupportHandler
    {
        protected override bool CanHandle(int level) => level == 3;
        protected override void ProcessRequest() => Console.WriteLine("Рівень 3: загальні питання.");
    }
}

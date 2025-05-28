using System;

namespace Lab4.Task1.Handlers
{
    public class LevelTwoHandler : SupportHandler
    {
        protected override bool CanHandle(int level) => level == 2;
        protected override void ProcessRequest() => Console.WriteLine("Рівень 2: загальні питання.");
    }
}

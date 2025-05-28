using System;

namespace Lab4.Task1.Handlers
{
    public class LevelOneHandler : SupportHandler
    {
        protected override bool CanHandle(int level) => level == 1;
        protected override void ProcessRequest() => Console.WriteLine("Рівень 1: загальні питання.");
    }
}

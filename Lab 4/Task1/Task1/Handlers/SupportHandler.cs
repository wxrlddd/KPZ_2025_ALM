using System;

namespace Lab4.Task1.Handlers
{
   
    public abstract class SupportHandler : ISupportHandler
    {
        private ISupportHandler nextHandler;

        public void SetNext(ISupportHandler next) => nextHandler = next;

        public void Handle(int level)
        {
            if (CanHandle(level))
                ProcessRequest();
            else if (nextHandler != null)
                nextHandler.Handle(level);
            else
                Console.WriteLine("Немає відповідного рівня підтримки. Спробуйте ще раз.");
        }

        protected abstract bool CanHandle(int level);
        protected abstract void ProcessRequest();
    }
}

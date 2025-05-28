namespace Lab4.Task1.Handlers
{
    
    public interface ISupportHandler
    {
        void SetNext(ISupportHandler next);
        void Handle(int level);
    }
}
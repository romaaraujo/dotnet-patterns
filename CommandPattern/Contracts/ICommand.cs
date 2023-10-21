namespace CommandPattern.Contracts
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

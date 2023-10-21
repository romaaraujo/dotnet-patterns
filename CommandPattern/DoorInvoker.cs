using CommandPattern.Contracts;

namespace CommandPattern
{
    public class DoorInvoker
    {
        private Stack<ICommand> commandList;

        public DoorInvoker()
        {
            this.commandList = new Stack<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            command.Execute();
            this.commandList.Push(command);
        }

        public void UndoCommand()
        {
            if (this.commandList.Count > 0)
            {
                var command = this.commandList.Pop();
                command.Undo();
            }
        }
    }
}
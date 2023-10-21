using CommandPattern.Contracts;

namespace CommandPattern.Commands
{
    public class CloseDoorCommand : ICommand
    {
        private readonly Door door;

        public CloseDoorCommand(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            this.door.Close();
            Console.WriteLine("COMMAND: Close Door");
        }

        public void Undo()
        {
            this.door.Open();
            Console.WriteLine("UNDO COMMAND: Open Door");
        }
    }
}
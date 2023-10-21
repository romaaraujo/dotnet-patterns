using CommandPattern.Contracts;

namespace CommandPattern.Commands
{
    public class OpenDoorCommand : ICommand
    {
        private readonly Door door;

        public OpenDoorCommand(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            this.door.Open();
            Console.WriteLine("COMMAND: Open Door");
        }

        public void Undo()
        {
            this.door.Close();
            Console.WriteLine("UNDO COMMAND: Close Door");
        }
    }
}
namespace CommandPattern
{
    public enum DoorStatus
    {
        Open,
        Closed
    }

    public class Door
    {
        public DoorStatus Status { get; private set; }

        public void Open()
        {
            this.Status = DoorStatus.Open;
        }

        public void Close()
        {
            this.Status = DoorStatus.Closed;
        }
    }
}
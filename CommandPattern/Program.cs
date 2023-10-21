using CommandPattern;
using CommandPattern.Commands;

var door = new Door();
var openDoorCommand = new OpenDoorCommand(door);
var closeDoorCommand = new CloseDoorCommand(door);

var doorInvoker = new DoorInvoker();
doorInvoker.AddCommand(openDoorCommand);
doorInvoker.UndoCommand();
doorInvoker.AddCommand(closeDoorCommand);
doorInvoker.UndoCommand();


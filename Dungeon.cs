namespace NetologyCSharp;

public class Dungeon
{
    public Room[] Rooms { get; private set; }
    
    public Dungeon()
    {
        Rooms =
        [
            new Room(new Unit("Unit", 0, 10), new Weapon("Weapon",1, 11)),
            new Room(new Unit("Unit1", 1, 12), new Weapon("Weapon1", 2, 13)),
            new Room(new Unit("Unit2", 2, 14), new Weapon("Weapon2", 3, 15)),
        ];
    }

    public void ShowRooms()
    {
        foreach (var room in Rooms)
        {
            Console.WriteLine("Unit of room" + room.Unit);
            Console.WriteLine("Weapon of room" + room.Weapon);
            Console.WriteLine("—");
        }
    }
}
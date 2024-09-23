namespace RoomReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidUser = false;
            while (!isValidUser)
            {
                Console.Clear();
                // move cursor to position
                Console.SetCursorPosition(2, 2);
                Console.Write("Username: ");
                Console.SetCursorPosition(2, 4);
                Console.Write("Password: ");
                Console.SetCursorPosition(12, 2);
                string username = Console.ReadLine();
                Console.SetCursorPosition(12, 4);
                string password = Console.ReadLine();
                Console.Clear();
                bool accessGranted = username == "admin" && password == "secret";
                if (accessGranted)
                {
                    isValidUser = true;
                    Console.WriteLine("Access granted!");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                    Thread.Sleep(2000); // 2000 ms = 2 sek
                }
            }
            Room[] rooms = new Room[20];
            int roomCounter = 0;
            bool shouldExit = false;
            while (!shouldExit)
            {
                Console.Clear();
                Console.WriteLine("1. Add room");
                Console.WriteLine("2. List rooms");
                Console.WriteLine("3. Remove room");
                Console.WriteLine("4. Make reservation");
                Console.WriteLine("5. List reservations");
                Console.WriteLine("6. Exit");
                ConsoleKeyInfo input = Console.ReadKey(true);
                Console.Clear();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.SetCursorPosition(2, 1);
                        Console.Write("ID: ");
                        Console.SetCursorPosition(2, 3);
                        Console.Write("Room name: ");
                        Console.SetCursorPosition(2, 5);
                        Console.Write("Description: ");
                        Console.SetCursorPosition("ID: ".Length + 2, 1);
                        Room meetingRoom = new Room();
                        meetingRoom.id = Console.ReadLine();
                        Console.SetCursorPosition("Room name: ".Length + 2, 3);
                        meetingRoom.name = Console.ReadLine();
                        Console.SetCursorPosition("Description: ".Length + 2, 5);
                        meetingRoom.description = Console.ReadLine();
                        rooms[roomCounter] = meetingRoom;
                        ++roomCounter;
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("ID  Name");
                        Console.WriteLine("-------------------------------------------------");
                        foreach (var room in rooms)
                        {
                            if (room == null) continue;
                            Console.WriteLine($"{room.id}\t{room.name}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("<Press any key to continue>");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        foreach (var room in rooms)
                        {
                            if (room == null) continue;
                            Console.WriteLine($"{room.id}\t{room.name}");
                        }
                        Console.WriteLine();
                        Console.Write("> ");
                        string roomId = Console.ReadLine();
                        for (int i = 0; i < rooms.Length; i++)
                        {
                            Room room = rooms[i];
                            if (room == null) continue;
                            if (room.id == roomId)
                            {
                                rooms[i] = null;
                                break;
                            }
                        }
                        break;
                }
            }

        }
    }
}
class Room
{
    public string id;
    public string name;
    public string description;
}
class Reservation
{
    public string roomId;
    public DateTime fromDate;
    public DateTime toDate;
}


       
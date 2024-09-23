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
        }
    }
}

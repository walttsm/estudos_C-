class Program
{

    static void Main(string[] args)
    {

        Tenant[] rooms = new Tenant[10];

        Console.Write("How many rooms will be rented? ");

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Room: ");
            int room = int.Parse(Console.ReadLine());

            rooms[room] = new Tenant(name, email);
        }

        Console.WriteLine();
        Console.WriteLine("Busy rooms:");
        for (int i = 0; i < 10; i++)
        {
            if (rooms[i] != null)
            {
                Console.WriteLine(i + ": " + rooms[i]);
            }
        }
    }
}
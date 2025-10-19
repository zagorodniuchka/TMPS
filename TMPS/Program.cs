    using TMPS.lab2;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select Laboratory Work:");
            Console.WriteLine("1 - SOLID Principles");
            Console.WriteLine("2 - Creational Design Patterns");
            Console.Write("Enter number: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    new Lab1Runner().Run();
                    break;
                case "2":
                    new Lab2Runner().Run();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

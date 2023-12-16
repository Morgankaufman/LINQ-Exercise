namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> Games = new List<string>
            {
                "Super Mario Odyssey",
                "Ratchet and Clank",
                "The Witcher 3",
                "Uncharted",
                "Jak and Daxter",
                "Spyro",
                "Red Dead Redemption",
            };

            var GamesOrdered = Games.OrderBy(game => game.Length);

            Console.WriteLine("List of games ordered by length.");

            foreach (var game in GamesOrdered) 
            {
                Console.WriteLine(game);
            }
        }
    }
}

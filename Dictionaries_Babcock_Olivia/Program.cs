using System.Collections;

namespace Dictionaries_Babcock_Olivia
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Creates a new dictionary that displays int and string values.
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            
            // States int and string values in a list.
            topGames.Add(1, "SW: KotOR");
            topGames.Add(2, "Mortal Kombat Deception");
            topGames.Add(3, "Sonic Adventure 2");
            topGames.Add(4, "Sonic 3 and Knuckles");
            topGames.Add(5, "Mortal Kombat: Shaolin Monks");
            topGames.Add(6, "Sonic Riders");
            topGames.Add(7, "Halo 2");
            topGames.Add(8, "Luigi's Mansion");
            topGames.Add(9, "Star Fox 64");
            topGames.Add(10, "Prince of Persia: The Sands of Time");

            // Creates foreach loop for key and value pair.
            foreach(KeyValuePair<int, string> kvp in topGames)
            {
                // Prints key and value elements to console.
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // States if statement.
            if (topGames.ContainsKey(1))
            {
                // Prints to the console.
                Console.WriteLine($"My favorite game is {topGames[1]}!");
            }

            // Determine string result value.
            string result = "";

            // Gives out result for specified key.
            topGames.TryGetValue(11, out result);

            // Creates an if and else statement for result.
            if(result != "")
            {
                // Prints result to the console.
                Console.WriteLine(result);
            }
            else
            {
                // Prints to the console.
                Console.WriteLine("There is no game in the eleventh position.");
            }

            // Creates an if statement.
            if (topGames.ContainsKey(5)) ;
            {
                // States game at the int of 5.
                topGames[5] = "Mortal Kombat: Shaolin Monks";
            }

            // Prints to  the console.
            Console.WriteLine(topGames[5]);

            // Creates new hashtable.
            Hashtable hashTable = new Hashtable(topGames);

            // Creates string for favGame in hashtable.
            string favGame = (string)hashTable[1];

            // Prints favorite game to the console.
            Console.WriteLine($"Favorite Game: {favGame}");

            // Creates new hashtable for capitals.
            Hashtable capitals = new Hashtable()
            {
                // Determines and lists key and value elements respecively.
                { "Germany", "Berlin" },
                { "Norway", "Oslo" },
                { "Bulgaria", "Sofia" },
                { "Spain", "Madrid" },
            };

            // Creates a foreach loop.
            foreach (DictionaryEntry kvp in capitals)
            {   
                // Prints key and value elements to the console.
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Removes all elements in capitals from the list.
            capitals.Clear();
        }
    }
}
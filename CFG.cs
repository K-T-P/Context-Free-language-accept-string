using System;

namespace CFG{
    class Program{
        static void Main(){

        }
        static void ImportData()
        {
            int numberOfLoops = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLoops; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                Products.Add(data[0].Trim(), data[1].Split(" | ").Select(x => x.Trim()).ToList());

                //first variable is assigned as start variable
                if (i == 0)
                    startVariable = data[0].Trim();
            }
            input = Console.ReadLine();
        }
        static Dictionary<string, List<string>> Products = new Dictionary<string, List<string>>();
        static string input;
    }
}
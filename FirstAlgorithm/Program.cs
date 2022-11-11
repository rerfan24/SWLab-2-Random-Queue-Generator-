namespace firstAlgorithm;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        List<string> people = new List<string>();
        List<int> turn = new List<int>();

        System.Console.WriteLine("Enter the number of the people you have to put in queue:");
        int remainingSeeds = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Do you want to name your people? (Y,N) ");
        if (Console.ReadLine() == "Y")
        {
            for (int i = 0; i < remainingSeeds; i++)
            {
                System.Console.WriteLine("enter person number " + i + "'s name: ");
                string name = Console.ReadLine();
                people.Add(name);
                turn.Add(0);
            }
        }
        else
        {
            for (int i = 0; i < remainingSeeds; i++)
            {
                people.Add(Convert.ToString(i + 1));
                turn.Add(0);
            }
        }

        int turnNumber = 1;
        while (turnNumber < remainingSeeds + 1)
        {
            double seed = rnd.NextDouble();
            double partition = (1 / (double)remainingSeeds);
            double seedTop = partition;
            for (int i = 0; i < remainingSeeds; i++)
            {
                if (seed < seedTop && turn[i] == 0)
                {
                    turn[i] = turnNumber;
                    turnNumber++;
                    break;
                }
                else if (seed < seedTop && turn[i] != 0)
                {
                    break;
                }
                else
                {
                    seedTop += partition;
                }
            }

        }

        System.Console.Clear();
        for (int i = 0; i < remainingSeeds; i++)
        {
            System.Console.Write(string.Format("{0,-10}", people[i]));
            System.Console.WriteLine(": " + turn[i]);
        }
    }
}

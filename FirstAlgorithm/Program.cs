namespace firstAlgorithm;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        List<int> people = new List<int>();
        List<int> turn = new List<int>();

        int remainingSeeds = 5;
        for (int i = 0; i < remainingSeeds; i++)
        {
            people.Add(i + 1);
            turn.Add(0);
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

        for (int i = 0; i < remainingSeeds; i++)
        {
            System.Console.WriteLine(people[i] + "'s turn is: " + turn[i]);
        }
    }
}

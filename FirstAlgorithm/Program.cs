namespace firstAlgorithm;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        List<string> people = new List<string>();
        List<int> turn = new List<int>();
        int remainingSeeds = 0;

        System.Console.WriteLine("Enter the number of the people you have to put in queue:");
        bool problem = true;
        while (problem)
        {
            string? val = Console.ReadLine();

            try
            {
                remainingSeeds = Convert.ToInt32(val);
                if (remainingSeeds < 0)
                {
                    throw new InvalidDataException("Number must be greater than or equal to 0, please try again:");
                }
                problem = false;
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Not a number!! please try again:");
            }
            catch (InvalidDataException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        problem = true;
        System.Console.Write("Do you want to name your people? (Y,N) ");
        while (problem)
        {
            try
            {
                string? val = Console.ReadLine();
                if (val == "Y" || val == "y")
                {
                    for (int i = 0; i < remainingSeeds; i++)
                    {
                        System.Console.WriteLine("enter person number " + i + "'s name: ");
                        string? name = Console.ReadLine();
                        while (name == null || name == "")
                        {
                            System.Console.WriteLine("enter person number " + i + "'s name: ");
                            name = Console.ReadLine();
                        }
                        people.Add(name);
                        turn.Add(0);
                    }
                    problem = false;
                }
                else if (val == "N" || val == "n")
                {
                    for (int i = 0; i < remainingSeeds; i++)
                    {
                        people.Add(Convert.ToString(i + 1));
                        turn.Add(0);
                    }
                    problem = false;
                }
                else
                {
                    throw new InvalidDataException("(Y,N) only... ");
                }
            }
            catch (InvalidDataException ex)
            {
                System.Console.Write(ex.Message);
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

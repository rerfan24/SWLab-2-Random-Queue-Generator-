namespace firstAlgorithm;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        List<int> people = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            people.Add(i + 1);
        }
        Console.WriteLine("[" + string.Join(", ", people) + "]");
    }
}

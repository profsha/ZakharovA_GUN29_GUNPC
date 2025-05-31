namespace NetologyCSharp;

public struct Interval
{
    public int Min { get; set; }
    public int Max { get; set; }
    
    private Random _rand = new Random(DateTime.Now.Millisecond);

    public int Get => _rand.Next(Min, Max);

    public Interval(int min, int max)
    {
        if (min < 0)
        {
            Console.WriteLine("min cannot be less than 0");
            min = 0;
        }

        if (max < 0)
        {
            Console.WriteLine("max cannot be less than 0");
            max = 0;
        }
        if (min > max)
        {
            Console.WriteLine("min > max");
            (min, max) = (max, min);
        } else if (max == min)
        {
            Console.WriteLine("min == max");
            max += 10;
        }
        Min = min;
        Max = max;
    }

    public override string ToString()
    {
        return $"Min: {Min}, Max: {Max}";
    }
}
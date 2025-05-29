namespace NetologyCSharp;

public class Weapon
{
    public string Name { get; }
    public int MaxDamage { get; private set; }
    public int MinDamage { get; private set; }
    public float Durability { get; }

    public Weapon(string name)
    {
        Name = name;
        Durability = 1f;
    }

    public Weapon(string name, int minDamage, int maxDamage) : this(name)
    {
        SetDamageParams(minDamage, maxDamage);
    }

    public void SetDamageParams(int minDamage, int maxDamage)
    {
        if (minDamage > maxDamage)
        {
            Console.WriteLine("minDamage must be less than maxDamage");
            (minDamage, maxDamage) = (maxDamage, minDamage);
        }

        if (minDamage < 1)
        {
            minDamage = 1;
            Console.WriteLine("minDamage must be greater than 0");
        }

        MinDamage = minDamage;
        MaxDamage = maxDamage <= 1 ? 10 : maxDamage;
    }

    public float GetDamage()
    {
        return (MinDamage + MaxDamage) / 2f;
    }
}
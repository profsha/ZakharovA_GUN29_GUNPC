namespace NetologyCSharp;

public class Weapon
{
    public string Name { get; }
    public Interval Damage { get; private set; }
    public float Durability { get; }

    public Weapon(string name)
    {
        Name = name;
        Durability = 1f;
    }
    
    public Weapon(string name, Interval damage) : this(name)
    {
        SetDamageParams(damage);
    }

    public Weapon(string name, int minDamage, int maxDamage) : this(name, new Interval(minDamage, maxDamage))
    {
    }

    public void SetDamageParams(Interval damage)
    {
        Damage = damage;
    }
    
    public void SetDamageParams(int minDamage, int maxDamage)
    {
        SetDamageParams(new Interval(minDamage, maxDamage));
    }

    public float GetDamage()
    {
        return Damage.Get;
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, Damage: {Damage}, Durability: {Durability}";
    }
}
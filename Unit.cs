namespace NetologyCSharp;

public class Unit
{
    private float _health;
    public string Name {get;}
    public float Health => _health;
    public Interval Damage {get;}
    public float Armor { get; }

    public Unit(string name, int minDamage, int maxDamage) : this(name, new Interval(minDamage, maxDamage))
    {
    }
    
    public Unit(string name, Interval damage) : this(name)
    {
    }

    public Unit(string name)
    {
        Name = name;
        _health = 100;
        Armor = 0.6f;
    }

    public Unit() : this("Unknown Unit")
    {
    }

    public float GetRealHealth()
    {
        return Health * (1f + Armor);
    }

    public bool SetDamage(float value)
    {
        _health = Health - value * Armor;
        return _health <= 0f;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Health: {Health}, Damage: {Damage}, Armor: {Armor}";
    }

}
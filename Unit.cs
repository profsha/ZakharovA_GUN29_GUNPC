namespace NetologyCSharp;

public class Unit
{
    private float _health;
    public string Name {get;}
    public float Health => _health;
    public int Damage {get;}
    public float Armor { get; }

    public Unit(string name)
    {
        Name = name;
        _health = 100;
        Damage = 5;
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

}
namespace NetologyCSharp;

public struct Room(Unit unit, Weapon weapon)
{
    public Unit Unit { get; private set; } = unit;
    public Weapon Weapon { get; private set; } = weapon;
}
using NetologyCSharp;

var unit1 = new Unit();
var unit2 = new Unit("Unit2");

Console.WriteLine($"""
                   Unit1: name = {unit1.Name},
                    health = {unit1.Health},
                    damage = {unit1.Damage},
                    armor = {unit1.Armor},
                    realHealth = {unit1.GetRealHealth()}
                   """);
Console.WriteLine($"""
                   Unit2: name = {unit2.Name},
                    health = {unit2.Health},
                    damage = {unit2.Damage},
                    armor = {unit2.Armor},
                    realHealth = {unit2.GetRealHealth()}
                   """);

unit2.SetDamage(30);
Console.WriteLine($"""
                   Unit2 after damage: name = {unit2.Name},
                    health = {unit2.Health},
                    damage = {unit2.Damage},
                    armor = {unit2.Armor},
                    realHealth = {unit2.GetRealHealth()}
                   """);

var weapon1 = new Weapon("Weapon1");
var weapon2 = new Weapon("Weapon2", 3, 20);

Console.WriteLine($"""
                   Weapon1: name = {weapon1.Name},
                    durability = {weapon1.Durability},
                    minDamage = {weapon1.MinDamage},
                    maxDamage = {weapon1.MaxDamage},
                   """);
Console.WriteLine($"""
                   Weapon2 after damage: name = {weapon2.Name},
                    durability = {weapon2.Durability},
                    minDamage = {weapon2.MinDamage},
                    maxDamage = {weapon2.MaxDamage},
                   """);

weapon1.SetDamageParams(0, 1);
Console.WriteLine($"""
                   Weapon1 after set params: name = {weapon1.Name},
                    durability = {weapon1.Durability},
                    minDamage = {weapon1.MinDamage},
                    maxDamage = {weapon1.MaxDamage},
                   """);


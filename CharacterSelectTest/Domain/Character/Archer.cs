using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 75;
        Strength = 5;
        Intelligence = 12;
        Agility = 9;
        Mana = 100;
        Evasion = 2;
        Special = "zasypuje przeciwników gradem strzał";
    }
}
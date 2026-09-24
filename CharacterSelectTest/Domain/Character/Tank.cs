using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Tank : Entity.Character
{
    public Tank(string name) : base(name, CharacterClass.Tank)
    {
        Health = 200;
        Strength = 2;
        Intelligence = 4;
        Agility = 9;
        Mana = 100;
        Evasion = 7;
        Special = "zyskuje całkowitą odporność na obrażenia";
    }
}
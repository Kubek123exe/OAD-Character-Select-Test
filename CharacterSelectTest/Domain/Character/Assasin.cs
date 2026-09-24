using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Assasin : Entity.Character
{
    public Assasin(string name) : base(name, CharacterClass.Assasin)
    {
        Health = 65;
        Strength = 20;
        Intelligence = 6;
        Agility = 15;
        Mana = 90;
        Evasion = 6;
        Special = "one shotuje przeciwnika";
    }
}
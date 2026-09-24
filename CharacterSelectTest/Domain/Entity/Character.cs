using CharacterSelectTest.Domain.Enum;
using System.Text.Json.Serialization;

namespace CharacterSelectTest.Domain.Entity;

public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }
    public int Mana { get; protected set; }
    public int Evasion { get; protected set; }
    public string Special { get; protected set; }

    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"[{Class}] {Name}");
        Console.WriteLine($"  HP: {Health}");
        Console.WriteLine($"  STR: {Strength}  INT: {Intelligence}  AGI: {Agility}");
        Console.WriteLine($"  MANA: {Mana}  EV: {Evasion}");
    }
    public virtual int Attack()
    {
        int wartoscAtaku = Strength * 2;
        Console.WriteLine($"[{Class}] {Name} zadał {wartoscAtaku} obrażeń");
        return wartoscAtaku;
    }
    public virtual string UseSpecialSkill(string name)
    {
        string special = $"{name} {Special}";
        Console.WriteLine(special);
        return special;
    }
}
using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;
using System;
namespace CharacterSelectTest;

[TestClass]
public class WarriorTest
{
    [TestMethod]
    public void TestWarriorCreating()
    {
        Character warrior = CharacterFactory.Create(CharacterClass.Warrior, "Eryx");
        Assert.AreEqual("Eryx", warrior.Name);
        Assert.AreEqual(CharacterClass.Warrior, warrior.Class);
    }
    [TestMethod]
    public void TestWarriorStats()
    {
        Character warrior = CharacterFactory.Create(CharacterClass.Warrior, "Eryx");
        Assert.AreEqual(120, warrior.Health);
        Assert.AreEqual(14, warrior.Strength);
        Assert.AreEqual(6, warrior.Intelligence);
        Assert.AreEqual(8, warrior.Agility);
        Assert.AreEqual(100, warrior.Mana);
        Assert.AreEqual(5, warrior.Evasion);
    }
    [TestMethod]
    public void TestWarriorAttack()
    {
        Character warrior = CharacterFactory.Create(CharacterClass.Warrior, "Eryx");
        Assert.AreEqual(28, warrior.Attack());
    }
    [TestMethod]
    public void TestWarriorSpecial()
    {
        Character warrior = CharacterFactory.Create(CharacterClass.Warrior, "Eryx");
        Assert.AreEqual("Eryx tworzy aurę zadającą obrażenia", warrior.UseSpecialSkill(warrior.Name));
    }
}
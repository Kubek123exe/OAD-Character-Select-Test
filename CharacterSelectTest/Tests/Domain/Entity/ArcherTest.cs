using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;
using System;
namespace CharacterSelectTest;

[TestClass]
public class ArcherTest
{
    [TestMethod]
    public void TestArcherCreating()
    {
        Character archer = CharacterFactory.Create(CharacterClass.Archer, "Eryndor");
        Assert.AreEqual("Eryndor", archer.Name);
        Assert.AreEqual(CharacterClass.Archer, archer.Class);
    }
    [TestMethod]
    public void TestArcherStats()
    {
        Character archer = CharacterFactory.Create(CharacterClass.Archer, "Eryndor");
        Assert.AreEqual(75, archer.Health);
        Assert.AreEqual(5, archer.Strength);
        Assert.AreEqual(12, archer.Intelligence);
        Assert.AreEqual(9, archer.Agility);
        Assert.AreEqual(100, archer.Mana);
        Assert.AreEqual(2, archer.Evasion);
    }
    [TestMethod]
    public void TestArcherAttack()
    {
        Character archer = CharacterFactory.Create(CharacterClass.Archer, "Eryndor");
        Assert.AreEqual(10, archer.Attack());
    }
    [TestMethod]
    public void TestArcherSpecial()
    {
        Character archer = CharacterFactory.Create(CharacterClass.Archer, "Eryndor");
        Assert.AreEqual("Eryndor zasypuje przeciwników gradem strzał", archer.UseSpecialSkill(archer.Name));
    }
}
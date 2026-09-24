using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;
using System;
namespace CharacterSelectTest;

[TestClass]
public class RogueTest
{
    [TestMethod]
    public void TestRogueCreating()
    {
        Character rogue = CharacterFactory.Create(CharacterClass.Rogue, "Dravenor");
        Assert.AreEqual("Dravenor", rogue.Name);
        Assert.AreEqual(CharacterClass.Rogue, rogue.Class);
    }
    [TestMethod]
    public void TestRogueStats()
    {
        Character rogue = CharacterFactory.Create(CharacterClass.Rogue, "Dravenor");
        Assert.AreEqual(95, rogue.Health);
        Assert.AreEqual(9, rogue.Strength);
        Assert.AreEqual(8, rogue.Intelligence);
        Assert.AreEqual(15, rogue.Agility);
        Assert.AreEqual(100, rogue.Mana);
        Assert.AreEqual(5, rogue.Evasion);
    }
    [TestMethod]
    public void TestRogueAttack()
    {
        Character rogue = CharacterFactory.Create(CharacterClass.Rogue, "Dravenor");
        Assert.AreEqual(18, rogue.Attack());
    }
    [TestMethod]
    public void TestRogueSpecial()
    {
        Character rogue = CharacterFactory.Create(CharacterClass.Rogue, "Dravenor");
        Assert.AreEqual("Dravenor staje się niewidzialny", rogue.UseSpecialSkill(rogue.Name));
    }
}
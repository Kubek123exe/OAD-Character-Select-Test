using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;
using System;
namespace CharacterSelectTest;

[TestClass]
public class MageTest
{
    [TestMethod]
    public void TestMageCreating()
    {
        Character mage = CharacterFactory.Create(CharacterClass.Mage, "Sylvar");
        Assert.AreEqual("Sylvar", mage.Name);
        Assert.AreEqual(CharacterClass.Mage, mage.Class);
    }
    [TestMethod]
    public void TestMageStats()
    {
        Character mage = CharacterFactory.Create(CharacterClass.Mage, "Sylvar");
        Assert.AreEqual(80, mage.Health);
        Assert.AreEqual(4, mage.Strength);
        Assert.AreEqual(16, mage.Intelligence);
        Assert.AreEqual(10, mage.Agility);
        Assert.AreEqual(150, mage.Mana);
        Assert.AreEqual(2, mage.Evasion);
    }
    [TestMethod]
    public void TestMageAttack()
    {
        Character mage = CharacterFactory.Create(CharacterClass.Mage, "Sylvar");
        Assert.AreEqual(8, mage.Attack());
    }
    [TestMethod]
    public void TestMageSpecial()
    {
        Character mage = CharacterFactory.Create(CharacterClass.Mage, "Sylvar");
        Assert.AreEqual("Sylvar rzuca kulą ognia", mage.UseSpecialSkill(mage.Name));
    }
}
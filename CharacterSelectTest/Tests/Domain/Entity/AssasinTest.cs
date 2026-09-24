using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;
using System;
namespace CharacterSelectTest;

[TestClass]
public class AssasinTest
{
    [TestMethod]
    public void TestAssasinCreating()
    {
        Character assasin = CharacterFactory.Create(CharacterClass.Assasin, "Nyther");
        Assert.AreEqual("Nyther", assasin.Name);
        Assert.AreEqual(CharacterClass.Assasin, assasin.Class);
    }
    [TestMethod]
    public void TestAssasinStats()
    {
        Character assasin = CharacterFactory.Create(CharacterClass.Assasin, "Nyther");
        Assert.AreEqual(65, assasin.Health);
        Assert.AreEqual(20, assasin.Strength);
        Assert.AreEqual(6, assasin.Intelligence);
        Assert.AreEqual(15, assasin.Agility);
        Assert.AreEqual(90, assasin.Mana);
        Assert.AreEqual(6, assasin.Evasion);
    }
    [TestMethod]
    public void TestAssasinAttack()
    {
        Character assasin = CharacterFactory.Create(CharacterClass.Assasin, "Nyther");
        Assert.AreEqual(40, assasin.Attack());
    }
    [TestMethod]
    public void TestAssasinSpecial()
    {
        Character assasin = CharacterFactory.Create(CharacterClass.Assasin, "Nyther");
        Assert.AreEqual("Nyther one shotuje przeciwnika", assasin.UseSpecialSkill(assasin.Name));
    }
}
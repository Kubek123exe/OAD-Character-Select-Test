using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Enum;
using System;
namespace CharacterSelectTest;

[TestClass]
public class TankTest
{
    [TestMethod]
    public void TestTankCreating()
    {
        Character tank = CharacterFactory.Create(CharacterClass.Tank, "Valther");
        Assert.AreEqual("Valther", tank.Name);
        Assert.AreEqual(CharacterClass.Tank, tank.Class);
    }
    [TestMethod]
    public void TestTankStats()
    {
        Character tank = CharacterFactory.Create(CharacterClass.Tank, "Valther");
        Assert.AreEqual(200, tank.Health);
        Assert.AreEqual(2, tank.Strength);
        Assert.AreEqual(4, tank.Intelligence);
        Assert.AreEqual(9, tank.Agility);
        Assert.AreEqual(100, tank.Mana);
        Assert.AreEqual(7, tank.Evasion);
    }
    [TestMethod]
    public void TestTankAttack()
    {
        Character tank = CharacterFactory.Create(CharacterClass.Tank, "Valther");
        Assert.AreEqual(4, tank.Attack());
    }
    [TestMethod]
    public void TestTankSpecial()
    {
        Character tank = CharacterFactory.Create(CharacterClass.Tank, "Valther");
        Assert.AreEqual("Valther zyskuje całkowitą odporność na obrażenia", tank.UseSpecialSkill(tank.Name));
    }
}
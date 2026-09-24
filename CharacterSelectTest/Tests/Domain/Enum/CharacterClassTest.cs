using CharacterSelectTest.Application.Factory;
using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;
using System.Runtime.InteropServices;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class CharacterClassTest
{
    [TestMethod]
    public void testingCharacterCreating()
    {
        CharacterFactory.Create(CharacterClass.Warrior, "name for warrior");
    }
}
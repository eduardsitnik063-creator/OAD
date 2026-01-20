using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Mage : Entity.Character
{
    public Mage(string name) : base(name, CharacterClass.Mage)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Armor = 10;
        Mobility = 40;
        Spead = 60;
        MainStat = this.Intelligence * 3;
        String = "Storm atack";
    }
}
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 50;
        Strength = 8;
        Intelligence = 10;
        Agility = 10;
        Armor = 5;
        Mobility = 25;
        Spead = 30;
        MainStat = this.Intelligence * 3;
        String = "Arrows";
    }
}
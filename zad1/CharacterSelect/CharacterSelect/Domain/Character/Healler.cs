using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Healler : Entity.Character
{
    public Healler(string name) : base(name, CharacterClass.Healler)
    {
        Health = 30;
        Strength = 15;
        Intelligence = 20;
        Agility = 10;
        Armor = 3;
        Mobility = 15;
        Spead = 20;
        MainStat = this.Intelligence * 3;
        String = "Vampirism";
    }
}
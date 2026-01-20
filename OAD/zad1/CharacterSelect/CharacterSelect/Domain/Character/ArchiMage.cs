using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class ArchiMage : Entity.Character
{
    public ArchiMage(string name) : base(name, CharacterClass.ArchiMage)
    {
        Health = 100;
        Strength = 30;
        Intelligence = 30;
        Agility = 15;
        Armor = 30;
        Mobility = 50;
        Spead = 50;
        MainStat = this.Intelligence * 3;
        String = "Mega fireball";
    }
}
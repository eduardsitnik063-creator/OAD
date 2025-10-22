using System;
using CharacterSelect.Application;
using CharacterSelect.Domain.Character;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Entity;

public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }
    public int Armor { get; protected set; }
    public int Mobility { get; protected set; }
    public int Spead { get; protected set; }
    public int MainStat { get; protected set; }
    public string String { get; protected set; }

    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"[{Class}] {Name}");
        Console.WriteLine($"  HP: {Health}");
        Console.WriteLine($"  STR: {Strength}  INT: {Intelligence}  AGI: {Agility} ARM: {Armor} MOB: {Mobility} SP: {Spead}");
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{MainStat = Intelligence * 3} obrażeń");
    }

    public virtual void UseSpecial()
    {
        Console.WriteLine("Używam specjalnego ulta");
        Console.WriteLine($"{String}");
    }
}
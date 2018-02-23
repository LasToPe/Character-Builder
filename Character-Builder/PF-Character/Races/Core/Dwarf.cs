using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Races.Core.Racial_Traits;

namespace PF_Character.Races.Core
{
    public class Dwarf : Race
    {
        public Dwarf(Character character) : base(character)
        {
            Constitution_Bonus = 2;
            Wisdom_Bonus = 2;
            Charisma_Bonus = -2;

            Race_Name = "Dwarf";

            Size = new Size().Medium();

            Type = "Humanoid (dwarf)";

            Base_Speed = 20;

            Langauges.Add("Common");
            Langauges.Add("Dwarven");

            Racial_Traits.Add(new Dwarf_Racial_Trait().Defensive_Training());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Hardy());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Stability());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Greed());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Stonecunning());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Darkvision());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Hatred());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Weapon_Familiarity());
        }

        public override void SetBonus(string Bonus)
        {
            //Do nothing
        }
    }
}

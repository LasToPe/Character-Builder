using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Races.Core.Racial_Traits;

namespace PF_Character.Races.Core
{
    public class Elf : Race
    {
        public Elf(Character character) : base(character)
        {
            Dexterity_Bonus = 2;
            Constitution_Bonus = -2;
            Intelligence_Bonus = 2;

            Size = new Size().Medium();

            Type = "Humanoid (elf)";

            Base_Speed = 30;

            Langauges.Add("Common");
            Langauges.Add("Elven");

            Racial_Traits.Add(new Elf_Racial_Trait().Elven_Immunities());
            Racial_Traits.Add(new Elf_Racial_Trait().Keen_Senses(this));
            Racial_Traits.Add(new Elf_Racial_Trait().Elven_Magic());
            Racial_Traits.Add(new Elf_Racial_Trait().Weapon_Familiarity());
            Racial_Traits.Add(new Elf_Racial_Trait().Low_Light_Vision());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Races.Core.Racial_Traits
{
    class Elf_Racial_Trait : Racial_Trait
    {
        //Standard Traits
        public Racial_Trait Elven_Immunities()
        {
            Name = "Elven Immunities";
            Description = "Elves are immune to magic sleep effects and gain a +2 racial saving throw bonus against enchantment spells and effects.";
            return this;
        }

        public Racial_Trait Keen_Senses(Elf elf)
        {
            Name = "Keen Senses";
            Description = "Elves receive a +2 racial bonus on Perception checks.";
            //functionality
            elf.Character.Skills_List.Find(x => x.Skill_Name == "Perception").Misc_Mod += 2;
            return this;
        }

        public Racial_Trait Elven_Magic()
        {
            Name = "Elven Magic";
            Description = "Elves receive a +2 racial bonus on caster level checks made to overcome spell resistance. In addition, elves receive a +2 racial bonus on Spellcraft skill checks made to identify the properties of magic items.";
            return this;
        }

        public Racial_Trait Weapon_Familiarity()
        {
            Name = "Weapon Familiarity";
            Description = "Elves are proficient with longbows (including composite longbows), longswords, rapiers, and shortbows (including composite shortbows), and treat any weapon with the word “elven” in its name as a martial weapon.";
            //set up functionality
            return this;
        }

        public Racial_Trait Low_Light_Vision()
        {
            Name = "Low-Light Vision";
            Description = "Elves can see twice as far as humans in conditions of dim light.";
            return this;
        }

        //Here goes Alternate Traits
    }
}

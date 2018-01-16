using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Races.Racial_Traits
{
    class Half_elf_Racial_Trait : Racial_Trait
    {
        //Standard Traits
        public Racial_Trait Elven_Immunities()
        {
            Name = "Elven Immunities";
            Description = "Half-elves are immune to magic sleep effects and gain a +2 racial saving throw bonus against enchantment spells and effects.";
            return this;
        }

        public Racial_Trait Adaptability()
        {
            Name = "Adaptability";
            Description = "Half-elves receive Skill Focus as a bonus feat at 1st level.";
            //set up functionality
            return this;
        }

        public Racial_Trait Keen_Senses()
        {
            Name = "Keen Senses";
            Description = "Half-elves receive a +2 racial bonus on Perception checks.";
            //set up functionality
            return this;
        }

        public Racial_Trait Low_Light_Vision()
        {
            Name = "Low-Light Vision";
            Description = "Half-elves can see twice as far as humans in conditions of dim light.";
            return this;
        }

        public Racial_Trait Elf_Blood()
        {
            Name = "Elf Blood";
            Description = "Half-elves count as both elves and humans for any effect related to race.";
            return this;
        }

        public Racial_Trait Multitalented()
        {
            Name = "Multitalented";
            Description = "Half-elves choose two favored classes at first level and gain +1 hit point or +1 skill point whenever they take a level in either one of those classes.";
            //set up functionality
            return this;
        }

        //Here goes alternate traits
    }
}

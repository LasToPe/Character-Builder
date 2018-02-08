using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Races.Core.Racial_Traits
{
    class Half_orc_Racial_Trait : Racial_Trait
    {
        //Standard Traits
        public Racial_Trait Intimidating()
        {
            Name = "Intimidating";
            Description = "Half-orcs receive a +2 racial bonus on Intimidate checks due to their fearsome nature.";
            //set up functionality
            return this;
        }

        public Racial_Trait Orc_Ferocity()
        {
            Name = "Orc Ferocity";
            Description = "Once per day, when a half-orc is brought below 0 hit points but not killed, he can fight on for 1 more round as if disabled. At the end of his next turn, unless brought to above 0 hit points, he immediately falls unconscious and begins dying.";
            return this;
        }

        public Racial_Trait Weapon_Familiarity()
        {
            Name = "Weapon Familiarity";
            Description = "Half-orcs are proficient with greataxes and falchions and treat any weapon with the word “orc” in its name as a martial weapon.";
            //set up functionality
            return this;
        }

        public Racial_Trait Darkvision()
        {
            Name = "Darkvision";
            Description = "Half-orcs can see in the dark up to 60 feet.";
            return this;
        }

        public Racial_Trait Orc_Blood()
        {
            Name = "Orc Blood";
            Description = "Half-orcs count as both humans and orcs for any effect related to race.";
            return this;
        }

        //here goes alternate traits
    }
}

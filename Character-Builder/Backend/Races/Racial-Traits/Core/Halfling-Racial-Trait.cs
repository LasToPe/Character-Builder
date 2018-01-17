using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Races.Racial_Traits.Core
{
    class Halfling_Racial_Trait : Racial_Trait
    {
        //Stadard Traits
        public Racial_Trait Fearless()
        {
            Name = "Fearless";
            Description = "Halflings receive a +2 racial bonus on all saving throws against fear. This bonus stacks with the bonus granted by halfling luck.";
            return this;
        }

        public Racial_Trait Halfling_Luck()
        {
            Name = "Halfling Luck";
            Description = "Halflings receive a +1 racial bonus on all saving throws.";
            //set up functionality
            return this;
        }

        public Racial_Trait Sure_Footed()
        {
            Name = "Sure-Footed";
            Description = "Halflings receive a +2 racial bonus on Acrobatics and Climb checks.";
            //set up functionality
            return this;
        }

        public Racial_Trait Weapon_Familiarity()
        {
            Name = "Weapon Familiarity";
            Description = "Halflings are proficient with slings and treat any weapon with the word “halfling” in its name as a martial weapon.";
            //set up functionality
            return this;
        }

        public Racial_Trait Keen_Senses()
        {
            Name = "Keen Senses";
            Description = "Halflings receive a +2 racial bonus on Perception checks.";
            //set up functionality
            return this;
        }

        //here goes alternate traits
    }
}

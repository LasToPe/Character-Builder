using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Races.Core.Racial_Traits
{
    class Human_Racial_Trait : Racial_Trait
    {
        //Standard Traits
        public Racial_Trait Bonus_Feat()
        {
            Name = "Bonus Feat";
            Description = "Humans select one extra feat at 1st level.";
            return this;
        }

        public Racial_Trait Skilled()
        {
            Name = "Skilled";
            Description = "Humans gain an additional skill rank at first level and one additional rank whenever they gain a level.";
            //set up functionality
            return this;
        }

        //here goes alternate traits
    }
}

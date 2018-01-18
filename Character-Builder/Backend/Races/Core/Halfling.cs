using System;
using System.Collections.Generic;
using System.Text;
using Backend.Races.Core.Racial_Traits;

namespace Backend.Races.Core
{
    class Halfling : Race
    {
        public Halfling()
        {
            Strength_Bonus = -2;
            Dexterity_Bonus = 2;
            Charisma_Bonus = 2;

            Size = Size.Small();

            Type = "Humanoid (halfling)";

            Base_Speed = 20;

            Langauges.Add("Common");
            Langauges.Add("Halfling");

            Racial_Traits.Add(new Halfling_Racial_Trait().Fearless());
            Racial_Traits.Add(new Halfling_Racial_Trait().Halfling_Luck());
            Racial_Traits.Add(new Halfling_Racial_Trait().Sure_Footed());
            Racial_Traits.Add(new Halfling_Racial_Trait().Weapon_Familiarity());
            Racial_Traits.Add(new Halfling_Racial_Trait().Keen_Senses());
        }
    }
}

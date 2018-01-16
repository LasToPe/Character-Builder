using Backend.Races.Racial_Traits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Races
{
    class Gnome : Race
    {
        public Gnome()
        {
            Strength_Bonus = -2;
            Constitution_Bonus = 2;
            Charisma_Bonus = 2;

            Size = Size.Small();

            Type = "Humanoid (gnome)";

            Base_Speed = 20;

            Langauges.Add("Common");
            Langauges.Add("Gnome");
            Langauges.Add("Sylvan");

            Racial_Traits.Add(new Gnome_Racial_Trait().Defensive_Training());
            Racial_Traits.Add(new Gnome_Racial_Trait().Illusion_Resistance());
            Racial_Traits.Add(new Gnome_Racial_Trait().Keen_Senses());
            Racial_Traits.Add(new Gnome_Racial_Trait().Obsessive());
            Racial_Traits.Add(new Gnome_Racial_Trait().Gnome_Magic());
            Racial_Traits.Add(new Gnome_Racial_Trait().Hatred());
            Racial_Traits.Add(new Gnome_Racial_Trait().Weapon_Familiarity());
            Racial_Traits.Add(new Gnome_Racial_Trait().Low_Light_Vision());
        }
    }
}

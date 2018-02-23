using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Races.Core.Racial_Traits;

namespace PF_Character.Races.Core
{
    public class Gnome : Race
    {
        public Gnome(Character character) : base(character)
        {
            Strength_Bonus = -2;
            Constitution_Bonus = 2;
            Charisma_Bonus = 2;

            Race_Name = "Gnome";

            Size = new Size().Small();

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

        public override void SetBonus(string Bonus)
        {
            //Do Nothing!
        }
    }
}

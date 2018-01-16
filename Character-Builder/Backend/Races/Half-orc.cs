using Backend.Races.Racial_Traits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Races
{
    class Half_orc : Race
    {
        public Half_orc(string bonus)
        {
            switch (bonus)
            {
                case "Strength":
                    Strength_Bonus = 2;
                    break;
                case "Dexterity":
                    Dexterity_Bonus = 2;
                    break;
                case "Constitution":
                    Constitution_Bonus = 2;
                    break;
                case "Intelligence":
                    Intelligence_Bonus = 2;
                    break;
                case "Wisdom":
                    Wisdom_Bonus = 2;
                    break;
                case "Charisma":
                    Charisma_Bonus = 2;
                    break;
                default:
                    break;
            }

            Size = Size.Medium();

            Type = "Humanoid (human, orc)";

            Base_Speed = 30;

            Langauges.Add("Common");
            Langauges.Add("Orc");

            Racial_Traits.Add(new Half_orc_Racial_Trait().Intimidating());
            Racial_Traits.Add(new Half_orc_Racial_Trait().Orc_Ferocity());
            Racial_Traits.Add(new Half_orc_Racial_Trait().Weapon_Familiarity());
            Racial_Traits.Add(new Half_orc_Racial_Trait().Darkvision());
            Racial_Traits.Add(new Half_orc_Racial_Trait().Orc_Blood());
        }
    }
}

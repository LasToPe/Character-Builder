using Backend.Races.Racial_Traits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Races
{
    class Human : Race
    {
        public Human(string bonus) : base()
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

            Type = "Humanoid (human)";

            Base_Speed = 30;

            Langauges.Add("Common");

            Racial_Traits.Add(new Human_Racial_Trait().Bonus_Feat());
            Racial_Traits.Add(new Human_Racial_Trait().Skilled());
        }
    }
}

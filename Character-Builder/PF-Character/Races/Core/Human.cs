using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Races.Core.Racial_Traits;

namespace PF_Character.Races.Core
{
    public class Human : Race
    {
        public Human(string bonus, Character character) : base(character)
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

            Size = new Size().Medium();

            Type = "Humanoid (human)";

            Base_Speed = 30;

            Langauges.Add("Common");

            Racial_Traits.Add(new Human_Racial_Trait().Bonus_Feat());
            Racial_Traits.Add(new Human_Racial_Trait().Skilled());
        }
    }
}

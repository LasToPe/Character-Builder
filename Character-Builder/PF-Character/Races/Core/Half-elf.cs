using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Races.Core.Racial_Traits;

namespace PF_Character.Races.Core
{
    public class Half_elf : Race
    {
        public Half_elf(string bonus, Character character) : base(character)
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

            Race_Name = "Half elf";

            Size = new Size().Medium();

            Type = "Humanoid (human, elf)";

            Base_Speed = 30;

            Langauges.Add("Common");
            Langauges.Add("Elven");

            Racial_Traits.Add(new Half_elf_Racial_Trait().Elven_Immunities());
            Racial_Traits.Add(new Half_elf_Racial_Trait().Adaptability());
            Racial_Traits.Add(new Half_elf_Racial_Trait().Keen_Senses());
            Racial_Traits.Add(new Half_elf_Racial_Trait().Low_Light_Vision());
            Racial_Traits.Add(new Half_elf_Racial_Trait().Elf_Blood());
            Racial_Traits.Add(new Half_elf_Racial_Trait().Multitalented());
        }

        public override void SetBonus(string bonus)
        {
            switch (bonus)
            {
                case "Strength":
                    Strength_Bonus = 2;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 0;
                    break;
                case "Dexterity":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 2;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 0;
                    break;
                case "Constitution":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 2;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 0;
                    break;
                case "Intelligence":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 2;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 0;
                    break;
                case "Wisdom":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 2;
                    Charisma_Bonus = 0;
                    break;
                case "Charisma":
                    Strength_Bonus = 0;
                    Dexterity_Bonus = 0;
                    Constitution_Bonus = 0;
                    Intelligence_Bonus = 0;
                    Wisdom_Bonus = 0;
                    Charisma_Bonus = 2;
                    break;
                default:
                    break;
            }
        }
    }
}

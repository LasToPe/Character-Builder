using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Races.Core.Racial_Traits;

namespace PF_Character.Races.Core
{
    class Half_elf : Race
    {
        public Half_elf(string bonus)
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
    }
}

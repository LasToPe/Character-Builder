using System;
using System.Collections.Generic;
using System.Text;
using Backend.Races.Racial_Traits.Core;

namespace Backend.Races
{
    class Core_Races : Race
    {
        public Race Dwarf()
        {
            Constitution_Bonus = 2;
            Wisdom_Bonus = 2;
            Charisma_Bonus = -2;

            Size = Size.Medium();

            Type = "Humanoid (dwarf)";

            Base_Speed = 20;

            Langauges.Add("Common");
            Langauges.Add("Dwarven");

            Racial_Traits.Add(new Dwarf_Racial_Trait().Defensive_Training());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Hardy());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Stability());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Greed());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Stonecunning());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Darkvision());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Hatred());
            Racial_Traits.Add(new Dwarf_Racial_Trait().Weapon_Familiarity());

            return this;
        }

        public Race Elf()
        {
            Dexterity_Bonus = 2;
            Constitution_Bonus = -2;
            Intelligence_Bonus = 2;

            Size = Size.Medium();

            Type = "Humanoid (elf)";

            Base_Speed = 30;

            Langauges.Add("Common");
            Langauges.Add("Elven");

            Racial_Traits.Add(new Elf_Racial_Trait().Elven_Immunities());
            Racial_Traits.Add(new Elf_Racial_Trait().Keen_Senses());
            Racial_Traits.Add(new Elf_Racial_Trait().Elven_Magic());
            Racial_Traits.Add(new Elf_Racial_Trait().Weapon_Familiarity());
            Racial_Traits.Add(new Elf_Racial_Trait().Low_Light_Vision());

            return this;
        }

        public Race Gnome()
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

            return this;
        }

        public Race Half_elf(string bonus)
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

            return this;
        }

        public Race Halfling()
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

            return this;
        }

        public Race Half_orc(string bonus)
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

            return this;
        }

        public Race Human(string bonus)
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

            return this;
        }
    }
}

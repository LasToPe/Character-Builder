using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Races.Racial_Traits.Core
{
    public class Dwarf_Racial_Trait : Racial_Trait
    {
        //Standard Traits
        public Racial_Trait Defensive_Training()
        {
            Name = "Defensive Training";
            Description = "Dwarves gain a +4 dodge bonus to AC against monsters of the giant subtype.";
            return this;
        }

        public Racial_Trait Hardy()
        {
            Name = "Hardy";
            Description = "Dwarves gain a +2 racial bonus on saving throws against poison, spells, and spell-like abilities.";
            return this;
        }

        public Racial_Trait Stability()
        {
            Name = "Stability";
            Description = "Dwarves gain a +4 racial bonus to their Combat Maneuver Defense when resisting a bull rush or trip attempt while standing on the ground.";
            return this;
        }

        public Racial_Trait Greed()
        {
            Name = "Greed";
            Description = "Dwarves gain a +2 racial bonus on Appraise checks made to determine the price of non-magical goods that contain precious metals or gemstones.";
            return this;
        }

        public Racial_Trait Stonecunning()
        {
            Name = "Stonecunning";
            Description = "Dwarves gain a +2 bonus on Perception checks to notice unusual stonework, such as traps and hidden doors located in stone walls or floors. They receive a check to notice such features whenever they pass within 10 feet of them, whether or not they are actively looking.";
            return this;
        }

        public Racial_Trait Darkvision()
        {
            Name = "Darkvision";
            Description = "Dwarves can see perfectly in the dark up to 60 feet.";
            return this;
        }

        public Racial_Trait Hatred()
        {
            Name = "Hatred";
            Description = "Dwarves gain a +1 racial bonus on attack rolls against humanoid creatures of the orc and goblinoid subtypes because of their special training against these hated foes.";
            return this;
        }

        public Racial_Trait Weapon_Familiarity()
        {
            Name = "Weapon Familiarity";
            Description = "Dwarves are proficient with battleaxes, heavy picks, and warhammers, and treat any weapon with the word “dwarven” in its name as a martial weapon.";
            //set up functionality!
            return this;
        }

        //Here goes Alternate Traits
    }
}

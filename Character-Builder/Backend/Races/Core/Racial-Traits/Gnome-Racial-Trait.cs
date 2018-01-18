using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Races.Core.Racial_Traits
{
    class Gnome_Racial_Trait : Racial_Trait
    {
        //Standard Traits
        public Racial_Trait Defensive_Training()
        {
            Name = "Defensive Training";
            Description = "Gnomes gain a +4 dodge bonus to AC against monsters of the giant subtype.";
            return this;
        }

        public Racial_Trait Illusion_Resistance()
        {
            Name = "Illusion Resistance";
            Description = "Gnomes gain a +2 racial saving throw bonus against illusion spells and effects.";
            return this;
        }

        public Racial_Trait Keen_Senses()
        {
            Name = "Keen Senses";
            Description = "Gnomes receive a +2 racial bonus on Perception checks.";
            //set up functionality
            return this;
        }

        public Racial_Trait Obsessive()
        {
            Name = "Obsessive";
            Description = "Gnomes receive a +2 racial bonus on a Craft or Profession skill of their choice.";
            return this;
        }

        public Racial_Trait Gnome_Magic()
        {
            Name = "Gnome Magic";
            Description = "Gnomes add +1 to the DC of any saving throws against illusion spells that they cast. Gnomes with Charisma scores of 11 or higher also gain the following spell-like abilities: 1/day—dancing lights, ghost sound, prestidigitation, and speak with animals. The caster level for these effects is equal to the gnome’s level. The DC for these spells is equal to 10 + the spell’s level + the gnome’s Charisma modifier.";
            return this;
        }

        public Racial_Trait Hatred()
        {
            Name = "Hatred";
            Description = "Gnomes receive a +1 bonus on attack rolls against humanoid creatures of the reptilian and goblinoid subtypes because of their special training against these hated foes.";
            return this;
        }

        public Racial_Trait Weapon_Familiarity()
        {
            Name = "Weapon Familiarity";
            Description = "Gnomes treat any weapon with the word “gnome” in its name as a martial weapon.";
            //set up functionality
            return this;
        }

        public Racial_Trait Low_Light_Vision()
        {
            Name = "Low-Light Vision";
            Description = "Gnomes can see twice as far as humans in conditions of dim light.";
            return this;
        }

        //Here goes alternate traits
    }
}

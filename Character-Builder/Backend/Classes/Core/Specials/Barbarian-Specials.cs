using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PF_Character.Classes.Core.Specials
{
    public class Barbarian_Specials : Special
    {
        public Special Fast_Movement(Character character)
        {
            Name = "Fast Movement";
            Description = "A barbarian’s land speed is faster than the norm for her race by +10 feet. This benefit applies only when he is wearing no armor, light armor, or medium armor, and not carrying a heavy load. Apply this bonus before modifying the barbarian’s speed because of any load carried or armor worn. This bonus stacks with any other bonuses to the barbarian’s land speed.";
            //set up functionality
            return this;
        }

        public Special Rage()
        {
            Name = "Rage";
            Description =
                "A barbarian can call upon inner reserves of strength and ferocity, granting her additional combat prowess. Starting at 1st level, a barbarian can rage for a number of rounds per day equal to 4 + her Constitution modifier. At each level after 1st, she can rage for 2 additional rounds. Temporary increases to Constitution, such as those gained from rage and spells like bear’s endurance, do not increase the total number of rounds that a barbarian can rage per day. A barbarian can enter rage as a free action. The total number of rounds of rage per day is renewed after resting for 8 hours, although these hours do not need to be consecutive."
                + "\n\n" +
                "While in rage, a barbarian gains a +4 morale bonus to her Strength and Constitution, as well as a +2 morale bonus on Will saves. In addition, she takes a –2 penalty to Armor Class. The increase to Constitution grants the barbarian 2 hit points per Hit Dice, but these disappear when the rage ends and are not lost first like temporary hit points. While in rage, a barbarian cannot use any Charisma-, Dexterity-, or Intelligence-based skills (except Acrobatics, Fly, Intimidate, and Ride) or any ability that requires patience or concentration."
                + "\n\n" +
                "A barbarian can end her rage as a free action and is fatigued after rage for a number of rounds equal to 2 times the number of rounds spent in the rage. A barbarian cannot enter a new rage while fatigued or exhausted but can otherwise enter rage multiple times during a single encounter or combat. If a barbarian falls unconscious, her rage immediately ends, placing her in peril of death.";

            return this;
        }

        public Special Rage_Powers(Barbarian barbarian)
        {
            Name = "Rage Powers";
            Description =
                "As a barbarian gains levels, she learns to use her rage in new ways. Starting at 2nd level, a barbarian gains a rage power. She gains another rage power for every two levels of barbarian attained after 2nd level. A barbarian gains the benefits of rage powers only while raging, and some of these powers require the barbarian to take an action first. Unless otherwise noted, a barbarian cannot select an individual power more than once."
                + "\n\n" +
                "Any barbarian who meets the powers’ prerequisites can select and use rage powers. Totem rage powers grant powers related to a theme. A barbarian cannot select from more than one group of totem rage powers; for example, a barbarian who selects a beast totem rage power cannot later choose to gain any of the dragon totem rage powers (any rage power with “dragon totem” in its title).";
            //set up functionality
            return this;
        }

        public Special Uncanny_Dodge()
        {
            Name = "Uncanny Dodge";
            Description =
                "At 2nd level, a barbarian gains the ability to react to danger before her senses would normally allow her to do so. She cannot be caught flat-footed, nor does she lose her Dex bonus to AC if the attacker is invisible. She still loses her Dexterity bonus to armor class if immobilized. A barbarian with this ability can still lose her Dexterity bonus to armor class if an opponent successfully uses the feint action against her."
                + "\n\n" +
                "If a barbarian already has uncanny dodge from a different class, she automatically gains improved uncanny dodge (see below) instead.";
            return this;
        }

        public Special Trap_Sense(Barbarian barbarian)
        {
            int bonus = barbarian.Level / 3;
            Name = "Trap Sense +" + bonus;
            Description = "At 3rd level, a barbarian gains a +1 bonus on Reflex saves made to avoid traps and a +1 dodge bonus to armor class against attacks made by traps. These bonuses increase by +1 every three barbarian levels thereafter (6th, 9th, 12th, 15th, and 18th level). Trap sense bonuses gained from multiple classes stack.";
            return this;
        }

        public Special Improved_Uncanny_Dodge()
        {
            Name = "Improved Uncanny Dodge";
            Description =
                "At 5th level and higher, a barbarian can no longer be flanked. This defense denies a rogue the ability to sneak attack the barbarian by flanking her, unless the attacker has at least four more rogue levels than the target has barbarian levels."
                + "\n\n" +
                "If a character already has uncanny dodge (see above) from another class, the levels from the classes that grant uncanny dodge stack to determine the minimum rogue level required to flank the character.";
            return this;
        }

        public Special Damage_Reduction(Character character, Barbarian barbarian)
        {
            int bonus = (barbarian.Level - 7) / 3 + 1;
            Name = "Damage Reduction " + bonus + "/-";
            Description = "At 7th level, a barbarian gains damage reduction. Subtract 1 from the damage the barbarian takes each time she is dealt damage from a weapon or a natural attack. At 10th level, and every three barbarian levels thereafter (13th, 16th, and 19th level), this damage reduction rises by 1 point. Damage reduction can reduce damage to 0 but not below 0.";
            //set up functionality (DR on character)
            return this;
        }

        public Special Greater_Rage()
        {
            Name = "Greater Rage";
            Description = "At 11th level, when a barbarian enters rage, the morale bonus to her Strength and Constitution increases to +6 and the morale bonus on her Will saves increases to +3.";
            return this;
        }

        public Special Indomitable_Will()
        {
            Name = "Indomitable Will";
            Description = "While in rage, a barbarian of 14th level or higher gains a +4 bonus on Will saves to resist enchantment spells. This bonus stacks with all other modifiers, including the morale bonus on Will saves she also receives during her rage.";
            return this;
        }

        public Special Tireless_Rage()
        {
            Name = "Tireless Rage";
            Description = "Starting at 17th level, a barbarian no longer becomes fatigued at the end of her rage.";
            return this;
        }

        public Special Mighty_Rage()
        {
            Name = "Mighty Rage";
            Description = "At 20th level, when a barbarian enters rage, the morale bonus to her Strength and Constitution increases to +8 and the morale bonus on her Will saves increases to +4.";
            return this;
        }
    }
}

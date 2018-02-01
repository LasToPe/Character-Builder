using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Classes.Core.Specials
{
    class Rogue_Specials : Special
    {
        public Special Sneak_Attack(Rogue rogue)
        {
            int dice = (rogue.Level - 1) / 2 + 1;
            Name = "Sneak Attack +" + dice + "d6";
            Description = "If a rogue can catch an opponent when he is unable to defend himself effectively from her attack, she can strike a vital spot for extra damage."
                + "\n\n" +
                "The rogue’s attack deals extra damage anytime her target would be denied a Dexterity bonus to AC (whether the target actually has a Dexterity bonus or not), or when the rogue flanks her target. This extra damage is 1d6 at 1st level, and increases by 1d6 every two rogue levels thereafter. Should the rogue score a critical hit with a sneak attack, this extra damage is not multiplied. Ranged attacks can count as sneak attacks only if the target is within 30 feet."
                + "\n\n" +
                "With a weapon that deals nonlethal damage (like a sap, whip, or an unarmed strike), a rogue can make a sneak attack that deals nonlethal damage instead of lethal damage. She cannot use a weapon that deals lethal damage to deal nonlethal damage in a sneak attack, not even with the usual –4 penalty."
                + "\n\n" +
                "The rogue must be able to see the target well enough to pick out a vital spot and must be able to reach such a spot. A rogue cannot sneak attack while striking a creature with concealment.";
            return this;
        }

        public Special Trapfinding(Rogue rogue)
        {
            int bonus;
            if(rogue.Level == 1) { bonus = 1; } else { bonus = rogue.Level / 2; }

            Name = "Trapfinding +" + bonus;
            Description = "A rogue adds 1/2 her level to Perception skill checks made to locate traps and to Disable Device skill checks (minimum +1). A rogue can use Disable Device to disarm magic traps.";
            return this;
        }

        public Special Evasion()
        {
            Name = "Evasion";
            Description = "At 2nd level and higher, a rogue can avoid even magical and unusual attacks with great agility. If she makes a successful Reflex saving throw against an attack that normally deals half damage on a successful save, she instead takes no damage. Evasion can be used only if the rogue is wearing light armor or no armor. A helpless rogue does not gain the benefit of evasion.";
            return this;
        }

        public Special Rogue_Talent() // set up rogue talents
        {
            Name = "Rogue Talent";
            Description = "As a rogue gains experience, she learns a number of talents that aid her and confound her foes. Starting at 2nd level, a rogue gains one rogue talent. She gains an additional rogue talent for every 2 levels of rogue attained after 2nd level. A rogue cannot select an individual talent more than once.";
            //functionality for choosing
            return this;
        }

        public Special Trap_Sense(Rogue rogue)
        {
            int bonus = (rogue.Level - 3) / 3 + 1;
            Name = "Trap Sense +" + bonus;
            Description = "At 3rd level, a rogue gains an intuitive sense that alerts her to danger from traps, giving her a +1 bonus on Reflex saves made to avoid traps and a +1 dodge bonus to AC against attacks made by traps. These bonuses rise to +2 when the rogue reaches 6th level, to +3 when she reaches 9th level, to +4 when she reaches 12th level, to +5 at 15th, and to +6 at 18th level. Trap sense bonuses gained from multiple classes stack.";
            return this;
        }

        public Special Uncanny_Dodge()
        {
            Name = "Uncanny Dodge";
            Description = "Starting at 4th level, a rogue can react to danger before her senses would normally allow her to do so. She cannot be caught flat-footed, nor does she lose her Dex bonus to AC if the attacker is invisible. She still loses her Dexterity bonus to AC if immobilized. A rogue with this ability can still lose her Dexterity bonus to AC if an opponent successfully uses the feint action (see Combat) against her."
                + "\n\n" +
                "If a rogue already has uncanny dodge from a different class, she automatically gains improved uncanny dodge (see below) instead."; //howto??
            return this;
        }
        public Special Improved_Uncanny_Dodge()
        {
            Name = "Improved Uncanny Dodge";
            Description = "A rogue of 8th level or higher can no longer be flanked."
                + "\n\n" +
                "This defense denies another rogue the ability to sneak attack the character by flanking her, unless the attacker has at least four more rogue levels than the target does."
                + "\n\n" +
                "If a character already has uncanny dodge (see above) from another class, the levels from the classes that grant uncanny dodge stack to determine the minimum rogue level required to flank the character.";
            return this;
        }

        public Special Advanced_Talents() //set up advanced talents
        {
            Name = "Advanced Talents";
            Description = "At 10th level, and every two levels thereafter, a rogue can choose one of the following advanced talents in place of a rogue talent.";
            //functionality
            return this;
        }

        public Special Master_Strike()
        {
            Name = "Master Strike";
            Description = "Upon reaching 20th level, a rogue becomes incredibly deadly when dealing sneak attack damage. Each time the rogue deals sneak attack damage, she can choose one of the following three effects:"
                + "\n\n" +
                "put to sleep for 1d4 hours"
                + "\n\n" +
                "paralyzed for 2d6 rounds"
                + "\n\n" +
                "slain"
                + "\n\n" +
                "Regardless of the effect chosen, the target receives a Fortitude save to negate the additional effect. The DC of this save is equal to 10 + 1/2 the rogue’s level + the rogue’s Intelligence modifier. Once a creature has been the target of a master strike, regardless of whether or not the save is made, that creature is immune to that rogue’s master strike for 24 hours. Creatures that are immune to sneak attack damage are also immune to this ability.";
            return this;
        }
    }
}

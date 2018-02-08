using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Classes.Core.Specials
{
    public class Cleric_Specials : Special
    {
        public Special Aura()
        {
            Name = "Aura";
            Description = "A cleric of a chaotic, evil, good, or lawful deity has a particularly powerful aura corresponding to the deity’s alignment.";
            return this;
        }

        public Special Channel_Energy(Cleric cleric)
        {
            int value = (cleric.Level - 1) / 2 + 1;
            Name = "Channel Energy " + value + "d6";
            Description = "Regardless of alignment, any cleric can release a wave of energy by channeling the power of her faith through her holy (or unholy) symbol. This energy can be used to cause or heal damage, depending on the type of energy channeled and the creatures targeted."
                + "\n\n" +
                "A good cleric (or a neutral cleric who worships a good deity) channels positive energy and can choose to deal damage to undead creatures or to heal living creatures. An evil cleric (or a neutral cleric who worships an evil deity) channels negative energy and can choose to deal damage to living creatures or to heal undead creatures. A neutral cleric of a neutral deity (or one who is not devoted to a particular deity) must choose whether she channels positive or negative energy. Once this choice is made, it cannot be reversed. This decision also determines whether the cleric can cast spontaneous cure or inflict spells (see spontaneous casting)."
                + "\n\n" +
                "Channeling energy causes a burst that affects all creatures of one type (either undead or living) in a 30-foot radius centered on the cleric. The amount of damage dealt or healed is equal to 1d6 points of damage plus 1d6 points of damage for every two cleric levels beyond 1st (2d6 at 3rd, 3d6 at 5th, and so on). Creatures that take damage from channeled energy receive a Will save to halve the damage. The DC of this save is equal to 10 + 1/2 the cleric’s level + the cleric’s Charisma modifier. Creatures healed by channel energy cannot exceed their maximum hit point total—all excess healing is lost. A cleric may channel energy a number of times per day equal to 3 + her Charisma modifier. This is a standard action that does not provoke an attack of opportunity. A cleric can choose whether or not to include herself in this effect."
                + "\n\n" +
                "A cleric must be able to present her holy symbol to use this ability.";
            return this;
        }

        public Special Domains(/*choices*/) //Domains need to set up
        {
            Name = "Domains";
            Description = "A cleric’s deity influences her alignment, what magic she can perform, her values, and how others see her. A cleric chooses two domains from among those belonging to her deity. A cleric can select an alignment domain (Chaos, Evil, Good, or Law) only if her alignment matches that domain. If a cleric is not devoted to a particular deity, she still selects two domains to represent her spiritual inclinations and abilities (subject to GM approval). The restriction on alignment domains still applies."
                + "\n\n" +
                "Each domain grants a number of domain powers, dependent upon the level of the cleric, as well as a number of bonus spells. A cleric gains one domain spell slot for each level of cleric spell she can cast, from 1st on up. Each day, a cleric can prepare one of the spells from her two domains in that slot. If a domain spell is not on the cleric spell list, a cleric can prepare it only in her domain spell slot. Domain spells cannot be used to cast spells spontaneously."
                + "\n\n" +
                "In addition, a cleric gains the listed powers from both of her domains, if she is of a high enough level. Unless otherwise noted, activating a domain power is a standard action.";
            //functionality -> spells + domain powers
            return this;
        }

        public Special Spontaneous_Casting()
        {
            Name = "Spontaneous Casting";
            Description = "A good cleric (or a neutral cleric of a good deity) can channel stored spell energy into healing spells that she did not prepare ahead of time. The cleric can “lose” any prepared spell that is not an orison or domain spell in order to cast any cure spell of the same spell level or lower (a cure spell is any spell with “cure” in its name)."
                + "\n\n" +
                "An evil cleric (or a neutral cleric of an evil deity) can’t convert prepared spells to cure spells but can convert them to inflict spells (an inflict spell is one with “inflict” in its name)."
                + "\n\n" +
                "A cleric who is neither good nor evil and whose deity is neither good nor evil can convert spells to either cure spells or inflict spells (player’s choice). Once the player makes this choice, it cannot be reversed. This choice also determines whether the cleric channels positive or negative energy (see channel energy).";
            return this;
        }

        public Special Bonus_Languages() //functionality?
        {
            Name = "Bonus Languages";
            Description = "A cleric’s bonus language options include Celestial, Abyssal, and Infernal (the languages of good, chaotic evil, and lawful evil outsiders, respectively). These choices are in addition to the bonus languages available to the character because of her race.";
            return this;
        }
    }
}

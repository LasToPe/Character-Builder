using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Classes.Core.Specials
{
    class Paladin_Specials : Special
    {
        public Special Aura_of_Good()
        {
            Name = "Aura of Good";
            Description = "The power of a paladin’s aura of good (see the detect good spell) is equal to her paladin level.";
            return this;
        }

        public Special Detect_Evil()
        {
            Name = "Detect Evil";
            Description = "At will, a paladin can use detect evil, as the spell. A paladin can, as a move action, concentrate on a single item or individual within 60 feet and determine if it is evil, learning the strength of its aura as if having studied it for 3 rounds. While focusing on one individual or object, the paladin does not detect evil in any other object or individual within range.";
            return this;
        }

        public Special Smite_Evil(Paladin paladin)
        {
            int uses = (paladin.Level - 1) / 3 + 1;
            Name = "Smite Evil (" + uses + "/day)";
            Description = "Once per day, a paladin can call out to the powers of good to aid her in her struggle against evil. As a swift action, the paladin chooses one target within sight to smite. If this target is evil, the paladin adds her Cha bonus (if any) to her attack rolls and adds her paladin level to all damage rolls made against the target of her smite. If the target of smite evil is an outsider with the evil subtype, an evil-aligned dragon, or an undead creature, the bonus to damage on the first successful attack increases to 2 points of damage per level the paladin possesses. Regardless of the target, smite evil attacks automatically bypass any DR the creature might possess."
                + "\n\n" +
                "In addition, while smite evil is in effect, the paladin gains a deflection bonus equal to her Charisma modifier (if any) to her AC against attacks made by the target of the smite. If the paladin targets a creature that is not evil, the smite is wasted with no effect."
                + "\n\n" +
                "The smite evil effect remains until the target of the smite is dead or the next time the paladin rests and regains her uses of this ability. At 4th level, and at every three levels thereafter, the paladin may smite evil one additional time per day.";
            return this;
        }

        public Special Divine_Grace(/*Character character*/)
        {
            Name = "Divine Grace";
            Description = "At 2nd level, a paladin gains a bonus equal to her Charisma bonus (if any) on all Saving Throws.";
            //functionality bonus
            return this;
        }

        public Special Lay_On_Hands(Paladin paladin)
        {
            int dice = paladin.Level / 2;
            //uses?
            Name = "Lay On Hands (" + dice + "d6)";
            Description = "Beginning at 2nd level, a paladin can heal wounds (her own or those of others) by touch. Each day she can use this ability a number of times equal to 1/2 her paladin level plus her Charisma modifier. With one use of this ability, a paladin can heal 1d6 hit points of damage for every two paladin levels she possesses. Using this ability is a standard action, unless the paladin targets herself, in which case it is a swift action. Despite the name of this ability, a paladin only needs one free hand to use this ability."
                + "\n\n" +
                "Alternatively, a paladin can use this healing power to deal damage to undead creatures, dealing 1d6 points of damage for every two levels the paladin possesses. Using lay on hands in this way requires a successful melee touch attack and doesn’t provoke an attack of opportunity. Undead do not receive a saving throw against this damage.";
            return this;
        }

        public Special Aura_of_Courage()
        {
            Name = "Aura of Courage";
            Description = "At 3rd level, a paladin is immune to fear (magical or otherwise). Each ally within 10 feet of her gains a +4 morale bonus on saving throws against fear effects. This ability functions only while the paladin is conscious, not if she is unconscious or dead.";
            return this;
        }

        public Special Divine_Health()
        {
            Name = "Divine Health";
            Description = "At 3rd level, a paladin is immune to all diseases, including supernatural and magical diseases, including mummy rot.";
            return this;
        }

        public Special Mercy() //set up mercies
        {
            Name = "Mercy";
            Description = "At 3rd level, and every three levels thereafter, a paladin can select one mercy. Each mercy adds an effect to the paladin’s lay on hands ability. Whenever the paladin uses lay on hands to heal damage to one target, the target also receives the additional effects from all of the mercies possessed by the paladin. A mercy can remove a condition caused by a curse, disease, or poison without curing the affliction. Such conditions return after 1 hour unless the mercy actually removes the affliction that causes the condition."
                + "\n\n" +
                "These abilities are cumulative. For example, a 12th-level paladin’s lay on hands ability heals 6d6 points of damage and might also cure Fatigued and Exhausted conditions as well as removing diseases and neutralizing poisons. Once a condition or spell effect is chosen, it can’t be changed.";
            //functionality
            return this;
        }

        public Special Channel_Positive_Energy(Paladin paladin)
        {
            int value = (paladin.Level - 1) / 2 + 1;
            Name = "Channel Positive Energy (" + value + "d6)";
            Description = "When a paladin reaches 4th level, she gains the supernatural ability to channel positive energy like a cleric. Using this ability consumes two uses of her lay on hands ability. A paladin uses her level as her effective cleric level when channeling positive energy. This is a Charisma-based ability.";
            return this;
        }

        public Special Spells() //setup somehow??
        {
            return this;
        }

        public Special Divine_Bond()
        {
            Name = "Divine Bond";
            Description = "Upon reaching 5th level, a paladin forms a divine bond with her god. This bond can take one of two forms. Once the form is chosen, it cannot be changed."
                + "\n\n" +
                "The first type of bond allows the paladin to enhance her weapon as a standard action by calling upon the aid of a celestial spirit for 1 minute per paladin level. When called, the spirit causes the weapon to shed light as a torch. At 5th level, this spirit grants the weapon a +1 enhancement bonus. For every three levels beyond 5th, the weapon gains another +1 enhancement bonus, to a maximum of +6 at 20th level. These bonuses can be added to the weapon, stacking with existing weapon bonuses to a maximum of +5, or they can be used to add any of the following weapon properties: axiomatic, brilliant energy, defending, disruption, flaming, flaming burst, holy, keen, merciful, and speed. Adding these properties consumes an amount of bonus equal to the property’s cost (see Table: Melee Weapon Special Abilities). These bonuses are added to any properties the weapon already has, but duplicate abilities do not stack. If the weapon is not magical, at least a +1 enhancement bonus must be added before any other properties can be added. The bonus and properties granted by the spirit are determined when the spirit is called and cannot be changed until the spirit is called again. The celestial spirit imparts no bonuses if the weapon is held by anyone other than the paladin but resumes giving bonuses if returned to the paladin. These bonuses apply to only one end of a double weapon. A paladin can use this ability once per day at 5th level, and one additional time per day for every four levels beyond 5th, to a total of four times per day at 17th level."
                + "\n\n" +
                "If a weapon bonded with a celestial spirit is destroyed, the paladin loses the use of this ability for 30 days, or until she gains a level, whichever comes first. During this 30-day period, the paladin takes a –1 penalty on attack and weapon damage rolls."
                + "\n\n" +
                "The second type of bond allows a paladin to gain the service of an unusually intelligent, strong, and loyal steed to serve her in her crusade against evil. This mount is usually a heavy horse (for a Medium paladin) or a pony (for a Small paladin), although more exotic mounts, such as a boar, camel, or dog are also suitable. This mount functions as a druid’s animal companion, using the paladin’s level as her effective druid level. Bonded mounts have an Intelligence of at least 6."
                + "\n\n" +
                "A Medium paladin can select a yak or zebra as a bonded mount. A Small paladin can select a capybara, eohippus, reindeer, or wolfdog as a bonded mount."
                + "\n\n" +
                "Once per day, as a full-round action, a paladin may magically call her mount to her side. This ability is the equivalent of a spell of a level equal to one-third the paladin’s level. The mount immediately appears adjacent to the paladin. A paladin can use this ability once per day at 5th level, and one additional time per day for every 4 levels thereafter, for a total of four times per day at 17th level."
                + "\n\n" +
                "At 11th level, the mount gains the celestial creature simple template and becomes a magical beast for the purposes of determining which spells affect it."
                + "\n\n" +
                "At 15th level, a paladin’s mount gains spell resistance equal to the paladin’s level + 11."
                + "\n\n" +
                "Should the paladin’s mount die, the paladin may not summon another mount for 30 days or until she gains a paladin level, whichever comes first. During this 30-day period, the paladin takes a –1 penalty on attack and weapon damage rolls.";
            //functionality
            return this;
        }

        public Special Aura_of_Resolve()
        {
            Name = "Aura of Resolve";
            Description = "At 8th level, a paladin is immune to charm spells and spell-like abilities. Each ally within 10 feet of her gains a +4 morale bonus on saving throws against charm effects. This ability functions only while the paladin is conscious, not if she is unconscious or dead.";
            return this;
        }

        public Special Aura_of_Justice()
        {
            Name = "Aura of Justice";
            Description = "At 11th level, a paladin can expend two uses of her smite evil ability to grant the ability to smite evil to all allies within 10 feet, using her bonuses. Allies must use this smite evil ability by the start of the paladin’s next turn and the bonuses last for 1 minute. Using this ability is a free action. Evil creatures gain no benefit from this ability.";
            return this;
        }

        public Special Aura_of_Faith()
        {
            Name = "Aura of Faith";
            Description = "At 14th level, a paladin’s weapons are treated as good-aligned for the purposes of overcoming Damage Reduction. Any attack made against an enemy within 10 feet of her is treated as good-aligned for the purposes of overcoming Damage Reduction. This ability functions only while the paladin is conscious, not if she is unconscious or dead.";
            return this;
        }

        public Special Aura_of_Righteousness()
        {
            Name = "Aura of Righteousness";
            Description = "At 17th level, a paladin gains DR 5/evil and immunity to compulsion spells and spell-like abilities. Each ally within 10 feet of her gains a +4 morale bonus on saving throws against compulsion effects. This ability functions only while the paladin is conscious, not if she is unconscious or dead.";
            //functionality DR 5/evil
            return this;
        }

        public Special Holy_Champion()
        {
            Name = "Holy Champion";
            Description = "At 20th level, a paladin becomes a conduit for the power of her god. Her DR increases to 10/evil. Whenever she uses smite evil and successfully strikes an evil outsider, the outsider is also subject to a banishment, using her paladin level as the caster level (her weapon and holy symbol automatically count as objects that the subject hates). After the banishment effect and the damage from the attack is resolved, the smite immediately ends. In addition, whenever she channels positive energy or uses lay on hands to heal a creature, she heals the maximum possible amount.";
            //functionality DR 10/evil
            return this;
        }
    }
}

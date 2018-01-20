using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Classes.Core.Class_Features
{
    public class Barbarian_Class_Features : Class_Feature
    {
        public Class_Feature Fast_Movement(Character character)
        {
            Name = "Fast Movement";
            Description = "A barbarian’s land speed is faster than the norm for her race by +10 feet. This benefit applies only when he is wearing no armor, light armor, or medium armor, and not carrying a heavy load. Apply this bonus before modifying the barbarian’s speed because of any load carried or armor worn. This bonus stacks with any other bonuses to the barbarian’s land speed.";
            //set up functionality
            return this;
        }

        public Class_Feature Rage()
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

        public Class_Feature Rage_Powers(Barbarian barbarian)
        {
            Name = "Rage Powers";
            Description =
                "As a barbarian gains levels, she learns to use her rage in new ways. Starting at 2nd level, a barbarian gains a rage power. She gains another rage power for every two levels of barbarian attained after 2nd level. A barbarian gains the benefits of rage powers only while raging, and some of these powers require the barbarian to take an action first. Unless otherwise noted, a barbarian cannot select an individual power more than once."
                + "\n\n" +
                "Any barbarian who meets the powers’ prerequisites can select and use rage powers. Totem rage powers grant powers related to a theme. A barbarian cannot select from more than one group of totem rage powers; for example, a barbarian who selects a beast totem rage power cannot later choose to gain any of the dragon totem rage powers (any rage power with “dragon totem” in its title).";
            //set up functionality
            return this;
        }

        public Class_Feature Uncanny_Dodge()
        {
            Name = "Uncanny Dodge";
            Description =
                "At 2nd level, a barbarian gains the ability to react to danger before her senses would normally allow her to do so. She cannot be caught flat-footed, nor does she lose her Dex bonus to AC if the attacker is invisible. She still loses her Dexterity bonus to armor class if immobilized. A barbarian with this ability can still lose her Dexterity bonus to armor class if an opponent successfully uses the feint action against her."
                + "\n\n" +
                "If a barbarian already has uncanny dodge from a different class, she automatically gains improved uncanny dodge (see below) instead.";
            return this;
        }

        public Class_Feature Trap_Sense(int bonus)
        {
            Name = "Trap Sense +" + bonus;
            Description = "At 3rd level, a barbarian gains a +1 bonus on Reflex saves made to avoid traps and a +1 dodge bonus to armor class against attacks made by traps. These bonuses increase by +1 every three barbarian levels thereafter (6th, 9th, 12th, 15th, and 18th level). Trap sense bonuses gained from multiple classes stack.";
            return this;
        }

        public Class_Feature Improved_Uncanny_Dodge()
        {
            Name = "Improved Uncanny Dodge";
            Description =
                "At 5th level and higher, a barbarian can no longer be flanked. This defense denies a rogue the ability to sneak attack the barbarian by flanking her, unless the attacker has at least four more rogue levels than the target has barbarian levels."
                + "\n\n" +
                "If a character already has uncanny dodge (see above) from another class, the levels from the classes that grant uncanny dodge stack to determine the minimum rogue level required to flank the character.";
            return this;
        }

        public Class_Feature Damage_Reduction(Character character, int bonus)
        {
            Name = "Damage Reduction " + bonus;
            Description = "At 7th level, a barbarian gains damage reduction. Subtract 1 from the damage the barbarian takes each time she is dealt damage from a weapon or a natural attack. At 10th level, and every three barbarian levels thereafter (13th, 16th, and 19th level), this damage reduction rises by 1 point. Damage reduction can reduce damage to 0 but not below 0.";
            //set up functionality (DR on character)
            return this;
        }

        public Class_Feature Greater_Rage()
        {
            Name = "Greater Rage";
            Description = "At 11th level, when a barbarian enters rage, the morale bonus to her Strength and Constitution increases to +6 and the morale bonus on her Will saves increases to +3.";
            return this;
        }

        public Class_Feature Indomitable_Will()
        {
            Name = "Indomitable Will";
            Description = "While in rage, a barbarian of 14th level or higher gains a +4 bonus on Will saves to resist enchantment spells. This bonus stacks with all other modifiers, including the morale bonus on Will saves she also receives during her rage.";
            return this;
        }

        public Class_Feature Tireless_Rage()
        {
            Name = "Tireless Rage";
            Description = "Starting at 17th level, a barbarian no longer becomes fatigued at the end of her rage.";
            return this;
        }

        public Class_Feature Mighty_Rage()
        {
            Name = "Mighty Rage";
            Description = "At 20th level, when a barbarian enters rage, the morale bonus to her Strength and Constitution increases to +8 and the morale bonus on her Will saves increases to +4.";
            return this;
        }
    }

    public class Rage_Power
    {
        public string Name { get; set; }
        public List<bool> Prerequisites { get; }
        public string Benefit { get; set; }

        public Rage_Power()
        {
        }
    }

    public class Barbarian_Rage_Powers : Rage_Power
    {
        public Rage_Power Animal_Fury()
        {
            Name = "Animal Fury";
            Benefit = "Gain a bite attack";
            //functionality
            return this;
        }

        public Rage_Power Armor_Ripper()
        {
            Name = "Armor Ripper";
            Benefit = "Gain a bonus to Sunder checks with your natural attacks while raging";
            return this;
        }

        public Rage_Power Lesser_Atavism_Totem(Barbarian barbarian)
        {
            Name = "Atavism Totem, Lesser";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "You gain a bite attack; or if you already have a bite attack, it deals damage as if you were one size larger.";
            //functionality
            return this;
        }

        public Rage_Power Atavism_Totem(Barbarian barbarian)
        {
            Name = "Atavism Totem";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Lesser_Atavism_Totem(barbarian)));
            Benefit = "You gain the ferocity ability.";
            return this;
        }

        public Rage_Power Greater_Atavism_Totem(Barbarian barbarian)
        {
            Name = "Atavism Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Atavism_Totem(barbarian)));
            Benefit = "You gain the trample ability.";
            return this;
        }

        public Rage_Power Auspicious_Mark()
        {
            Name = "Auspicious Mark";
            Benefit = "Gain a bonus on a roll once per rage";
            return this;
        }

        public Rage_Power Battle_Roar(Barbarian barbarian)
        {
            Name = "Battle Roar";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //Intimidating Glare
            Benefit = "You deal an additional 1d6 points of sonic damage to an opponent you successfully demoralized using intimidating glare.";
            return this;
        }

        public Rage_Power Lesser_Beast_Totem(Barbarian barbarian)
        {
            Name = "Beast Totem, Lesser";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "Gain two claw attacks"; //1d6
            return this;
        }

        public Rage_Power Beast_Totem(Barbarian barbarian)
        {
            Name = "Beast Totem";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Lesser_Beast_Totem(barbarian)));
            Benefit = "Gain a natural armor bonus"; // +1 per 4 levels
            return this;
        }

        public Rage_Power Greater_Beast_Totem(Barbarian barbarian)
        {
            Name = "Beast Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Beast_Totem(barbarian)));
            Benefit = "Gain a pounce attack"; //and claws 1d8 crit x3
            //functionality 
            return this;
        }

        public Rage_Power Bestial_Climber(Barbarian barbarian)
        {
            Name = "Bestial Climber";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //raging climber
            Benefit = "Climb at your normal land speed while raging";
            return this;
        }

        public Rage_Power Bestial_Leaper(Barbarian barbarian)
        {
            Name = "Bestial Leaper";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //raging leaper
            Benefit = "Take a standard action while moving during a rage";
            return this;
        }

        public Rage_Power Bestial_Swimmer(Barbarian barbarian)
        {
            Name = "Bestial Swimmer";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //raging swimmer
            Benefit = "Swim at your normal land speed while raging";
            return this;
        }

        public Rage_Power Bleeding_Blow(Barbarian barbarian)
        {
            Name = "Bleeding Blow";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //powerful blow
            Benefit = "Deal bleed damage with your powerful blows";
            return this;
        }

        public Rage_Power Bloody_Bite(Barbarian barbarian, Character character)
        {
            Name = "Bloody Bite";
            Prerequisites.Add(character.Race is Races.Core.Half_orc);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Animal_Fury())); // or other natural bite
            Benefit = "Your bite attack deals 1d6 points of bleed damage in addition to its other effects.";
            return this;
        }

        public Rage_Power Bloody_Fist(Barbarian barbarian)
        {
            Name = "Bloody Fist";
            Prerequisites.Add(barbarian.Level >= 12);
            Benefit = "Once per rage, the barbarian may attempt to punch through an opponent’s flesh and rip out one of its vital organs. In order to do so, the barbarian must confirm a critical hit against an opponent with a natural attack or unarmed strike. The barbarian deals damage as normal for a critical hit and the opponent must succeed at a Fortitude save (DC = 10 + 1/2 the barbarian’s class level + the barbarian’s Strength modifier) or take 1d4 points of Constitution damage as one of its vital organs is ripped free from its body.";
            return this;
        }

        public Rage_Power Boars_Charge(Barbarian barbarian)
        {
            Name = "Boar's Charge";
            Prerequisites.Add(barbarian.Level >= 12);
            Benefit = "Automatically score critical hits with your gore attack while raging";
            return this;
        }

        public Rage_Power Boasting_Taunt(Barbarian barbarian)
        {
            Name = "Boasting Taunt";
            Prerequisites.Add(barbarian.Level >= 6);
            Benefit = "Force an enemy to attack the barbarian";
            return this;
        }

        public Rage_Power Body_Bludgeon(Barbarian barbarian)
        {
            Name = "Body Bludgeon";
            Prerequisites.Add(barbarian.Level >= 10);
            Benefit = "Beat a foe with another creature";
            return this;
        }

        public Rage_Power Brawler()
        {
            Name = "Brawler";
            Benefit = "Gain Improved Unarmed Strike while raging"; //if IUS 1d6
            return this;
        }

        public Rage_Power Greater_Brawler(Barbarian barbarian)
        {
            Name = "Brawler, Greater";
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Brawler()));
            Benefit = "Gain Two-Weapon Fighting while raging";
            return this;
        }

        public Rage_Power Breathtaker()
        {
            Name = "Breathtaker";
            Benefit = "While raging, whenever you make a successful melee attack against an opponent that is holding its breath, in addition to any other effects caused by that attack, the opponent loses a number of rounds of breath equal to your Strength modifier.";
            return this;
        }

        public Rage_Power Lesser_Celestial_Totem(Barbarian barbarian)
        {
            Name = "Celestial Totem, Lesser";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "Whenever subjected to a spell that cures hp damage, heal 1 additional hp per caster level. In the case of non-spell healing effects (such as channeled energy or lay on hands), heal a number of additional hp equal to the class level of the character performing the magical healing.";
            return this;
        }

        public Rage_Power Celestial_Totem(Barbarian barbarian)
        {
            Name = "Celestial Totem";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Lesser_Celestial_Totem(barbarian)));
            Benefit = "Gain a halo that shines as daylight and triggers invisibility purge (only reveals non-good creatures) in the barbarian’s square and each adjacent square.";
            return this;
        }

        public Rage_Power Greater_Celestial_Totem(Barbarian barbarian)
        {
            Name = "Celestial Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Celestial_Totem(barbarian)));
            Benefit = "Gain SR while raging equal to 11 + barbarian class level against spells with the evil descriptor; also gain +2 bonus on all saves against spells and effects from evil creatures.";
            return this;
        }

        public Rage_Power Lesser_Chaos_Totem(Barbarian barbarian)
        {
            Name = "Chaos Totem, Lesser";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "Gain a deflection bonus to AC and a resistance bonus against lawful spells and creatures";
            return this;
        }

        public Rage_Power Chaos_Totem(Barbarian barbarian)
        {
            Name = "Chaos Totem";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Lesser_Chaos_Totem(barbarian)));
            Benefit = "Gain a bonus to Escape Artist and a chance to avoid critical hits";
            return this;
        }

        public Rage_Power Greater_Chaos_Totem(Barbarian barbarian)
        {
            Name = "Chaos Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Chaos_Totem(barbarian)));
            Benefit = "Gain DR/lawful and weapons count as chaotic";
            return this;
        }

        public Rage_Power Clear_Mind(Barbarian barbarian)
        {
            Name = "Clear Mind";
            Prerequisites.Add(barbarian.Level >= 8);
            Benefit = "Reroll a failed Will save";
            return this;
        }

        public Rage_Power Come_and_Get_Me(Barbarian barbarian)
        {
            Name = "Come and Get Me";
            Prerequisites.Add(barbarian.Level >= 12);
            Benefit = "Provoke attacks of opportunity to get extra attacks";
            return this;
        }

        public Rage_Power Crippling_Blow(Barbarian barbarian)
        {
            Name = "Crippling Blow";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //powerful blow
            Benefit = "Deal Strength or Dexterity damage with your powerful blows";
            return this;
        }

        public Rage_Power Lesser_Cult_Totem(Barbarian barbarian)
        {
            Name = "Cult Totem, Lesser";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "While the barbarian is raging, any morale bonuses or bonuses for flanking she gains on attacks rolls are added to her damage rolls instead of her attack rolls. They are still morale bonuses, and they don’t stack with other morale bonuses on damage rolls.";
            return this;
        }

        public Rage_Power Cult_Totem(Barbarian barbarian)
        {
            Name = "Cult Totem";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Lesser_Cult_Totem(barbarian)));
            Benefit = "The barbarian can make an attack of opportunity against a creature within her reach who damages an ally of the barbarian with a melee attack. Only the enemy, not the barbarian’s ally, needs to be within the barbarian’s melee reach in order for the barbarian to make this attack of opportunity. Once the barbarian makes an attack of opportunity against a creature with this ability, she can’t use this ability to make an attack of opportunity against the same creature for 24 hours.";
            return this;
        }

        public Rage_Power Greater_Cult_Totem(Barbarian barbarian)
        {
            Name = "Cult Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Cult_Totem(barbarian)));
            Benefit = "While the barbarian is raging, when she takes hit point damage that would render her dying or dead, she remains conscious and raging until the end of her next turn after taking that damage, though she is disabled during that turn. She becomes dying or dead at the end of her next turn as normal for her current hit point total. This ability has no effect if the barbarian dies from a cause other than hit point damage, such as from a death effect or if her Constitution damage exceeds her Constitution score.";
            return this;
        }
                
        public Rage_Power Lesser_Daemon_Totem(Barbarian barbarian)
        {
            Name = "Daemon Totem, Lesser";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "While raging, the barbarian gains a +2 bonus on saving throws against acid damage, death effects, disease, and poison. This bonus increases by 1 for each daemon totem rage power the barbarian has, excluding this one.";
            return this;
        }

        public Rage_Power Daemon_Totem(Barbarian barbarian)
        {
            Name = "Daemon Totem";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Lesser_Daemon_Totem(barbarian)));
            Benefit = "While the barbarian is raging, her melee attacks impose a temporary negative level on her opponent on a successful critical hit. After 1 hour, these temporary negative levels disappear automatically (without a saving throw).";
            return this;
        }

        public Rage_Power Greater_Daemon_Totem(Barbarian barbarian)
        {
            Name = "Daemon Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Daemon_Totem(barbarian)));
            Benefit = "If the barbarian kills an intelligent creature with a CR equal to at least half her character level while raging, she heals 5 hit points. If she is already at her maximum number of hit points, she instead gains 5 temporary hit points, which don’t stack if she kills multiple creatures.";
            return this;
        }

        public Rage_Power Deadly_Accuracy(Barbarian barbarian)
        {
            Name = "Deadly Accuracy";
            Prerequisites.Add(barbarian.Level >= 4);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //surprise accuracy
            Benefit = "On critical threat when using surprise accuracy, double surprise accuracy bonus on roll to confirm critical hit.";
            return this;
        }

        public Rage_Power Deathless_Frenzy(Barbarian barbarian)
        {
            Name = "Deathless Frenzy";
            Prerequisites.Add(barbarian.Level >= 12);
            Benefit = "Ignore all consequences of being at 0 or lower hit points for one round while raging";
            return this;
        }

        public Rage_Power Disemboweling_Tusks(Barbarian barbarian)
        {
            Name = "Disemboweling Tusks";
            Prerequisites.Add(barbarian.Level >= 10);
            Benefit = "While raging, deal Con damage when you confirm a critical hit with your gore attack";
            return this;
        }

        public Rage_Power Disruptive(Barbarian barbarian)
        {
            Name = "Disruptive";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //superstition
            Benefit = "Gain the Disruptive feat as a bonus feat";
            return this;
        }

        public Rage_Power Dragon_Totem(Barbarian barbarian)
        {
            Name = "Dragon Totem";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Animal_Fury()));
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //intimidating glare
            Benefit = "Gain bonuses while raging";
            return this;
        }

        public Rage_Power Dragon_Totem_Resilience(Barbarian barbarian)
        {
            Name = "Dragon Totem Resilience";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Dragon_Totem(barbarian)));
            Benefit = "Gain energy resistance while raging";
            return this;
        }

        public Rage_Power Dragon_Totem_Wings(Barbarian barbarian)
        {
            Name = "Dragon Totem Wings";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Dragon_Totem_Resilience(barbarian)));
            Benefit = "Gain wings and a fly speed while raging";
            return this;
        }

        public Rage_Power Eater_of_Magic(Barbarian barbarian)
        {
            Name = "Eater of Magic";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Contains()); //superstition
            Benefit = "Take a second saving throw and gain temporary hit points";
            return this;
        }

        public Rage_Power Lesser_Elemental_Rage(Barbarian barbarian)
        {
            Name = "Elemental Rage, Lesser";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Use a swift action to cause extra elemental damage with melee attacks";
            return this;
        }

        public Rage_Power Elemental_Rage(Barbarian barbarian)
        {
            Name = "Elemental Rage";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Lesser_Elemental_Rage(barbarian)));
            Benefit = "Deal extra elemental damage with melee attacks";
            return this;
        }

        public Rage_Power Greater_Elemental_Rage(Barbarian barbarian)
        {
            Name = "Elemental Rage, Greater";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Elemental_Rage(barbarian)));
            Benefit = "Deal extra elemental damage on critical hits with melee weapons";
            return this;
        }

        public Rage_Power Energy_Absorption(Barbarian barbarian)
        {
            Name = "Energy Absorption";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Greater_Energy_Resistance(barbarian)));
            Benefit = "Absorb energy to gain temporary hit points";
            return this;
        }

        public Rage_Power Energy_Eruption(Barbarian barbarian)
        {
            Name = "Energy Eruption";
            Prerequisites.Add(barbarian.Level >= 16);
            Prerequisites.Add(barbarian.Rage_Powers.Contains(Energy_Absorption(barbarian)));
            Benefit = "Store absorbed energy and release it as a breath weapon attack";
            return this;
        }

        public Rage_Power Energy_Resistance(Barbarian barbarian, string type)
        {
            Name = "Energy Resistance " + type; //acid, cold, electricity, fire, or sonic
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name == Name));
            Benefit = "Gain resistance to one type of elemental damage";
            return this;
        }

        public Rage_Power Greater_Energy_Resistance(Barbarian barbarian)
        {
            Name = "Energy Resistance, Greater";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name.Contains("Energy Resistance")));
            Benefit = "Halve damage from an elemental attack";
            return this;
        }

        //Fearless Rage
    }
}

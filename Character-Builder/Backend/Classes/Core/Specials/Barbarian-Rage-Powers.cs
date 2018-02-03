using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Classes.Core.Specials
{
    public class Rage_Power
    {
        public string Name { get; set; }
        public List<bool> Prerequisites { get; } = new List<bool>();
        public string Benefit { get; set; }

        public Rage_Power()
        {
        }
    }

    public class Barbarian_Rage_Powers : Rage_Power
    {
        public List<object> Power_List(Barbarian barbarian)
        {
            List<object> list = new List<object>();
            Type type = typeof(Barbarian_Rage_Powers);

            foreach (var method in type.GetMethods())
            {
                if (method.ReturnType.Equals(typeof(Rage_Power)))
                {
                    list.Add(method);
                }
            }

            return list;
        }

        public Rage_Power Animal_Fury(Barbarian barbarian)
        {
            Name = "Animal Fury";
            Benefit = "Gain a bite attack";
            //functionality
            return this;
        }

        public Rage_Power Greater_Animal_Fury(Barbarian barbarian)
        {
            Name = "Animal Fury, Greater";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Animal Fury"));
            Benefit = "As animal fury, but your bite attack deals damage as if you were one size larger.";
            return this;
        }

        public Rage_Power Armor_Ripper(Barbarian barbarian)
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Atavism Totem, Lesser"));
            Benefit = "You gain the ferocity ability.";
            return this;
        }

        public Rage_Power Greater_Atavism_Totem(Barbarian barbarian)
        {
            Name = "Atavism Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Atavism Totem"));
            Benefit = "You gain the trample ability.";
            return this;
        }

        public Rage_Power Auspicious_Mark(Barbarian barbarian)
        {
            Name = "Auspicious Mark";
            Benefit = "Gain a bonus on a roll once per rage";
            return this;
        }

        public Rage_Power Battle_Roar(Barbarian barbarian)
        {
            Name = "Battle Roar";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Intimidating Glare"));
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Beast Totem, Lesser"));
            Benefit = "Gain a natural armor bonus"; // +1 per 4 levels
            return this;
        }

        public Rage_Power Greater_Beast_Totem(Barbarian barbarian)
        {
            Name = "Beast Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Beast Totem"));
            Benefit = "Gain a pounce attack"; //and claws 1d8 crit x3
            //functionality 
            return this;
        }

        public Rage_Power Bestial_Climber(Barbarian barbarian)
        {
            Name = "Bestial Climber";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Raging Climber"));
            Benefit = "Climb at your normal land speed while raging";
            return this;
        }

        public Rage_Power Bestial_Leaper(Barbarian barbarian)
        {
            Name = "Bestial Leaper";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Raging Leaper"));
            Benefit = "Take a standard action while moving during a rage";
            return this;
        }

        public Rage_Power Bestial_Swimmer(Barbarian barbarian)
        {
            Name = "Bestial Swimmer";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Raging Swimmer"));
            Benefit = "Swim at your normal land speed while raging";
            return this;
        }

        public Rage_Power Bleeding_Blow(Barbarian barbarian)
        {
            Name = "Bleeding Blow";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Powerful Blow"));
            Benefit = "Deal bleed damage with your powerful blows";
            return this;
        }

        public Rage_Power Bloody_Bite(Barbarian barbarian) //working??
        {
            Name = "Bloody Bite";
            Prerequisites.Add(barbarian.character.Race is Races.Core.Half_orc);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Animal Fury")); // or other natural bite
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

        public Rage_Power Brawler(Barbarian barbarian)
        {
            Name = "Brawler";
            Benefit = "Gain Improved Unarmed Strike while raging"; //if IUS 1d6
            return this;
        }

        public Rage_Power Greater_Brawler(Barbarian barbarian)
        {
            Name = "Brawler, Greater";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Brawler"));
            Benefit = "Gain Two-Weapon Fighting while raging";
            return this;
        }

        public Rage_Power Breathtaker(Barbarian barbarian)
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Celestial Totem, Lesser"));
            Benefit = "Gain a halo that shines as daylight and triggers invisibility purge (only reveals non-good creatures) in the barbarian’s square and each adjacent square.";
            return this;
        }

        public Rage_Power Greater_Celestial_Totem(Barbarian barbarian)
        {
            Name = "Celestial Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Celestial Totem"));
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Chaos Totem, Lesser"));
            Benefit = "Gain a bonus to Escape Artist and a chance to avoid critical hits";
            return this;
        }

        public Rage_Power Greater_Chaos_Totem(Barbarian barbarian)
        {
            Name = "Chaos Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Chaos Totem"));
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Powerful Blow"));
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Cult Totem, Lesser"));
            Benefit = "The barbarian can make an attack of opportunity against a creature within her reach who damages an ally of the barbarian with a melee attack. Only the enemy, not the barbarian’s ally, needs to be within the barbarian’s melee reach in order for the barbarian to make this attack of opportunity. Once the barbarian makes an attack of opportunity against a creature with this ability, she can’t use this ability to make an attack of opportunity against the same creature for 24 hours.";
            return this;
        }

        public Rage_Power Greater_Cult_Totem(Barbarian barbarian)
        {
            Name = "Cult Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Cult Totem"));
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Daemon Totem, Lesser"));
            Benefit = "While the barbarian is raging, her melee attacks impose a temporary negative level on her opponent on a successful critical hit. After 1 hour, these temporary negative levels disappear automatically (without a saving throw).";
            return this;
        }

        public Rage_Power Greater_Daemon_Totem(Barbarian barbarian)
        {
            Name = "Daemon Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Daemon Totem"));
            Benefit = "If the barbarian kills an intelligent creature with a CR equal to at least half her character level while raging, she heals 5 hit points. If she is already at her maximum number of hit points, she instead gains 5 temporary hit points, which don’t stack if she kills multiple creatures.";
            return this;
        }

        public Rage_Power Deadly_Accuracy(Barbarian barbarian)
        {
            Name = "Deadly Accuracy";
            Prerequisites.Add(barbarian.Level >= 4);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Surprise Accuracy"));
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Superstition"));
            Benefit = "Gain the Disruptive feat as a bonus feat";
            return this;
        }

        public Rage_Power Dragon_Totem(Barbarian barbarian)
        {
            Name = "Dragon Totem";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Animal Fury"));
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Intimidating Glare"));
            Benefit = "Gain bonuses while raging";
            return this;
        }

        public Rage_Power Dragon_Totem_Resilience(Barbarian barbarian)
        {
            Name = "Dragon Totem Resilience";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Dragon Totem"));
            Benefit = "Gain energy resistance while raging";
            return this;
        }

        public Rage_Power Dragon_Totem_Wings(Barbarian barbarian)
        {
            Name = "Dragon Totem Wings";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Dragon Totem Resilience"));
            Benefit = "Gain wings and a fly speed while raging";
            return this;
        }

        public Rage_Power Eater_of_Magic(Barbarian barbarian)
        {
            Name = "Eater of Magic";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Superstition"));
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
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Elemental Rage, Lesser"));
            Benefit = "Deal extra elemental damage with melee attacks";
            return this;
        }

        public Rage_Power Greater_Elemental_Rage(Barbarian barbarian)
        {
            Name = "Elemental Rage, Greater";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Elemental Rage"));
            Benefit = "Deal extra elemental damage on critical hits with melee weapons";
            return this;
        }

        public Rage_Power Energy_Absorption(Barbarian barbarian)
        {
            Name = "Energy Absorption";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Energy Resistance, Greater"));
            Benefit = "Absorb energy to gain temporary hit points";
            return this;
        }

        public Rage_Power Energy_Eruption(Barbarian barbarian)
        {
            Name = "Energy Eruption";
            Prerequisites.Add(barbarian.Level >= 16);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Energy Absorption"));
            Benefit = "Store absorbed energy and release it as a breath weapon attack";
            return this;
        }

        public Rage_Power Energy_Resistance(Barbarian barbarian/*, string type*/)
        {
            Name = "Energy Resistance "; //+ type; //acid, cold, electricity, fire, or sonic
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

        public Rage_Power Fearless_Rage(Barbarian barbarian)
        {
            Name = "Fearless Rage";
            Prerequisites.Add(barbarian.Level >= 12);
            Benefit = "Become immune to the shaken and frightened conditions";
            return this;
        }

        public Rage_Power Feasting_Bite(Barbarian barbarian)
        {
            Name = "Feasting Bite";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Bloody Bite"));
            Benefit = "When the barbarian confirms a critical hit with her bite attack, she regains a number of hit points equal to half the damage dealt. Activating this ability consumes 1 round of rage.";
            return this;
        }

        public Rage_Power Feast_of_Blood(Barbarian barbarian)
        {
            Name = "Feast of Blood";
            Prerequisites.Add(barbarian.Level >= 14);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Bloody Fist"));
            Benefit = "While raging, the barbarian may feast on the organs of her foes and absorb their power.";
            return this;
        }

        public Rage_Power Ferocious_Beast(Barbarian barbarian)
        {
            Name = "Ferocious Beast";
            Benefit = "Your animal companion also gains the benefits of rage though you must spend 1 additional round of rage per round if companion begins or ends its turn adjacent to you, and 2 additional rounds of rage per round if not.";
            return this;
        }

        public Rage_Power Greater_Ferocious_Beast(Barbarian barbarian)
        {
            Name = "Ferocious Beast, Greater";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Ferocious Beast"));
            Benefit = "Your animal companion shares the benefits of your rage powers that are constant in effect but gains no benefit from rage powers that require actions to activate, even if they are free actions.";
            return this;
        }

        public Rage_Power Ferocious_Mount(Barbarian barbarian)
        {
            Name = "Ferocious Mount";
            Benefit = "Allow your mount to rage as well";
            return this;
        }

        public Rage_Power Greater_Ferocious_Mount(Barbarian barbarian)
        {
            Name = "Ferocious Mount, Greater";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Ferocious Mount"));
            Benefit = "Allow your mount to benefit from rage powers";
            return this;
        }

        public Rage_Power Ferocious_Trample(Barbarian barbarian)
        {
            Name = "Ferocious Trample";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Ferocious Mount"));
            Benefit = "While raging your mount gains the trample ability";
            return this;
        }

        public Rage_Power Greater_Ferocious_Trample(Barbarian barbarian)
        {
            Name = "Ferocious Trample, Greater";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Ferocious Trample"));
            Benefit = "Your mount can trample larger creatures and make overrun attacks while raging";
            return this;
        }

        public Rage_Power Lesser_Fiend_Totem(Barbarian barbarian)
        {
            Name = "Fiend Totem, Lesser";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "Gain a gore attack"; //1d8
            //functionality
            return this;
        }

        public Rage_Power Fiend_Totem(Barbarian barbarian)
        {
            Name = "Fiend Totem";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Fiend Totem, Lesser"));
            Benefit = "Attackers take damage when they hit you in melee"; //1d6
            //functionality
            return this;
        }

        public Rage_Power Greater_Fiend_Totem(Barbarian barbarian)
        {
            Name = "Fiend Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Fiend Totem"));
            Benefit = "Non-evil creatures adjacent to the barbarian take damage and are shaken";
            return this;
        }

        public Rage_Power Fierce_Fortitude(Barbarian barbarian)
        {
            Name = "Fierce Fortitude";
            Prerequisites.Add(barbarian.Level >= 8);
            Benefit = "You gain a +4 bonus on saving throws against diseases and poison. A skald must be trained in Intimidate to select this rage power.";
            return this;
        }

        public Rage_Power Fight_Response(Barbarian barbarian)
        {
            Name = "Fight Response";
            Benefit = "When a barbarian with this rage power attempts a saving throw against a fear effect, she can enter a rage as an immediate action (as long as she would normally be able to enter rage). This consumes 3 rounds of the barbarian’s daily allotment of rage rounds, but the barbarian can maintain the rage each round on her turn normally. Any benefits from the barbarian’s rage apply immediately, so she gains her bonus on Will saves against the effect that required the initial saving throw. Unlike most rage powers, this rage power’s effects are useful only when the barbarian is not raging, so a skald can’t grant this rage power to allies with raging song.";
            return this;
        }

        public Rage_Power Flesh_Wound(Barbarian barbarian)
        {
            Name = "Flesh Wound";
            Prerequisites.Add(barbarian.Level >= 10);
            Benefit = "Convert lethal damage to nonlethal damage";
            return this;
        }

        public Rage_Power Fueled_by_Vengeance(Barbarian barbarian)
        {
            Name = "Fueled by Vengeance";
            Prerequisites.Add(barbarian.Level >= 6);
            Benefit = "Gain an extra round of rage if you hit a creature that hit you this round while raging";
            return this;
        }

        public Rage_Power Gearbreaker(Barbarian barbarian)
        {
            Name = "Gearbreaker";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Smasher"));
            Benefit = "Once per round while raging, whenever you make an attack against a construct, you can ignore an amount of that construct’s hardness equal to your barbarian level. This ability must be used before the attack roll is made. This power stacks with hard hitter.";
            return this;
        }

        public Rage_Power Ghost_Rager(Barbarian barbarian)
        {
            Name = "Ghost Rager";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Superstition"));
            Benefit = "Deal normal damage to incorporeal creatures";
            return this;
        }

        public Rage_Power Good_for_What_Ails_You(Barbarian barbarian)
        {
            Name = "Good for What Ails You";
            Benefit = "Drink alcohol to gain a new save against conditions";
            return this;
        }

        public Rage_Power Ground_Breaker(Barbarian barbarian)
        {
            Name = "Ground Breaker";
            Prerequisites.Add(barbarian.Level >= 6);
            Benefit = "Attack the ground to create difficult terrain";
            return this;
        }

        public Rage_Power Greater_Ground_Breaker(Barbarian barbarian)
        {
            Name = "Ground Breaker, Greater";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Ground Breaker"));
            Benefit = "Extend ground breaker’s radius of difficult terrain";
            return this;
        }

        public Rage_Power Guarded_Life(Barbarian barbarian)
        {
            Name = "Guarded Life";
            Benefit = "Stabilize when at negative hit points";
            return this;
        }

        public Rage_Power Greater_Guarded_Life(Barbarian barbarian)
        {
            Name = "Guarded Life, Greater";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Guarded Life"));
            Benefit = "Convert more damage to nonlethal damage";
            return this;
        }

        public Rage_Power Guarded_Stance(Barbarian barbarian)
        {
            Name = "Guarded Stance";
            Benefit = "Gain a dodge bonus to AC";
            return this;
        }

        public Rage_Power Hive_Totem(Barbarian barbarian)
        {
            Name = "Hive Totem";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Prerequisites.Add(barbarian.Level >= 4);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Animal Fury"));
            Benefit = "Take half damage from swarms while raging";
            return this;
        }

        public Rage_Power Hive_Totem_Resilience(Barbarian barbarian)
        {
            Name = "Hive Totem Resilience";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Hive Totem"));
            Benefit = "Take no damage from swarms while raging";
            return this;
        }

        public Rage_Power Hive_Totem_Toxicity(Barbarian barbarian)
        {
            Name = "Hive Totem Toxicity";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Hive Totem Resilience"));
            Benefit = "Do Constitution damage with a bite while raging";
            return this;
        }

        public Rage_Power Lesser_Hurling(Barbarian barbarian)
        {
            Name = "Hurling, Lesser";
            Benefit = "You can lift and throw large objects to do damage";
            return this;
        }

        public Rage_Power Hurling(Barbarian barbarian)
        {
            Name = "Hurling";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Hurling, Lesser"));
            Benefit = "Increase the range and size allowed for a hurled object";
            return this;
        }

        public Rage_Power Greater_Hurling(Barbarian barbarian)
        {
            Name = "Hurling, Greater";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Hurling"));
            Benefit = "Increase the range and size allowed for a hurled object";
            return this;
        }

        public Rage_Power Hurling_Charge(Barbarian barbarian)
        {
            Name = "Hurling Charge";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Hurling, Lesser"));
            Benefit = "You can hurl an object as part of a charge";
            return this;
        }

        public Rage_Power Impelling_Disarm(Barbarian barbarian)
        {
            Name = "Impelling Disarm";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Once per rage, you may attempt to hit another opponent with a weapon you disarmed from a different opponent.";
            return this;
        }

        public Rage_Power Increased_Damage_Reduction(Barbarian barbarian)
        {
            Name = "Increased Damage Reduction";
            Prerequisites.Add(barbarian.Level >= 8);
            Benefit = "Gain DR/- while raging"; //increases by 1, can be taken 3 times
            return this;
        }

        public Rage_Power Inspire_Ferocity(Barbarian barbarian)
        {
            Name = "Inspire Ferocity";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Reckless Abandon"));
            Benefit = "Use a move action to share reckless abandon with allies";
            return this;
        }

        public Rage_Power Internal_Fortitude(Barbarian barbarian)
        {
            Name = "Internal Fortitude";
            Prerequisites.Add(barbarian.Level >= 8);
            Benefit = "Gain immunity to nauseated and sickened conditions";
            return this;
        }

        public Rage_Power Intimidating_Glare(Barbarian barbarian)
        {
            Name = "Intimidating Glare";
            Benefit = "Intimidate an opponent as a move action";
            return this;
        }

        public Rage_Power Knockback(Barbarian barbarian)
        {
            Name = "Knockback";
            Benefit = "Make a bull rush in place of a melee attack";
            return this;
        }

        public Rage_Power Knockdown(Barbarian barbarian)
        {
            Name = "Knockdown";
            Benefit = "Make a trip attack in place of a melee attack";
            return this;
        }

        public Rage_Power Lethal_Accuracy(Barbarian barbarian)
        {
            Name = "Lethal Accuracy";
            Prerequisites.Add(barbarian.Level >= 16);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Deadly Accuracy"));
            Benefit = "Deal more damage when you score a critical hit with surprise accuracy";
            return this;
        }

        public Rage_Power Linnorm_Death_Curse_Cairn(Barbarian barbarian)
        {
            Name = "Linnorm Death Curse, Cairn";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Your melee attacks deal an additional 1 point of negative energy damage. If the character is knocked unconscious or killed by an attack or spell, the attacker suffers the curse of decay (Will negates).";
            return this;
        }

        public Rage_Power Linnorm_Death_Curse_Crag(Barbarian barbarian)
        {
            Name = "Linnorm Death Curse, Crag";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Your melee attacks deal an additional 1 point of fire damage. If the character is knocked unconscious or killed by an attack or spell, the attacker suffers the curse of fire (Will negates).";
            return this;
        }

        public Rage_Power Linnorm_Death_Curse_Fjord(Barbarian barbarian)
        {
            Name = "Linnorm Death Curse, Fjord";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Your melee attacks deal an additional 1 point of cold damage. If the character is knocked unconscious or killed by an attack or spell, the attacker suffers the curse of drowning (Will negates).";
            return this;
        }

        public Rage_Power Linnorm_Death_Curse_Ice(Barbarian barbarian)
        {
            Name = "Linnorm Death Curse, Ice";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Your melee attacks deal an additional 1 point of cold damage. If the character is knocked unconscious or killed, the attacker suffers the curse of frost.";
            return this;
        }

        public Rage_Power Linnorm_Death_Curse_Taiga(Barbarian barbarian)
        {
            Name = "Linnorm Death Curse, Taiga";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Your melee attacks deal an additional 1 point of electricity damage. If the character is knocked unconscious or killed by an attack or spell, the attacker suffers the curse of electricity (Will negates).";
            return this;
        }

        public Rage_Power Linnorm_Death_Curse_Tarn(Barbarian barbarian)
        {
            Name = "Linnorm Death Curse, Tarn";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Your melee attacks deal an additional 1 point of acid damage. If the character is knocked unconscious or killed by an attack or spell, the attacker suffers the curse of death (Will negates).";
            return this;
        }

        public Rage_Power Linnorm_Death_Curse_Tor(Barbarian barbarian)
        {
            Name = "Linnorm Death Curse, Tor";
            Prerequisites.Add(barbarian.Level >= 8);
            Benefit = "Your melee attacks deal an additional 1 point of fire damage. If the character is knocked unconscious or killed by an attack or spell, the attacker suffers the curse of boiling blood (Will negates).";
            return this;
        }

        public Rage_Power Liquid_Courage(Barbarian barbarian)
        {
            Name = "Liquid Courage";
            Benefit = "Alcoholic beverages give you a morale bonus while raging";
            return this;
        }

        public Rage_Power Low_Light_Vision(Barbarian barbarian)
        {
            Name = "Low-Light Vision";
            Benefit = "Gain low-light vision while raging";
            return this;
        }

        public Rage_Power Mighty_Swing(Barbarian barbarian)
        {
            Name = "Mighty Swing";
            Prerequisites.Add(barbarian.Level >= 12);
            Benefit = "Automatically confirm a critical hit";
            return this;
        }

        public Rage_Power Moment_of_Clarity(Barbarian barbarian)
        {
            Name = "Moment of Clarity";
            Benefit = "Remove benefits and penalties of raging for 1 round";
            return this;
        }

        public Rage_Power Night_Vision(Barbarian barbarian)
        {
            Name = "Night Vision";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Low-Light Vision")); //or racial LLV
            Benefit = "Gain darkvision 60 ft while raging";
            return this;
        }

        public Rage_Power No_Escape(Barbarian barbarian)
        {
            Name = "No Escape";
            Benefit = "Double move as an immediate action when an opponent withdraws";
            return this;
        }

        public Rage_Power Overbearing_Advance(Barbarian barbarian)
        {
            Name = "Overbearing Advance";
            Benefit = "Deal extra damage when using the overrun maneuver";
            return this;
        }

        public Rage_Power Overbearing_Onslaught(Barbarian barbarian)
        {
            Name = "Overbearing Onslaught";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Overbearing Advance"));
            Benefit = "Overrun multiple targets per round";
            return this;
        }

        public Rage_Power Penetrating_Bite(Barbarian barbarian)
        {
            Name = "Penetrating Bite";
            Prerequisites.Add(barbarian.Level >= 4);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Animal Fury"));
            Benefit = "When using animal fury while raging, your bite is able to pierce most resistances.";
            return this;
        }

        public Rage_Power Perfect_Clarity(Barbarian barbarian)
        {
            Name = "Perfect Clarity";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Moment of Clarity"));
            Benefit = "Roll twice when disbelieving an illusion";
            return this;
        }

        public Rage_Power Powerful_Blow(Barbarian barbarian)
        {
            Name = "Powerful Blow";
            Benefit = "Deal extra damage with a single blow";
            return this;
        }

        public Rage_Power Primal_Scent(Barbarian barbarian)
        {
            Name = "Primal Scent";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Scent"));
            Benefit = "Gain a bonus when using scent";
            return this;
        }

        public Rage_Power Quick_Reflexes(Barbarian barbarian)
        {
            Name = "Quick Reflexes";
            Benefit = "Make additional attacks of opportunity while raging";
            return this;
        }

        public Rage_Power Raging_Climber(Barbarian barbarian)
        {
            Name = "Raging Climber";
            Benefit = "Gain a bonus on Climb checks while raging";
            return this;
        }

        public Rage_Power Raging_Flier(Barbarian barbarian)
        {
            Name = "Raging Flier";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Raging Leaper"));
            Benefit = "1/rage, fly up to your base speed as a move action and can use this flight as part of movement during a charge.";
            return this;
        }

        public Rage_Power Raging_Grappler(Barbarian barbarian)
        {
            Name = "Raging Grappler";
            Benefit = "While raging, whenever you succeed at a check to start a grapple, you can choose to deal damage as if you had also succeeded at a check to maintain the grapple. In addition, while raging, whenever you succeed at a combat maneuver check to maintain a grapple, you can choose to give yourself, the target of your grapple, or both the prone condition as a free action while continuing to maintain the grapple.";
            return this;
        }

        public Rage_Power Raging_Leaper(Barbarian barbarian)
        {
            Name = "Raging Leaper";
            Benefit = "Gain a bonus on Acrobatics checks to jump while raging";
            return this;
        }

        public Rage_Power Raging_Swimmer(Barbarian barbarian)
        {
            Name = "Raging Swimmer";
            Benefit = "Gain a bonus on Swim checks while raging";
            return this;
        }

        public Rage_Power Reckless_Abandon(Barbarian barbarian)
        {
            Name = "Reckless Abandon";
            Benefit = "Take a penalty to AC for extra accuracy while raging";
            return this;
        }

        public Rage_Power Reflexive_Dodge(Barbarian barbarian)
        {
            Name = "Reflexive Dodge";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Rolling Dodge"));
            Benefit = "Use your rolling dodge bonus on Reflex saving throws";
            return this;
        }

        public Rage_Power Regenerative_Vigor(Barbarian barbarian)
        {
            Name = "Regenerative Vigor";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Renewed Vigor"));
            Benefit = "Gain fast healing after using renewed vigor";
            return this;
        }

        public Rage_Power Renewed_Life(Barbarian barbarian)
        {
            Name = "Renewed Life";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Renewed Vitality"));
            Benefit = "Ignore temporary negative levels while raging";
            return this;
        }

        public Rage_Power Renewed_Vigor(Barbarian barbarian)
        {
            Name = "Renewed Vigor";
            Prerequisites.Add(barbarian.Level >= 4);
            Benefit = "Heal damage as a standard action";
            return this;
        }

        public Rage_Power Renewed_Vitality(Barbarian barbarian)
        {
            Name = "Renewed Vitality";
            Prerequisites.Add(barbarian.Level >= 4);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Renewed Vigor"));
            Benefit = "Ignore ability damage or penalties while raging";
            return this;
        }

        public Rage_Power Roaring_Drunk(Barbarian barbarian)
        {
            Name = "Roaring Drunk";
            Benefit = "Gain a bonus on Intimidate checks and fear effect DC";
            return this;
        }

        public Rage_Power Rolling_Dodge(Barbarian barbarian)
        {
            Name = "Rolling Dodge";
            Benefit = "Gain a dodge bonus to AC against ranged attacks while raging";
            return this;
        }

        public Rage_Power Roused_Anger(Barbarian barbarian)
        {
            Name = "Roused Anger";
            Benefit = "Enter a rage even when fatigued";
            return this;
        }

        public Rage_Power Savage_Dirty_Trick(Barbarian barbarian)
        {
            Name = "Savage Dirty Trick";
            Prerequisites.Add(barbarian.Level >= 6);
            Benefit = "Once per round while raging, you can attempt a dirty trick combat maneuver in place of a melee attack.";
            return this;
        }

        public Rage_Power Savage_Intuition(Barbarian barbarian)
        {
            Name = "Savage Intuition";
            Benefit = "You may enter a rage even if you aren’t aware that combat has begun";
            return this;
        }

        public Rage_Power Savage_Jaw(Barbarian barbarian)
        {
            Name = "Savage Jaw";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Animal Fury"));
            Benefit = "While raging, you can open your jaws wide and latch your teeth firmly onto your opponent.";
            return this;
        }

        public Rage_Power Scent(Barbarian barbarian)
        {
            Name = "Scent";
            Benefit = "Gain the scent ability when raging";
            return this;
        }

        public Rage_Power Sharpened_Accuracy(Barbarian barbarian)
        {
            Name = "Sharpened Accuracy";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Surprise Accuracy"));
            Benefit = "Surprise accuracy ignores concealment and cover";
            return this;
        }

        public Rage_Power Smasher(Barbarian barbarian)
        {
            Name = "Smasher";
            Benefit = "When sundering an unattended object, ignore hardness";
            return this;
        }

        public Rage_Power Spell_Sunder(Barbarian barbarian)
        {
            Name = "Spell Sunder";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Witch Hunter"));
            Benefit = "Sunder spells with a combat maneuver check";
            return this;
        }

        public Rage_Power Spellbreaker(Barbarian barbarian)
        {
            Name = "Spellbreaker";
            Prerequisites.Add(barbarian.Level >= 12);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Disruptive"));
            Benefit = "Gain the Spellbreaker feat while raging";
            return this;
        }

        public Rage_Power Spirit_Steed(Barbarian barbarian)
        {
            Name = "Spirit Steed";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Ferocious Mount"));
            Benefit = "Your mount gains DR/magic and its natural weapons count as magical";
            return this;
        }

        public Rage_Power Lesser_Spirit_Totem(Barbarian barbarian)
        {
            Name = "Spirit Totem, Lesser";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "Gain spirit allies that can attack adjacent enemies";
            return this;
        }

        public Rage_Power Spirit_Totem(Barbarian barbarian)
        {
            Name = "Spirit Totem";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Spirit Totem, Lesser"));
            Benefit = "Attacks against you may miss when you are raging";
            return this;
        }

        public Rage_Power Greater_Spirit_Totem(Barbarian barbarian)
        {
            Name = "Spirit Totem, Greater";
            Prerequisites.Add(barbarian.Level >= 10);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Spirit Totem"));
            Benefit = "Enemies near you take negative energy damage";
            return this;
        }

        public Rage_Power Sprint(Barbarian barbarian)
        {
            Name = "Sprint";
            Prerequisites.Add(barbarian.Level >= 4);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Swift Foot"));
            Benefit = "Move at x3 or x6 speed once per rage";
            return this;
        }

        public Rage_Power Staggering_Drunk(Barbarian barbarian)
        {
            Name = "Staggering Drunk";
            Benefit = "Gain dodge AC against attacks of opportunity if drinking";
            return this;
        }

        public Rage_Power Strength_Surge(Barbarian barbarian)
        {
            Name = "Strength Surge";
            Benefit = "Gain a Strength bonus on Combat Maneuver Checks";
            return this;
        }

        public Rage_Power Sunder_Enchantment(Barbarian barbarian)
        {
            Name = "Sunder Enchantment";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Spell Sunder"));
            Benefit = "Suppress sundered magical item’s powers";
            return this;
        }

        public Rage_Power Superstition(Barbarian barbarian)
        {
            Name = "Superstition";
            Benefit = "Gain a bonus on saving throws";
            return this;
        }

        public Rage_Power Surprise_Accuracy(Barbarian barbarian)
        {
            Name = "Surprise Accuracy";
            Benefit = "Gain a morale bonus on one attack roll";
            return this;
        }

        public Rage_Power Swift_Foot(Barbarian barbarian)
        {
            Name = "Swift Foot";
            Benefit = "Move faster when raging";
            return this;
        }

        public Rage_Power Terrifying_Howl(Barbarian barbarian)
        {
            Name = "Terrifying Howl";
            Prerequisites.Add(barbarian.Level >= 8);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Intimidating Glare"));
            Benefit = "Cause shaken enemies to become panicked";
            return this;
        }

        public Rage_Power Ultimate_Clarity(Barbarian barbarian)
        {
            Name = "Ultimate Clarity";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Perfect Clarity"));
            Benefit = "1/rage, for 1 round, see through normal and magical darkness (including from magical effects such as blur and displacement), invisibility, and illusions; and discern exact locations of creatures with concealment.";
            return this;
        }

        public Rage_Power Unexpected_Strike(Barbarian barbarian)
        {
            Name = "Unexpected Strike";
            Prerequisites.Add(barbarian.Level >= 8);
            Benefit = "Enemies provoke attacks of opportunity even when they normally wouldn’t";
            return this;
        }

        public Rage_Power Water_Sense(Barbarian barbarian)
        {
            Name = "Water Sense";
            Benefit = "Your senses are no longer fooled by the rippling surface and confounding reflections seen in water that is being used as cover by your foes.";
            return this;
        }

        public Rage_Power Witch_Hunter(Barbarian barbarian)
        {
            Name = "Witch Hunter";
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "Superstition"));
            Benefit = "Do extra damage against spellcasters";
            return this;
        }

        public Rage_Power World_Serpent_Totem(Barbarian barbarian)
        {
            Name = "World Serpent Totem";
            Prerequisites.Add(!barbarian.Rage_Powers.Exists(x => x.Name.Contains("Totem")));
            Benefit = "Gain bonuses against outsiders and abberations";
            return this;
        }

        public Rage_Power World_Serpent_Spirit(Barbarian barbarian)
        {
            Name = "World Serpent Spirit";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "World Serpent Totem"));
            Benefit = "Your weapon counts as chaotic, evil, good, lawful while raging";
            return this;
        }

        public Rage_Power World_Serpent_Totem_Unity(Barbarian barbarian)
        {
            Name = "World Serpent Totem Unity";
            Prerequisites.Add(barbarian.Level >= 6);
            Prerequisites.Add(barbarian.Rage_Powers.Exists(x => x.Name == "World Serpent Spirit"));
            Benefit = "Double fast movement bonus and cannot be knocked prone";
            return this;
        }

        //Bloodrage Powers
    }
}

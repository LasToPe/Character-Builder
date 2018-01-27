using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Classes.Core.Class_Features
{
    public class Bard_Class_Features : Class_Feature
    {
        public Class_Feature Bardic_Knowledge(Bard bard)
        {
            Name = "Bardic Knowledge";
            Description = "A bard adds half his class level (minimum 1) to all Knowledge skill checks and may make all Knowledge skill checks untrained.";
            //functionality
            return this;
        }

        public Class_Feature Bardic_Performance(Bard bard)
        {
            Name = "Bardic Performance";
            Description = "A bard is trained to use the Perform skill to create magical effects on those around him, including himself if desired. He can use this ability for a number of rounds per day equal to 4 + his Charisma modifier. At each level after 1st a bard can use bardic performance for 2 additional rounds per day. Each round, the bard can produce any one of the types of bardic performance that he has mastered, as indicated by his level."
                + "\n\n" +
                "Starting a bardic performance is a standard action, but it can be maintained each round as a free action. Changing a bardic performance from one effect to another requires the bard to stop the previous performance and start a new one as a standard action. A bardic performance cannot be disrupted, but it ends immediately if the bard is killed, paralyzed, stunned, knocked unconscious, or otherwise prevented from taking a free action to maintain it each round. A bard cannot have more than one bardic performance in effect at one time."
                + "\n\n" +
                "At 7th level, a bard can start a bardic performance as a move action instead of a standard action. At 13th level, a bard can start a bardic performance as a swift action."
                + "\n\n" +
                "Each bardic performance has audible components, visual components, or both."
                + "\n\n" +
                "If a bardic performance has audible components, the targets must be able to hear the bard for the performance to have any effect, and many such performances are language dependent (as noted in the description). A deaf bard has a 20% chance to fail when attempting to use a bardic performance with an audible component. If he fails this check, the attempt still counts against his daily limit. Deaf creatures are immune to bardic performances with audible components."
                + "\n\n" +
                "If a bardic performance has a visual component, the targets must have line of sight to the bard for the performance to have any effect. A blind bard has a 50% chance to fail when attempting to use a bardic performance with a visual component. If he fails this check, the attempt still counts against his daily limit. Blind creatures are immune to bardic performances with visual components.";

            //functionality
            var list = new Bardic_Performance().Performances();
            foreach (var item in list)
            {
                if (item.LevelReq <= bard.Level)
                {
                    bard.Bardic_Performances.Add(item);
                }
            }

            return this;
        }

        public Class_Feature Versatile_Performance() //takes Perform type, taken at 2nd, 6th, 10th, 14th and 18th level
        {
            Name = "Versatile Performance";
            Description = "At 2nd level, a bard can choose one type of Perform skill. He can use his bonus in that skill in place of his bonus in associated skills. When substituting in this way, the bard uses his total Perform skill bonus, including class skill bonus, in place of its associated skill’s bonus, whether or not he has ranks in that skill or if it is a class skill. At 6th level, and every 4 levels thereafter, the bard can select an additional type of Perform to substitute."
                + "\n\n" +
                "The types of Perform and their associated skills are: Act (Bluff, Disguise), Comedy (Bluff, Intimidate), Dance (Acrobatics, Fly), Keyboard Instruments (Diplomacy, Intimidate), Oratory (Diplomacy, Sense Motive), Percussion (Handle Animal, Intimidate), Sing (Bluff, Sense Motive), String (Bluff, Diplomacy), and Wind (Diplomacy, Handle Animal).";
            return this;
        }

        //Future -> Advanced Versitile Performance and Masterpieces

        public Class_Feature Well_Versed()
        {
            Name = "Well-Versed";
            Description = "At 2nd level, the bard becomes resistant to the bardic performance of others, and to sonic effects in general. The bard gains a +4 bonus on saving throws made against bardic performance, sonic, and language-dependent effects.";
            return this;
        }

        public Class_Feature Lore_Master(Bard bard)
        {
            int bonus = (bard.Level - 5) / 6 + 1;
            Name = "Lore Master";
            Description = "At 5th level, the bard becomes a master of lore and can take 10 on any Knowledge skill check that he has ranks in. A bard can choose not to take 10 and can instead roll normally. In addition, once per day, the bard can take 20 on any Knowledge skill check as a standard action. He can use this ability one additional time per day for every six levels he possesses beyond 5th, to a maximum of three times per day at 17th level.";
            return this;
        }

        public Class_Feature Jack_of_All_Trades()
        {
            Name = "Jack of All Trades";
            Description = "At 10th level, the bard can use any skill, even if the skill normally requires him to be trained. At 16th level, the bard considers all skills to be class skills. At 19th level, the bard can take 10 on any skill check, even if it is not normally allowed.";
            //functionality (16th level all skills are class skills)
            return this;
        }
    }

    public class Bardic_Performance
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LevelReq { get; set; }

        public Bardic_Performance() { }

        public Bardic_Performance(string name, string description, int levelReq)
        {
            Name = name;
            Description = description;
            LevelReq = levelReq;
        }

        public List<Bardic_Performance> Performances()
        {
            List<Bardic_Performance> list = new List<Bardic_Performance>
            {
                new Bardic_Performance(
                    name: "Countersong",
                    description: "At 1st level, a bard learns to counter magic effects that depend on sound (but not spells that have verbal components.) Each round of the countersong he makes a Perform (keyboard, percussion, wind, string, or sing) skill check. Any creature within 30 feet of the bard (including the bard himself) that is affected by a sonic or language-dependent magical attack may use the bard’s Perform check result in place of its saving throw if, after the saving throw is rolled, the Perform check result proves to be higher. If a creature within range of the countersong is already under the effect of a non-instantaneous sonic or language-dependent magical attack, it gains another saving throw against the effect each round it hears the countersong, but it must use the bard’s Perform skill check result for the save. Countersong does not work on effects that don’t allow saves. Countersong relies on audible components.",
                    levelReq: 1),
                new Bardic_Performance(
                    name: "Distraction",
                    description: "At 1st level, a bard can use his performance to counter magic effects that depend on sight. Each round of the Distraction, he makes a Perform (act, comedy, dance, or oratory) skill check. Any creature within 30 feet of the bard (including the bard himself) that is affected by an illusion (pattern) or illusion (figment) magical attack may use the bard’s Perform check result in place of its saving throw if, after the saving throw is rolled, the Perform check result proves to be higher. If a creature within range of the Distraction is already under the effect of a non-instantaneous illusion (pattern) or illusion (figment) magical attack, it gains another saving throw against the effect each round it sees the Distraction, but it must use the bard’s Perform check result for the save. Distraction does not work on effects that don’t allow saves. Distraction relies on visual components.",
                    levelReq: 1),
                new Bardic_Performance(
                    name: "Fascinate",
                    description: "At 1st level, a bard can use his performance to cause one or more creatures to become fascinated with him. Each creature to be fascinated must be within 90 feet, able to see and hear the bard, and capable of paying attention to him. The bard must also be able to see the creatures affected. The Distraction of a nearby combat or other dangers prevents the ability from working. For every three levels a bard has attained beyond 1st, he can target one additional creature with this ability.\n\nEach creature within range receives a Will save (DC 10 + 1/2 the bard’s level + the bard’s Cha modifier) to negate the effect. If a creature’s saving throw succeeds, the bard cannot attempt to fascinate that creature again for 24 hours. If its saving throw fails, the creature sits quietly and observes the performance for as long as the bard continues to maintain it. While fascinated, a target takes a –4 penalty on skill checks made as reactions, such as Perception checks. Any potential threat to the target allows the target to make a new saving throw against the effect. Any obvious threat, such as someone drawing a weapon, casting a spell, or aiming a weapon at the target, automatically breaks the effect.\n\nFascinate is an enchantment (compulsion), mind-affecting ability. Fascinate relies on audible and visual components in order to function.",
                    levelReq: 1),
                new Bardic_Performance(
                    name: "Inspire Courage",
                    description: "A 1st level bard can use his performance to inspire courage in his allies (including himself), bolstering them against fear and improving their combat abilities. To be affected, an ally must be able to perceive the bard’s performance. An affected ally receives a +1 morale bonus on saving throws against charm and fear effects and a +1 competence bonus on attack and weapon damage rolls. At 5th level, and every six bard levels thereafter, this bonus increases by +1, to a maximum of +4 at 17th level. Inspire courage is a mind-affecting ability. inspire courage can use audible or visual components. The bard must choose which component to use when starting his performance.",
                    levelReq: 1),
                new Bardic_Performance(
                    name: "Inspire Competence",
                    description: "A bard of 3rd level or higher can use his performance to help an ally succeed at a task. The ally must be within 30 feet and able to see and hear the bard. The ally gets a +2 competence bonus on skill checks with a particular skill as long as she continues to hear the bard’s performance. This bonus increases by +1 for every four levels the bard has attained beyond 3rd (+3 at 7th, +4 at 11th, +5 at 15th, and +6 at 19th).\n\nCertain uses of this ability are infeasible, such as Stealth, and may be disallowed at the GM’s discretion. A bard can’t inspire competence in himself. inspire competence relies on audible components.",
                    levelReq: 3),
                new Bardic_Performance(
                    name: "Suggestion",
                    description: "A bard of 6th level or higher can use his performance to make a suggestion (as per the spell) to a creature that he has already fascinated (see above). Using this ability does not disrupt the fascinate effect, but it does require a standard action to activate (in addition to the free action to continue the fascinate effect). A bard can use this ability more than once against an individual creature during an individual performance.\n\nA Will saving throw (DC 10 + 1/2 bard’s level + bard’s Cha modifier) negates the effect. This ability affects only a single creature (but see mass suggestion, below). Suggestion is an enchantment (compulsion), mind-affecting, language-dependent ability and relies on audible components.",
                    levelReq: 6),
                new Bardic_Performance(
                    name: "Dirge of Doom",
                    description: "A bard of 8th level or higher can use his performance to foster a sense of growing dread in his enemies, causing them to take become shaken. To be affected, an enemy must be within 30 feet and able to see and hear the bard’s performance. The effect persists for as long as the enemy is within 30 feet and the bard continues the performance. The performance cannot cause a creature to become frightened or panicked, even if the targets are already shaken from another effect. Dirge of doom is a mind-affecting fear effect, and it relies on audible and visual components.",
                    levelReq: 8),
                new Bardic_Performance(
                    name: "Inspire Greatness",
                    description: "A bard of 9th level or higher can use his performance to inspire greatness in himself or a single willing ally within 30 feet, granting extra fighting capability. For every three levels a bard attains beyond 9th, he can target one additional ally while using this performance (up to a maximum of four at 18th level). To inspire greatness, all of the targets must be able to see and hear the bard. A creature inspired with greatness gains 2 bonus Hit Dice (d10s), the commensurate number of temporary hit points (apply the target’s Constitution modifier, if any, to these bonus Hit Dice), a +2 competence bonus on attack rolls, and a +1 competence bonus on Fortitude saves. The bonus Hit Dice count as regular Hit Dice for determining the effect of spells that are Hit Dice dependent. Inspire greatness is a mind-affecting ability and it relies on audible and visual components.",
                    levelReq: 9),
                new Bardic_Performance(
                    name: "Soothing Performance",
                    description: "A bard of 12th level or higher can use his performance to create an effect equivalent to the mass cure serious wounds, using the bard’s level as the caster level. In addition, this performance removes the fatigued, sickened, and shaken condition from all those affected. Using this ability requires 4 continuous performance, and the targets must be able to see and hear the bard throughout the performance. Soothing performance relies on audible and visual components.",
                    levelReq: 12),
                new Bardic_Performance(
                    name: "Frightening Tune",
                    description: "A bard of 14th level or higher can use his performance to cause fear in his enemies. To be affected, an enemy must be able to hear the bard perform and be within 30 feet. Each enemy within range receives a Will save (DC 10 + 1/2 the bard’s level + the bard’s Cha modifier) to negate the effect. If the save succeeds, the creature is immune to this ability for 24 hours. If the save fails, the target becomes frightened and flees for as long as the target can hear the bard’s performance. Frightening tune relies on audible components.",
                    levelReq: 14),
                new Bardic_Performance(
                    name: "Inspire Heroics",
                    description: "A bard of 15th level or higher can inspire tremendous heroism in himself or a single ally within 30 feet. For every three bard levels the character attains beyond 15th, he can inspire heroics in one additional creature. To inspire heroics, all of the targets must be able to see and hear the bard. Inspired creatures gain a +4 morale bonus on saving throws and a +4 dodge bonus to AC. The effect lasts for as long as the targets are able to witness the performance. Inspire heroics is a mind-affecting ability that relies on audible and visual components.",
                    levelReq: 15),
                new Bardic_Performance(
                    name: "Mass Suggestion",
                    description: "This ability functions just like suggestion, but allows a bard of 18th level or higher to make a suggestion simultaneously to any number of creatures that he has already fascinated. Mass suggestion is an enchantment (compulsion), mind-affecting, language dependent ability that relies on audible components.",
                    levelReq: 18),
                new Bardic_Performance(
                    name: "Deadly Performance",
                    description: "A bard of 20th level or higher can use his performance to cause one enemy to die from joy or sorrow. To be affected, the target must be able to see and hear the bard perform for 1 full round and be within 30 feet. The target receives a Will save (DC 10 + 1/2 the bard’s level + the bard’s Cha modifier) to negate the effect. If a creature’s saving throw succeeds, the target is staggered for 1d4 rounds, and the bard cannot use deadly performance on that creature again for 24 hours. If a creature’s saving throw fails, it dies. Deadly performance is a mind-effecting death effect that relies on audible and visual components.",
                    levelReq: 20)
            };

            return list;
        }
    }
}

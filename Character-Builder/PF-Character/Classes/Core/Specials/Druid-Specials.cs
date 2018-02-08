using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Classes.Core.Specials
{
    public class Druid_Specials : Special
    {
        public Special Nature_Bond(/*choice*/) //available cleric domains, future -> animal and terrain domains
        {
            Name = "Nature Bond";
            Description = "At 1st level, a druid forms a bond with nature. This bond can take one of two forms. The first is a close tie to the natural world, granting the druid one of the following cleric domains: Air, Animal, Earth, Fire, Plant, Water, or Weather. Druids also have access to a set of Animal and Terrain Domains. When determining the powers and bonus spells granted by this domain, the druid’s effective cleric level is equal to her druid level. A druid that selects this option also receives additional domain spell slots, just like a cleric. She must prepare the spell from her domain in this slot and this spell cannot be used to cast a spell spontaneously."
                + "\n\n" +
                "The second option is to form a close bond with an animal companion. A druid may begin play with any of the animals listed in Animal Choices. This animal is a loyal companion that accompanies the druid on her adventures."
                + "\n\n" +
                "Unlike normal animals of its kind, an animal companion’s Hit Dice, abilities, skills, and feats advance as the druid advances in level. If a character receives an animal companion from more than one source, her effective druid levels stack for the purposes of determining the statistics and abilities of the companion. Most animal companions increase in size when their druid reaches 4th or 7th level, depending on the companion. If a druid releases her companion from service, she may gain a new one by performing a ceremony requiring 24 uninterrupted hours of prayer in the environment where the new companion typically lives. This ceremony can also replace an animal companion that has perished.";
            //functionality based on choice
            return this;
        }

        public Special Nature_Sense()
        {
            Name = "Nature Sense";
            Description = "A druid gains a +2 bonus on Knowledge (nature) and Survival checks.";
            //functionality
            return this;
        }

        public Special Wild_Empathy()
        {
            Name = "Wild Empathy";
            Description = "A druid can improve the attitude of an animal. This ability functions just like a Diplomacy check made to improve the attitude of a person. The druid rolls 1d20 and adds her druid level and her Charisma modifier to determine the wild empathy check result."
                + "\n\n" +
                "The typical domestic animal has a starting attitude of indifferent, while wild animals are usually unfriendly."
                + "\n\n" +
                "To use wild empathy, the druid and the animal must be able to study each other, which means that they must be within 30 feet of one another under normal conditions. Generally, influencing an animal in this way takes 1 minute but, as with influencing people, it might take more or less time."
                + "\n\n" +
                "A druid can also use this ability to influence a magical beast with an Intelligence score of 1 or 2, but she takes a –4 penalty on the check.";
            return this;
        }

        public Special Woodland_Stride()
        {
            Name = "Woodland Stride";
            Description = "Starting at 2nd level, a druid may move through any sort of undergrowth (such as natural thorns, briars, overgrown areas, and similar terrain) at her normal speed and without taking damage or suffering any other impairment. Thorns, briars, and overgrown areas that have been magically manipulated to impede motion, however, still affect her.";
            return this;
        }

        public Special Trackless_Step()
        {
            Name = "Trackless Step";
            Description = "Starting at 3rd level, a druid leaves no trail in natural surroundings and cannot be tracked. She may choose to leave a trail if so desired.";
            return this;
        }

        public Special Resist_Natures_Lure()
        {
            Name = "Resist Nature's Lure";
            Description = "Starting at 4th level, a druid gains a +4 bonus on saving throws against the spell-like and supernatural abilities of fey. This bonus also applies to spells and effects that target plants, such as blight, entangle, spike growth, and warp wood.";
            return this;
        }

        public Special Wild_Shape() //uses per day
        {
            Name = "Wild Shape";
            Description = "At 4th level, a druid gains the ability to turn herself into any small or Medium animal and back again once per day. Her options for new forms include all creatures with the animal type. This ability functions like the beast shape I spell, except as noted here. The effect lasts for 1 hour per druid level, or until she changes back. Changing form (to animal or back) is a standard action and doesn’t provoke an attack of opportunity. The form chosen must be that of an animal the druid is familiar with."
                + "\n\n" +
                "A druid loses her ability to speak while in animal form because she is limited to the sounds that a normal, untrained animal can make, but she can communicate normally with other animals of the same general grouping as her new form. (The normal sound a wild parrot makes is a squawk, so changing to this form does not permit speech.)"
                + "\n\n" +
                "A druid can use this ability an additional time per day at 6th level and every two levels thereafter, for a total of eight times at 18th level. At 20th level, a druid can use wild shape at will. As a druid gains in levels, this ability allows the druid to take on the form of larger and smaller animals, elementals, and plants. Each form expends one daily usage of this ability, regardless of the form taken."
                + "\n\n" +
                "At 6th level, a druid can use wild shape to change into a Large or Tiny animal or a Small elemental. When taking the form of an animal, a druid’s wild shape now functions as beast shape II. When taking the form of an elemental, the druid’s wild shape functions as elemental body I."
                + "\n\n" +
                "At 8th level, a druid can use wild shape to change into a Huge or Diminutive animal, a Medium elemental, or a Small or Medium plant creature. When taking the form of animals, a druid’s wild shape now functions as beast shape III. When taking the form of an elemental, the druid’s wild shape now functions as elemental body II. When taking the form of a plant creature, the druid’s wild shape functions as plant shape I."
                + "\n\n" +
                "At 10th level, a druid can use wild shape to change into a Large elemental or a Large plant creature. When taking the form of an elemental, the druid’s wild shape now functions as elemental body III. When taking the form of a plant, the druid’s wild shape now functions as plant shape II."
                + "\n\n" +
                "At 12th level, a druid can use wild shape to change into a Huge elemental or a Huge plant creature. When taking the form of an elemental, the druid’s wild shape now functions as elemental body IV. When taking the form of a plant, the druid’s wild shape now functions as plant shape III.";
            return this;
        }

        public Special Venom_Immunity()
        {
            Name = "Venom Immunity";
            Description = "At 9th level, a druid gains immunity to all poisons.";
            return this;
        }

        public Special A_Thousand_Faces()
        {
            Name = "A Thousand Faces";
            Description = "At 13th level, a druid gains the ability to change her appearance at will, as if using the alter self spell, but only while in her normal form.";
            return this;
        }

        public Special Timeless_Body()
        {
            Name = "Timeless Body";
            Description = "After attaining 15th level, a druid no longer takes ability score penalties for aging and cannot be magically aged. Any penalties she may have already incurred, however, remain in place. Bonuses still accrue, and the druid still dies of old age when her time is up.";
            return this;
        }
    }
}

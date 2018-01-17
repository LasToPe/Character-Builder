using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Skills
{
    class Setup_Skills : Skill
    {
        public List<Skill> SetUp(Character character)
        {
            List<Skill> list = new List<Skill>
            {
                Acrobatics(character),
                Appraise(character),
                Bluff(character),
                Climb(character),
                Craft(character),
                Diplomacy(character),
                Disable_Device(character),
                Disguise(character),
                Escape_Artist(character),
                Fly(character),
                Handle_Animal(character),
                Heal(character),
                Intimidate(character),
                Knowledge_arcana(character),
                Knowledge_dungeoneering(character),
                Knowledge_engineering(character),
                Knowledge_geography(character),
                Knowledge_history(character),
                Knowledge_local(character),
                Knowledge_nature(character),
                Knowledge_nobility(character),
                Knowledge_planes(character),
                Knowledge_religion(character),
                Linguistics(character),
                Perception(character),
                Perform(character),
                Profession(character),
                Ride(character),
                Sense_Motive(character),
                Slight_of_Hand(character),
                Spellcraft(character),
                Stealth(character),
                Survival(character),
                Swim(character),
                Use_Magic_Device(character)
            };

            return list;
        }
    }
}

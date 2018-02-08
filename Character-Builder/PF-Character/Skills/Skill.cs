using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Skills
{
    public class Skill
    {
        public string Skill_Name { get; set; }
        public int Key_Ability { get; set; }
        public bool Class_Skill { get; set; }
        public bool Untrained { get; set; }
        public bool ACP { get; set; }
        public int Misc_Mod { get; set; }
        public int Ranks { get; set; }

        public int Bonus
        {
            get
            {
                int value = Key_Ability + Misc_Mod + Ranks;
                if (Class_Skill && Ranks > 1)
                {
                    value += 3;
                }
                return value;
            }
        }

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

        public Skill Acrobatics(Character character)
        {
            Skill_Name = "Acrobatics";
            Key_Ability = character.Dexterity_Modifier;
            Untrained = true;
            ACP = true;
            return this;
        }

        public Skill Appraise(Character character)
        {
            Skill_Name = "Appraise";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Bluff(Character character)
        {
            Skill_Name = "Bluff";
            Key_Ability = character.Charisma_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Climb(Character character)
        {
            Skill_Name = "Climb";
            Key_Ability = character.Strength_Modifier;
            Untrained = true;
            ACP = true;
            return this;
        }

        public Skill Craft(Character character)
        {
            Skill_Name = "Craft";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Diplomacy(Character character)
        {
            Skill_Name = "Diplomacy";
            Key_Ability = character.Charisma_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Disable_Device(Character character)
        {
            Skill_Name = "Disable Device";
            Key_Ability = character.Dexterity_Modifier;
            Untrained = false;
            ACP = true;
            return this;
        }

        public Skill Disguise(Character character)
        {
            Skill_Name = "Disguise";
            Key_Ability = character.Charisma_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Escape_Artist(Character character)
        {
            Skill_Name = "Escape Artist";
            Key_Ability = character.Dexterity_Modifier;
            Untrained = true;
            ACP = true;
            return this;
        }

        public Skill Fly(Character character)
        {
            Skill_Name = "Fly";
            Key_Ability = character.Dexterity_Modifier;
            Untrained = true;
            ACP = true;
            return this;
        }

        public Skill Handle_Animal(Character character)
        {
            Skill_Name = "Handle Animal";
            Key_Ability = character.Charisma_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Heal(Character character)
        {
            Skill_Name = "Heal";
            Key_Ability = character.Wisdom_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Intimidate(Character character)
        {
            Skill_Name = "Intimidate";
            Key_Ability = character.Charisma_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Knowledge_arcana(Character character)
        {
            Skill_Name = "Knowledge (arcana)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_dungeoneering(Character character)
        {
            Skill_Name = "Knowledge (dungeoneering)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_engineering(Character character)
        {
            Skill_Name = "Knowledge (engineering)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_geography(Character character)
        {
            Skill_Name = "Knowledge (geography)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_history(Character character)
        {
            Skill_Name = "Knowledge (history)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_local(Character character)
        {
            Skill_Name = "Knowledge (local)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_nature(Character character)
        {
            Skill_Name = "Knowledge (nature)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_nobility(Character character)
        {
            Skill_Name = "Knowledge (nobility)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_planes(Character character)
        {
            Skill_Name = "Knowledge (planes)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Knowledge_religion(Character character)
        {
            Skill_Name = "Knowledge (religion)";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Linguistics(Character character)
        {
            Skill_Name = "Linguistics";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Perception(Character character)
        {
            Skill_Name = "Perception";
            Key_Ability = character.Wisdom_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Perform(Character character)
        {
            Skill_Name = "Perform";
            Key_Ability = character.Charisma_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Profession(Character character)
        {
            Skill_Name = "Profession";
            Key_Ability = character.Wisdom_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Ride(Character character)
        {
            Skill_Name = "Ride";
            Key_Ability = character.Dexterity_Modifier;
            Untrained = true;
            ACP = true;
            return this;
        }

        public Skill Sense_Motive(Character character)
        {
            Skill_Name = "Sense Motive";
            Key_Ability = character.Wisdom_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Slight_of_Hand(Character character)
        {
            Skill_Name = "Slight of Hand";
            Key_Ability = character.Dexterity_Modifier;
            Untrained = false;
            ACP = true;
            return this;
        }

        public Skill Spellcraft(Character character)
        {
            Skill_Name = "Spellcraft";
            Key_Ability = character.Intelligence_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }

        public Skill Stealth(Character character)
        {
            Skill_Name = "Stealth";
            Key_Ability = character.Dexterity_Modifier;
            Untrained = true;
            ACP = true;
            return this;
        }

        public Skill Survival(Character character)
        {
            Skill_Name = "Survival";
            Key_Ability = character.Wisdom_Modifier;
            Untrained = true;
            ACP = false;
            return this;
        }

        public Skill Swim(Character character)
        {
            Skill_Name = "Swim";
            Key_Ability = character.Strength_Modifier;
            Untrained = true;
            ACP = true;
            return this;
        }

        public Skill Use_Magic_Device(Character character)
        {
            Skill_Name = "Use Magic Device";
            Key_Ability = character.Charisma_Modifier;
            Untrained = false;
            ACP = false;
            return this;
        }
    }
}

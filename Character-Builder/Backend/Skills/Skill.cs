using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Skills
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
    }
}

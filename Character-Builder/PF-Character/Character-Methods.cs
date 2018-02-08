using PF_Character.Skills;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PF_Character
{
    public class Character_Methods
    {
        public void UpdateSkills(Character character)
        {
            List<Skill> tempList = new List<Skill>(character.Skills_List);
            character.Skills_List.Clear();

            foreach (var item in new Skill().Skill_List(character))
            {
                var temp = (MethodBase)item;
                character.Skills_List.Add((Skill)temp.Invoke(new Skill(), new object[] { character }));
            }

            foreach (var item in character.Skills_List)
            {
                item.Ranks = tempList.Find(x => x.Skill_Name == item.Skill_Name).Ranks;
                item.Class_Skill = tempList.Find(x => x.Skill_Name == item.Skill_Name).Class_Skill;
            }
        }
    }
}

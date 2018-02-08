using System;
using PF_Character.Classes.Core.Specials;
using PF_Character;
using PF_Character.Classes;
using PF_Character.Classes.Core;
using PF_Character.Races.Core;
using System.Reflection;
using System.Collections.Generic;

namespace Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            Character_Methods methods = new Character_Methods();

            character.Strength_Score += character.Race.Strength_Bonus;
            character.Skills_List.Find(x => x.Skill_Name == "Swim").Ranks = 1;
            character.Skills_List.Find(x => x.Skill_Name == "Swim").Class_Skill = true;
            methods.UpdateSkills(character);

            /*Console.WriteLine(character.Strength_Score + " " + character.Strength_Modifier);
            Console.WriteLine(character.Dexterity_Score + " " + character.Dexterity_Modifier);
            Console.WriteLine(character.Constitution_Score + " " + character.Constitution_Modifier);
            Console.WriteLine(character.Intelligence_Score + " " + character.Intelligence_Modifier);
            Console.WriteLine(character.Wisdom_Score + " " + character.Wisdom_Modifier);
            Console.WriteLine(character.Charisma_Score + " " + character.Charisma_Modifier);*/

            foreach (var item in character.Skills_List)
            {
                Console.WriteLine(item.Bonus + " " + item.Skill_Name);
            }

            Console.ReadLine();
        }
    }
}

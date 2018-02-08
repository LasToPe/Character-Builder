using System;
using System.Collections.Generic;
using PF_Character.Races;
using PF_Character.Races.Core;
using PF_Character.Classes;
using PF_Character.Classes.Core;
using PF_Character.Skills;

namespace PF_Character
{
    public class Character
    {
        public Character()
        {
            Strength_Score = 10;
            Dexterity_Score = 10;
            Constitution_Score = 10;
            Intelligence_Score = 10;
            Wisdom_Score = 10;
            Charisma_Score = 10;
            Race = new Human("Strength");
            Character_Classes.Add(new Barbarian(this));
            Favored_Class = Character_Classes[0];
            Hit_Points = 0;
            Initiative = 0;
            Armor_Class = 10;
            Touch_AC = 10;
            FlatFooted_AC = 10;
            Skills_List = new Skill().SetUp(this);
        }

        public string Name { get; set; }

        //Ability Scores
        public int Strength_Score { get; set; }
        public int Dexterity_Score { get; set; }
        public int Constitution_Score { get; set; }
        public int Intelligence_Score { get; set; }
        public int Wisdom_Score { get; set; }
        public int Charisma_Score { get; set; }

        //Ability Modifiers
        public int Strength_Modifier => (Strength_Score - 10) / 2;
        public int Dexterity_Modifier => (Dexterity_Score - 10) / 2;
        public int Constitution_Modifier => (Constitution_Score - 10) / 2;
        public int Intelligence_Modifier => (Intelligence_Score - 10) / 2;
        public int Wisdom_Modifier => (Wisdom_Score - 10) / 2;
        public int Charisma_Modifier => (Charisma_Score - 10) / 2;

        /*//Temporary Ability Scores
        public int Temporary_Strength_Score { get; set; }
        public int Temporary_Dexterity_Score { get; set; }
        public int Temporary_Constitution_Score { get; set; }
        public int Temporary_Intelligence_Score { get; set; }
        public int Temporary_Wisdom_Score { get; set; }
        public int Temporary_Charisma_Score { get; set; }

        //Temporary Ability Modifiers
        public int Temporary_Strength_Modifier { get => (Temporary_Strength_Score - 10) / 2; }
        public int Temporary_Dexterity_Modifier { get => (Temporary_Dexterity_Score - 10) / 2; }
        public int Temporary_Constitution_Modifier { get => (Temporary_Constitution_Score - 10) / 2; }
        public int Temporary_Intelligence_Modifier { get => (Temporary_Intelligence_Score - 10) / 2; }
        public int Temporary_Wisdom_Modifier { get => (Temporary_Wisdom_Score - 10) / 2; }
        public int Temporary_Charisma_Modifier { get => (Temporary_Charisma_Score - 10) / 2; }*/

        public Race Race { get; set; }
        public List<Class> Character_Classes { get; } = new List<Class>();
        public Class Favored_Class { get; set; }

        public int Hit_Points { get; set; } //set needs change to accomodate automatic calculation
        
        public int Initiative { get; set; }

        //Armor Class
        public int Armor_Class { get; set; } //needs update when armor is implemented
        public int Touch_AC { get; set; } //needs update when armor is implemented
        public int FlatFooted_AC { get; set; } //needs update when armor is implemented

        //Saving Throw Bonuses
        public int Fortitude { get; set; }
        public int Reflex { get; set; }
        public int Will { get; set; }

        //Base Attack Bonus and Combat Maneuver Bonuses
        public int BAB {
            get
            {
                int temp = 0;
                foreach(var item in Character_Classes)
                {
                    temp += item.BAB;
                }
                return temp;
            }
        }
        public int CMB { get; set; }
        public int CMD => 10 + BAB + Strength_Modifier + Dexterity_Modifier + Race.Size.CMD_Mod;

        //Skills
        public List<Skill> Skills_List { get; set; } //Not ready yet
        public List<Skill> Class_Skills { get; set; } //Not ready yet / Needs change to loop that sets class skills

        //Feats
        //public Feats Feats { get; set; } //Not ready yet
    }
}

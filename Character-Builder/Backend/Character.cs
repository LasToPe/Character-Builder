using System;
using System.Collections.Generic;
using Backend.Races;
using Backend.Classes;

namespace Backend
{
    public class Character
    {
        public string Name { get; set; }

        //Ability Scores
        public int Strength_Score { get; set; }
        public int Dexterity_Score { get; set; }
        public int Constitution_Score { get; set; }
        public int Intelligence_Score { get; set; }
        public int Wisdom_Score { get; set; }
        public int Charisma_Score { get; set; }

        //Ability Modifiers
        public int Strength_Modifier { get => (Strength_Score - 10) / 2; }
        public int Dexterity_Modifier { get => (Dexterity_Score - 10) / 2; }
        public int Constitution_Modifier { get => (Constitution_Score - 10) / 2; }
        public int Intelligence_Modifier { get => (Intelligence_Score - 10) / 2; }
        public int Wisdom_Modifier { get => (Wisdom_Score - 10) / 2; }
        public int Charisma_Modifier { get => (Charisma_Score - 10) / 2; }

        //Temporary Ability Scores
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
        public int Temporary_Charisma_Modifier { get => (Temporary_Charisma_Score - 10) / 2; }

        public Race Race { get; set; }
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
        public int BAB { get; set; }
        public int CMB { get; set; }
        public int CMD { get; set; }

        //Skills
        //public Skills Skills { get; set; } //Not ready yet

        //Feats
        //public Feats Feats { get; set; } //Not ready yet
    }
}

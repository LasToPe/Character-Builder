using System;
using System.Collections.Generic;

namespace Backend
{
    public class Character
    {
        public int Strength_Score { get => Strength_Score; set => Strength_Score = value; }
        public int Dexterity_Score { get => Dexterity_Score; set => Dexterity_Score = value; }
        public int Constitution_Score { get => Constitution_Score; set => Constitution_Score = value; }
        public int Intelligence_Score { get => Intelligence_Score; set => Intelligence_Score = value; }
        public int Wisdom_Score { get => Wisdom_Score; set => Wisdom_Score = value; }
        public int Charisma_Score { get => Charisma_Score; set => Charisma_Score = value; }

        public int Strength_Modifier { get => (Strength_Score - 10) / 2; }
        public int Dexterity_Modifier { get => (Dexterity_Score - 10) / 2; }
        public int Constitution_Modifier { get => (Constitution_Score - 10) / 2; }
        public int Intelligence_Modifier { get => (Intelligence_Score - 10) / 2; }
        public int Wisdom_Modifier { get => (Wisdom_Score - 10) / 2; }
        public int Charisma_Modifier { get => (Charisma_Score - 10) / 2; }

        public Race.Race Race { get => Race; set => Race = value; }
        public Class.Class Favored_Class { get => Favored_Class; set => Favored_Class = value; }
    }
}

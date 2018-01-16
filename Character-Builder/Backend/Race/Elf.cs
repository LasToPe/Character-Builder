﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Race
{
    class Elf : Race
    {
        public override int Strength_Bonus => 0;
        public override int Dexterity_Bonus => 2;
        public override int Constitution_Bonus => -2;
        public override int Intelligence_Bonus => 2;
        public override int Wisdom_Bonus => 0;
        public override int Charisma_Bonus => 0;

        public override Size Size => Size.Medium();

        public override string Type => "Humanoid (elf)";

        public override int Base_Speed => 30;

        public override List<string> Langauges
        {
            get
            {
                Langauges.Add("Common");
                Langauges.Add("Elven");
                return Langauges;
            }
        }
    }
}

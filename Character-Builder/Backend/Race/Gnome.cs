﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Race
{
    class Gnome : Race
    {
        public override int Strength_Bonus => -2;
        public override int Dexterity_Bonus => 0;
        public override int Constitution_Bonus => 2;
        public override int Intelligence_Bonus => 0;
        public override int Wisdom_Bonus => 0;
        public override int Charisma_Bonus => 2;

        public override Size Size => Size.Small();

        public override string Type => "Humanoid (gnome)";

        public override int Base_Speed => 20;

        public override List<string> Langauges
        {
            get
            {
                Langauges.Add("Common");
                Langauges.Add("Gnome");
                Langauges.Add("Sylvan");
                return Langauges;
            }
        }
    }
}

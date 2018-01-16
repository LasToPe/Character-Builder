using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Race
{
    class Race_v2
    {
        public int Strength_Bonus { get; set; }
        public int Dexterity_Bonus { get; set; }
        public int Constitution_Bonus { get; set; }
        public int Intelligence_Bonus { get; set; }
        public int Wisdom_Bonus { get; set; }
        public int Charisma_Bonus { get; set; }

        public Size Size { get; set; }

        public string Type { get; set; }

        public int Base_Speed { get; set; }

        public List<string> Langauges { get; set; }

        //public List<Racial_Trait> Racial_Traits { get; set; } //Racial traits not ready
    }
}
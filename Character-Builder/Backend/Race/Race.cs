using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Race
{
    public abstract class Race
    {
        public abstract int Strength_Bonus { get; set; }
        public abstract int Dexterity_Bonus { get; set; }
        public abstract int Constitution_Bonus { get; set; }
        public abstract int Intelligence_Bonus { get; set; }
        public abstract int Wisdom_Bonus { get; set; }
        public abstract int Charisma_Bonus { get; set; }

        //public abstract Size Size { get; set; } //Size not ready

        //public abstract Type Type { get; set; } //Type not ready

        public abstract int Base_Speed { get; set;}

        public abstract List<string> Langauges { get; set; }

        //public abstract List<Racial_Trait> Racial_Traits { get; set; } //Racial traits not ready
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Race
{
    public abstract class Race
    {
        public abstract int Strength_Bonus { get; }
        public abstract int Dexterity_Bonus { get; }
        public abstract int Constitution_Bonus { get; }
        public abstract int Intelligence_Bonus { get; }
        public abstract int Wisdom_Bonus { get; }
        public abstract int Charisma_Bonus { get; }

        public abstract Size Size { get; }

        public abstract string Type { get; }

        public abstract int Base_Speed { get; }

        public abstract List<string> Langauges { get; }

        //public abstract List<Racial_Trait> Racial_Traits { get; set; } //Racial traits not ready
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Magic
{
    class Spell
    {
        public string Name { get; set; }

        public Magic_School School { get; set; }
        public Sub_School Sub_School { get; set; }
        public List<Descriptor> Descriptors { get; } = new List<Descriptor>();

        public Dictionary<string, int> Level { get; } = new Dictionary<string, int>(); //class name, spell level

        public string Casting_Time { get; set; }
        public List<string> Components { get; } = new List<string>();

        public string Range { get; set; }
        public string Target { get; set; }
        public string Duration { get; set; }
        public string Saving_Throw { get; set; }
        public string Spell_Resistance { get; set; }

        public string Description { get; set; }
    }
}

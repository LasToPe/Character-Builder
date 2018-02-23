using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PF_Character;
using PF_Character.Races;
using PF_Character.Races.Core;

namespace Character_Builder.Models
{
    public class ContentModel
    {
        public static int TestInt { get; set; }

        public static Character character = new Character();

        public static List<Race> Core_Races = new List<Race>
        {
            new Dwarf(character),
            new Elf(character),
            new Gnome(character),
            new Half_elf(null, character),
            new Halfling(character),
            new Half_orc(null, character),
            new Human(null, character)
        };
    }
}

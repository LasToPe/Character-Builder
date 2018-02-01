using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Specials;

namespace Backend.Classes.Core
{
    class Rogue : Class
    {
        public Rogue(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level * 3 / 4;
            Specials.Add(new Rogue_Specials().Sneak_Attack(this));
            Specials.Add(new Rogue_Specials().Trapfinding(this));
        }

        public override void Level_02()
        {
            Specials.Add(new Rogue_Specials().Evasion());
            Specials.Add(new Rogue_Specials().Rogue_Talent());
        }

        public override void Level_03()
        {
            Specials.Add(new Rogue_Specials().Trap_Sense(this));
        }

        public override void Level_04()
        {
            Specials.Add(new Rogue_Specials().Rogue_Talent());
            Specials.Add(new Rogue_Specials().Uncanny_Dodge());
        }

        public override void Level_05()
        {
            
        }

        public override void Level_06()
        {
            Specials.Add(new Rogue_Specials().Rogue_Talent());
        }

        public override void Level_07()
        {
            
        }

        public override void Level_08()
        {
            Specials.Add(new Rogue_Specials().Improved_Uncanny_Dodge());
            Specials.Add(new Rogue_Specials().Rogue_Talent());
        }

        public override void Level_09()
        {
            
        }

        public override void Level_10()
        {
            Specials.Add(new Rogue_Specials().Advanced_Talents());
        }

        public override void Level_11()
        {
            
        }

        public override void Level_12()
        {
            Specials.Add(new Rogue_Specials().Rogue_Talent());
        }

        public override void Level_13()
        {
            
        }

        public override void Level_14()
        {
            Specials.Add(new Rogue_Specials().Rogue_Talent());
        }

        public override void Level_15()
        {
            
        }

        public override void Level_16()
        {
            Specials.Add(new Rogue_Specials().Rogue_Talent());
        }

        public override void Level_17()
        {
            
        }

        public override void Level_18()
        {
            Specials.Add(new Rogue_Specials().Rogue_Talent());
        }

        public override void Level_19()
        {
            
        }

        public override void Level_20()
        {
            Specials.Add(new Rogue_Specials().Master_Strike());
            Specials.Add(new Rogue_Specials().Rogue_Talent());
        }
    }
}

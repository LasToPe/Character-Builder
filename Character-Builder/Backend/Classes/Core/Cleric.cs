using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Classes.Core.Specials;

namespace PF_Character.Classes.Core
{
    public class Cleric : Class
    {
        //public List<Domain> Domains { get; } = new List<Domain>(); //domains to be set up (after spells?)

        public Cleric(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level * 3 / 4;
            Specials.Add(new Cleric_Specials().Aura());
            Specials.Add(new Cleric_Specials().Channel_Energy(this));
            Specials.Add(new Cleric_Specials().Domains());
            Specials.Add(new Cleric_Specials().Spontaneous_Casting());
        }
        
        public override void Level_02()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_03()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_04()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_05()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_06()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_07()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_08()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_09()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_10()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_11()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_12()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_13()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_14()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_15()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_16()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_17()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_18()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_19()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_20()
        {
            BAB = Level * 3 / 4;
        }
    }
}

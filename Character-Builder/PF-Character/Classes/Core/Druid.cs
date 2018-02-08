using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Classes.Core.Specials;

namespace PF_Character.Classes.Core
{
    public class Druid : Class
    {
        public Druid(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level * 3 / 4;
            Specials.Add(new Druid_Specials().Nature_Bond());
            Specials.Add(new Druid_Specials().Nature_Sense());
            Specials.Add(new Druid_Specials().Wild_Empathy());
        }

        public override void Level_02()
        {
            //BAB = Level * 3 / 4;
            Specials.Add(new Druid_Specials().Woodland_Stride());
        }

        public override void Level_03()
        {
            //BAB = Level * 3 / 4;
            Specials.Add(new Druid_Specials().Trackless_Step());
        }

        public override void Level_04()
        {
            //BAB = Level * 3 / 4;
            Specials.Add(new Druid_Specials().Resist_Natures_Lure());
            Specials.Add(new Druid_Specials().Wild_Shape());
        }

        public override void Level_05()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_06()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_07()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_08()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_09()
        {
            //BAB = Level * 3 / 4;
            Specials.Add(new Druid_Specials().Venom_Immunity());
        }

        public override void Level_10()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_11()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_12()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_13()
        {
            //BAB = Level * 3 / 4;
            Specials.Add(new Druid_Specials().A_Thousand_Faces());
        }

        public override void Level_14()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_15()
        {
            //BAB = Level * 3 / 4;
            Specials.Add(new Druid_Specials().Timeless_Body());
        }

        public override void Level_16()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_17()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_18()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_19()
        {
            //BAB = Level * 3 / 4;
        }

        public override void Level_20()
        {
            //BAB = Level * 3 / 4;
        }
    }
}

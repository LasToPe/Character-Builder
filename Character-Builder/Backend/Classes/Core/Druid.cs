using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Druid : Class
    {
        public Druid(Character character) : base(character)
        {
        }

        public override void Level_1()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Druid_Class_Features().Nature_Bond());
            Class_Features.Add(new Druid_Class_Features().Nature_Sense());
            Class_Features.Add(new Druid_Class_Features().Wild_Empathy());
        }

        public override void Level_2()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Druid_Class_Features().Woodland_Stride());
        }

        public override void Level_3()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Druid_Class_Features().Trackless_Step());
        }

        public override void Level_4()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Druid_Class_Features().Resist_Natures_Lure());
            Class_Features.Add(new Druid_Class_Features().Wild_Shape());
        }

        public override void Level_5()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_6()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_7()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_8()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_9()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Druid_Class_Features().Venom_Immunity());
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
            Class_Features.Add(new Druid_Class_Features().A_Thousand_Faces());
        }

        public override void Level_14()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_15()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Druid_Class_Features().Timeless_Body());
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

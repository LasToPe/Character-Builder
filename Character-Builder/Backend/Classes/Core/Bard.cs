using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Bard : Class
    {
        public List<Bardic_Performance> Bardic_Performances { get; } = new List<Bardic_Performance>();

        public Bard(Character character) : base(character)
        {
        }

        public override void Level_1()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Class_Features().Bardic_Knowledge(this));
            Class_Features.Add(new Bard_Class_Features().Bardic_Performance(this));
        }

        public override void Level_2()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Class_Features().Versatile_Performance());
            Class_Features.Add(new Bard_Class_Features().Well_Versed());
        }

        public override void Level_3()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_4()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Class_Features().Lore_Master(this));
        }

        public override void Level_5()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Class_Features().Versatile_Performance());
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
        }

        public override void Level_10()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Class_Features().Jack_of_All_Trades());
            Class_Features.Add(new Bard_Class_Features().Versatile_Performance());
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
            Class_Features.Add(new Bard_Class_Features().Versatile_Performance());
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
            Class_Features.Add(new Bard_Class_Features().Versatile_Performance());
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

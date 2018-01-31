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

        public override void Level_01()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Specials().Bardic_Knowledge(this));
            Class_Features.Add(new Bard_Specials().Bardic_Performance(this));
        }

        public override void Level_02()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Specials().Versatile_Performance());
            Class_Features.Add(new Bard_Specials().Well_Versed());
        }

        public override void Level_03()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_04()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Specials().Lore_Master(this));
        }

        public override void Level_05()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Bard_Specials().Versatile_Performance());
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
            Class_Features.Add(new Bard_Specials().Jack_of_All_Trades());
            Class_Features.Add(new Bard_Specials().Versatile_Performance());
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
            Class_Features.Add(new Bard_Specials().Versatile_Performance());
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
            Class_Features.Add(new Bard_Specials().Versatile_Performance());
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

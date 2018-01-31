using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    class Monk : Class
    {
        public Monk(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Monk_Specials().Bonus_Feat(this));
            Class_Features.Add(new Monk_Specials().Flurry_of_Blows(this));
            Class_Features.Add(new Monk_Specials().Stunning_Fist(this));
            Class_Features.Add(new Monk_Specials().Unarmed_Strike(this));
        }

        public override void Level_02()
        {
            Class_Features.Add(new Monk_Specials().Bonus_Feat(this));
            Class_Features.Add(new Monk_Specials().Evasion();
        }

        public override void Level_03()
        {
            Class_Features.Add(new Monk_Specials().Fast_Movement(this));
            Class_Features.Add(new Monk_Specials().Maneuver_Training(this));
            Class_Features.Add(new Monk_Specials().Still_Mind());
        }

        public override void Level_04()
        {
            Class_Features.Add(new Monk_Specials().Ki_Pool(this));
            Class_Features.Add(new Monk_Specials().Slow_Fall(this));
        }

        public override void Level_05()
        {
            Class_Features.Add(new Monk_Specials().High_Jump());
            Class_Features.Add(new Monk_Specials().Purity_of_Body());
        }

        public override void Level_06()
        {
            Class_Features.Add(new Monk_Specials().Bonus_Feat(this));
        }

        public override void Level_07()
        {
            Class_Features.Add(new Monk_Specials().Wholeness_of_Body());
        }

        public override void Level_08()
        {
            
        }

        public override void Level_09()
        {
            Class_Features.Add(new Monk_Specials().Improved_Evasion());
        }

        public override void Level_10()
        {
            Class_Features.Add(new Monk_Specials().Bonus_Feat(this));
        }

        public override void Level_11()
        {
            Class_Features.Add(new Monk_Specials().Diamond_Body());
        }

        public override void Level_12()
        {
            Class_Features.Add(new Monk_Specials().Abundant_Step());
        }

        public override void Level_13()
        {
            Class_Features.Add(new Monk_Specials().Diamond_Soul(this));
        }

        public override void Level_14()
        {
            Class_Features.Add(new Monk_Specials().Bonus_Feat(this));
        }

        public override void Level_15()
        {
            Class_Features.Add(new Monk_Specials().Quivering_Palm());
        }

        public override void Level_16()
        {
            
        }

        public override void Level_17()
        {
            Class_Features.Add(new Monk_Specials().Timeless_Body());
            Class_Features.Add(new Monk_Specials().Tongue_of_the_Sun_and_Moon());
        }

        public override void Level_18()
        {
            Class_Features.Add(new Monk_Specials().Bonus_Feat(this));
        }

        public override void Level_19()
        {
            Class_Features.Add(new Monk_Specials().Empty_Body());
        }

        public override void Level_20()
        {
            Class_Features.Add(new Monk_Specials().Perfect_Self());
        }
    }
}

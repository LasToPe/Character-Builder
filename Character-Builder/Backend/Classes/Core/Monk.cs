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
            Class_Features.Add(new Monk_Class_Features().Bonus_Feat(this));
            Class_Features.Add(new Monk_Class_Features().Flurry_of_Blows(this));
            Class_Features.Add(new Monk_Class_Features().Stunning_Fist(this));
            Class_Features.Add(new Monk_Class_Features().Unarmed_Strike(this));
        }

        public override void Level_02()
        {
            Class_Features.Add(new Monk_Class_Features().Bonus_Feat(this));
            Class_Features.Add(new Monk_Class_Features().Evasion();
        }

        public override void Level_03()
        {
            Class_Features.Add(new Monk_Class_Features().Fast_Movement(this));
            Class_Features.Add(new Monk_Class_Features().Maneuver_Training(this));
            Class_Features.Add(new Monk_Class_Features().Still_Mind());
        }

        public override void Level_04()
        {
            Class_Features.Add(new Monk_Class_Features().Ki_Pool(this));
            Class_Features.Add(new Monk_Class_Features().Slow_Fall(this));
        }

        public override void Level_05()
        {
            Class_Features.Add(new Monk_Class_Features().High_Jump());
            Class_Features.Add(new Monk_Class_Features().Purity_of_Body());
        }

        public override void Level_06()
        {
            Class_Features.Add(new Monk_Class_Features().Bonus_Feat(this));
        }

        public override void Level_07()
        {
            Class_Features.Add(new Monk_Class_Features().Wholeness_of_Body());
        }

        public override void Level_08()
        {
            
        }

        public override void Level_09()
        {
            Class_Features.Add(new Monk_Class_Features().Improved_Evasion());
        }

        public override void Level_10()
        {
            Class_Features.Add(new Monk_Class_Features().Bonus_Feat(this));
        }

        public override void Level_11()
        {
            Class_Features.Add(new Monk_Class_Features().Diamond_Body());
        }

        public override void Level_12()
        {
            Class_Features.Add(new Monk_Class_Features().Abundant_Step());
        }

        public override void Level_13()
        {
            Class_Features.Add(new Monk_Class_Features().Diamond_Soul(this));
        }

        public override void Level_14()
        {
            Class_Features.Add(new Monk_Class_Features().Bonus_Feat(this));
        }

        public override void Level_15()
        {
            Class_Features.Add(new Monk_Class_Features().Quivering_Palm());
        }

        public override void Level_16()
        {
            
        }

        public override void Level_17()
        {
            Class_Features.Add(new Monk_Class_Features().Timeless_Body());
            Class_Features.Add(new Monk_Class_Features().Tongue_of_the_Sun_and_Moon());
        }

        public override void Level_18()
        {
            Class_Features.Add(new Monk_Class_Features().Bonus_Feat(this));
        }

        public override void Level_19()
        {
            Class_Features.Add(new Monk_Class_Features().Empty_Body());
        }

        public override void Level_20()
        {
            Class_Features.Add(new Monk_Class_Features().Perfect_Self());
        }
    }
}

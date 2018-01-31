using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    class Fighter : Class
    {
        public Fighter(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level;
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_02()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
            Class_Features.Add(new Fighter_Specials().Bravery(this));
        }

        public override void Level_03()
        {
            Class_Features.Add(new Fighter_Specials().Armor_Training(this));
        }

        public override void Level_04()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_05()
        {
            Class_Features.Add(new Fighter_Specials().Weapon_Training(this));
        }

        public override void Level_06()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_07()
        {
            //Advanced armor training
        }

        public override void Level_08()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_09()
        {
            Class_Features.Add(new Fighter_Specials().Weapon_Training(this));
            //Advanced Weapon Training
        }

        public override void Level_10()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_11()
        {
            //Armor Training / Advanced Armor Training
        }

        public override void Level_12()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_13()
        {
            Class_Features.Add(new Fighter_Specials().Weapon_Training(this));
        }

        public override void Level_14()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_15()
        {
            //Armor Training / Advanced Armor Training
        }

        public override void Level_16()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_17()
        {
            Class_Features.Add(new Fighter_Specials().Weapon_Training(this));
        }

        public override void Level_18()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_19()
        {
            Class_Features.Add(new Fighter_Specials().Armor_Mastery(this));
        }

        public override void Level_20()
        {
            Class_Features.Add(new Fighter_Specials().Bonus_Feats(this));
            Class_Features.Add(new Fighter_Specials().Weapon_Mastery(this));
        }
    }
}

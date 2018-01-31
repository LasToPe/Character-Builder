using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Specials;

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
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_02()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
            Specials.Add(new Fighter_Specials().Bravery(this));
        }

        public override void Level_03()
        {
            Specials.Add(new Fighter_Specials().Armor_Training(this));
        }

        public override void Level_04()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_05()
        {
            Specials.Add(new Fighter_Specials().Weapon_Training(this));
        }

        public override void Level_06()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_07()
        {
            //Advanced armor training
        }

        public override void Level_08()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_09()
        {
            Specials.Add(new Fighter_Specials().Weapon_Training(this));
            //Advanced Weapon Training
        }

        public override void Level_10()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_11()
        {
            //Armor Training / Advanced Armor Training
        }

        public override void Level_12()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_13()
        {
            Specials.Add(new Fighter_Specials().Weapon_Training(this));
        }

        public override void Level_14()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_15()
        {
            //Armor Training / Advanced Armor Training
        }

        public override void Level_16()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_17()
        {
            Specials.Add(new Fighter_Specials().Weapon_Training(this));
        }

        public override void Level_18()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
        }

        public override void Level_19()
        {
            Specials.Add(new Fighter_Specials().Armor_Mastery(this));
        }

        public override void Level_20()
        {
            Specials.Add(new Fighter_Specials().Bonus_Feats(this));
            Specials.Add(new Fighter_Specials().Weapon_Mastery(this));
        }
    }
}

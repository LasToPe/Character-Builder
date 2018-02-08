using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Classes.Core.Specials;

namespace PF_Character.Classes.Core
{
    class Sorcerer : Class
    {
        public Sorcerer(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level / 2;
            Specials.Add(new Sorcerer_Specials().Bloodline());
            Specials.Add(new Sorcerer_Specials().Bloodline_Power());
            Specials.Add(new Sorcerer_Specials().Cantrips());
            Specials.Add(new Sorcerer_Specials().Eschew_Materials());
        }

        public override void Level_02()
        {
            
        }

        public override void Level_03()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Power());
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_04()
        {
            
        }

        public override void Level_05()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_06()
        {
            
        }

        public override void Level_07()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Feat());
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_08()
        {
            
        }

        public override void Level_09()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Power());
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_10()
        {
            
        }

        public override void Level_11()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_12()
        {
            
        }

        public override void Level_13()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Feat());
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_14()
        {
            
        }

        public override void Level_15()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Power());
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_16()
        {
            
        }

        public override void Level_17()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_18()
        {
            
        }

        public override void Level_19()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Feat());
            Specials.Add(new Sorcerer_Specials().Bloodline_Spell());
        }

        public override void Level_20()
        {
            Specials.Add(new Sorcerer_Specials().Bloodline_Power());
        }
    }
}

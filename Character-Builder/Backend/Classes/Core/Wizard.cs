using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Classes.Core.Specials;

namespace PF_Character.Classes.Core
{
    class Wizard : Class
    {
        public Wizard(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level / 2;
            Specials.Add(new Wizard_Specials().Arcane_Bond());
            Specials.Add(new Wizard_Specials().Arcane_School());
            Specials.Add(new Wizard_Specials().Cantrips());
            Specials.Add(new Wizard_Specials().Scribe_Scroll());
        }

        public override void Level_02()
        {
            
        }

        public override void Level_03()
        {
            
        }

        public override void Level_04()
        {
            
        }

        public override void Level_05()
        {
            Specials.Add(new Wizard_Specials().Bonus_Feat());
        }

        public override void Level_06()
        {
            
        }

        public override void Level_07()
        {
            
        }

        public override void Level_08()
        {
            
        }

        public override void Level_09()
        {
            
        }

        public override void Level_10()
        {
            Specials.Add(new Wizard_Specials().Bonus_Feat());
        }

        public override void Level_11()
        {
            
        }

        public override void Level_12()
        {
            
        }

        public override void Level_13()
        {
            
        }

        public override void Level_14()
        {
            
        }

        public override void Level_15()
        {
            Specials.Add(new Wizard_Specials().Bonus_Feat());
        }

        public override void Level_16()
        {
            
        }

        public override void Level_17()
        {
            
        }

        public override void Level_18()
        {
            
        }

        public override void Level_19()
        {
            
        }

        public override void Level_20()
        {
            Specials.Add(new Wizard_Specials().Bonus_Feat());
        }
    }
}

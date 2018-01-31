using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Specials;

namespace Backend.Classes.Core
{
    class Paladin : Class
    {
        public Paladin(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level;
            Specials.Add(new Paladin_Specials().Aura_of_Good());
            Specials.Add(new Paladin_Specials().Detect_Evil());
            Specials.Add(new Paladin_Specials().Smite_Evil(this));
        }

        public override void Level_02()
        {
            Specials.Add(new Paladin_Specials().Divine_Grace());
            Specials.Add(new Paladin_Specials().Lay_On_Hands(this));
        }

        public override void Level_03()
        {
            Specials.Add(new Paladin_Specials().Aura_of_Courage());
            Specials.Add(new Paladin_Specials().Divine_Health());
            Specials.Add(new Paladin_Specials().Mercy());
        }

        public override void Level_04()
        {
            Specials.Add(new Paladin_Specials().Channel_Positive_Energy(this));
        }

        public override void Level_05()
        {
            Specials.Add(new Paladin_Specials().Divine_Bond());
        }

        public override void Level_06()
        {
            Specials.Add(new Paladin_Specials().Mercy());
        }

        public override void Level_07()
        {
            
        }

        public override void Level_08()
        {
            Specials.Add(new Paladin_Specials().Aura_of_Resolve());
        }

        public override void Level_09()
        {
            Specials.Add(new Paladin_Specials().Mercy());
        }

        public override void Level_10()
        {
            
        }

        public override void Level_11()
        {
            Specials.Add(new Paladin_Specials().Aura_of_Justice());
        }

        public override void Level_12()
        {
            Specials.Add(new Paladin_Specials().Mercy());
        }

        public override void Level_13()
        {
            
        }

        public override void Level_14()
        {
            Specials.Add(new Paladin_Specials().Aura_of_Faith());
        }

        public override void Level_15()
        {
            Specials.Add(new Paladin_Specials().Mercy());
        }

        public override void Level_16()
        {
            
        }

        public override void Level_17()
        {
            Specials.Add(new Paladin_Specials().Aura_of_Righteousness());
        }

        public override void Level_18()
        {
            Specials.Add(new Paladin_Specials().Mercy());
        }

        public override void Level_19()
        {
            
        }

        public override void Level_20()
        {
            Specials.Add(new Paladin_Specials().Holy_Champion());
        }
    }
}

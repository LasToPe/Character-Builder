using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Cleric : Class
    {
        //public List<Domain> Domains { get; } = new List<Domain>(); //domains to be set up (after spells?)

        public Cleric(Character character) : base(character)
        {
        }

        public override void Level_1()
        {
            BAB = Level * 3 / 4;
            Class_Features.Add(new Cleric_Class_Features().Aura());
            Class_Features.Add(new Cleric_Class_Features().Channel_Energy(this));
            Class_Features.Add(new Cleric_Class_Features().Domains());
            Class_Features.Add(new Cleric_Class_Features().Spontaneous_Casting());
        }
        
        public override void Level_2()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_3()
        {
            BAB = Level * 3 / 4;
        }

        public override void Level_4()
        {
            BAB = Level * 3 / 4;
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
        }

        public override void Level_14()
        {
            BAB = Level * 3 / 4;
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

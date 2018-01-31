using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Barbarian : Class
    {        
        public List<Rage_Power> Rage_Powers { get; } = new List<Rage_Power>();

        public Barbarian(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Fast_Movement(character));
            Class_Features.Add(new Barbarian_Specials().Rage());
        }

        public override void Level_02()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
            Class_Features.Add(new Barbarian_Specials().Uncanny_Dodge());
        }

        public override void Level_03()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Trap_Sense(this));
        }

        public override void Level_04()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }

        public override void Level_05()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Improved_Uncanny_Dodge());
        }

        public override void Level_06()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }

        public override void Level_07()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Damage_Reduction(character, this));
        }

        public override void Level_08()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }

        public override void Level_09()
        {
            BAB = Level;
            //no imidiate impact
        }

        public override void Level_10()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }

        public override void Level_11()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Greater_Rage());
        }

        public override void Level_12()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }

        public override void Level_13()
        {
            BAB = Level;
            //no imidiate impact
        }

        public override void Level_14()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Indomitable_Will());
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }

        public override void Level_15()
        {
            BAB = Level;
            //no imidiate impact
        }

        public override void Level_16()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }

        public override void Level_17()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Tireless_Rage());
        }

        public override void Level_18()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }

        public override void Level_19()
        {
            BAB = Level;
            //no imidiate impact
        }

        public override void Level_20()
        {
            BAB = Level;
            Class_Features.Add(new Barbarian_Specials().Mighty_Rage());
            Class_Features.Add(new Barbarian_Specials().Rage_Powers(this));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using PF_Character.Classes.Core.Specials;

namespace PF_Character.Classes.Core
{
    class Ranger : Class
    {
        public List<object> Favored_Enemy { get; } = new List<object>();
        public List<object> Favored_Terrain { get; } = new List<object>();

        public Ranger(Character character) : base(character)
        {
        }

        public override void Level_01()
        {
            BAB = Level;
            Specials.Add(new Ranger_Specials().Favored_Enemy());
            Specials.Add(new Ranger_Specials().Track(this));
            Specials.Add(new Ranger_Specials().Wild_Empathy());
        }

        public override void Level_02()
        {
            Specials.Add(new Ranger_Specials().Combat_Style());
            Specials.Add(new Ranger_Specials().Combat_Style_Feat());
        }

        public override void Level_03()
        {
            Specials.Add(new Ranger_Specials().Endurance());
            Specials.Add(new Ranger_Specials().Favored_Terrain());
        }

        public override void Level_04()
        {
            Specials.Add(new Ranger_Specials().Hunters_Bond());
        }

        public override void Level_05()
        {
            Specials.Add(new Ranger_Specials().Favored_Enemy());
        }

        public override void Level_06()
        {
            Specials.Add(new Ranger_Specials().Combat_Style_Feat());
        }

        public override void Level_07()
        {
            Specials.Add(new Ranger_Specials().Woodland_Stride());
        }

        public override void Level_08()
        {
            Specials.Add(new Ranger_Specials().Swift_Tracker());
            Specials.Add(new Ranger_Specials().Favored_Terrain());
        }

        public override void Level_09()
        {
            Specials.Add(new Ranger_Specials().Evasion());
        }

        public override void Level_10()
        {
            Specials.Add(new Ranger_Specials().Favored_Enemy());
            Specials.Add(new Ranger_Specials().Combat_Style_Feat());
        }

        public override void Level_11()
        {
            Specials.Add(new Ranger_Specials().Quarry());
        }

        public override void Level_12()
        {
            Specials.Add(new Ranger_Specials().Camouflage());
        }

        public override void Level_13()
        {
            Specials.Add(new Ranger_Specials().Favored_Terrain());
        }

        public override void Level_14()
        {
            Specials.Add(new Ranger_Specials().Combat_Style_Feat());
        }

        public override void Level_15()
        {
            Specials.Add(new Ranger_Specials().Favored_Enemy());
        }

        public override void Level_16()
        {
            Specials.Add(new Ranger_Specials().Improved_Evasion());
        }

        public override void Level_17()
        {
            Specials.Add(new Ranger_Specials().Hide_in_Plain_Sight());
        }

        public override void Level_18()
        {
            Specials.Add(new Ranger_Specials().Favored_Terrain());
            Specials.Add(new Ranger_Specials().Combat_Style_Feat());
        }

        public override void Level_19()
        {
            Specials.Add(new Ranger_Specials().Improved_Quarry());
        }

        public override void Level_20()
        {
            Specials.Add(new Ranger_Specials().Favored_Enemy());
            Specials.Add(new Ranger_Specials().Master_Hunter());
        }
    }
}

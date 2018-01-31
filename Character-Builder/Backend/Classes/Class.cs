using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Classes
{
    public abstract class Class
    {
        protected Character character;
        public int Level { get; set; }
        public int BAB { get; set; }
        public List<Special> Class_Features { get; } = new List<Special>();
        protected static List<Action> levelList;

        public Class(Character character)
        {
            this.character = character;

            Level = 1;

            levelList = new List<Action>
            {
                Level_01, Level_02, Level_03, Level_04, Level_05, Level_06, Level_07, Level_08, Level_09, Level_10,
                Level_11, Level_12, Level_13, Level_14, Level_15, Level_16, Level_17, Level_18, Level_19, Level_20
            };

            Update();
        }

        public void Update()
        {
            Class_Features.Clear();
            for (int i = 0; i < Level; i++)
            {
                levelList[i]();
            }
        }

        public abstract void Level_01();
        public abstract void Level_02();
        public abstract void Level_03();
        public abstract void Level_04();
        public abstract void Level_05();
        public abstract void Level_06();
        public abstract void Level_07();
        public abstract void Level_08();
        public abstract void Level_09();
        public abstract void Level_10();
        public abstract void Level_11();
        public abstract void Level_12();
        public abstract void Level_13();
        public abstract void Level_14();
        public abstract void Level_15();
        public abstract void Level_16();
        public abstract void Level_17();
        public abstract void Level_18();
        public abstract void Level_19();
        public abstract void Level_20();
    }
}

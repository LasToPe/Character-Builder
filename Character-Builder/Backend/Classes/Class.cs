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
        public List<Class_Feature> Class_Features { get; } = new List<Class_Feature>();
        protected static List<Action> levelList;

        public Class(Character character)
        {
            this.character = character;

            Level = 1;

            levelList = new List<Action>
            {
                Level_1, Level_2, Level_3, Level_4, Level_5, Level_6, Level_7, Level_8, Level_9, Level_10,
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

        public abstract void Level_1();
        public abstract void Level_2();
        public abstract void Level_3();
        public abstract void Level_4();
        public abstract void Level_5();
        public abstract void Level_6();
        public abstract void Level_7();
        public abstract void Level_8();
        public abstract void Level_9();
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

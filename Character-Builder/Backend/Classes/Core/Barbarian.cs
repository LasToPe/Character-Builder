using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Barbarian : Class
    {
        public Barbarian()
        {
            Barbarian_Class_Features class_Features = new Barbarian_Class_Features();
        }

        public List<Rage_Power> Rage_Powers { get; } = new List<Rage_Power>();
    }
}

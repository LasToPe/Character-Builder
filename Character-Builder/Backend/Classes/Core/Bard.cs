using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Bard : Class
    {
        public Bard()
        {
            Bard_Class_Features class_Features = new Bard_Class_Features();
        }

        public List<Bardic_Performance> Bardic_Performances { get; } = new List<Bardic_Performance>();
    }
}

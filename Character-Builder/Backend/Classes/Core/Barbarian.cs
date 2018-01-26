using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Barbarian : Class
    {
        public List<Rage_Power> Rage_Powers { get; } = new List<Rage_Power>();
        public Barbarian()
        {
        }
    }
}

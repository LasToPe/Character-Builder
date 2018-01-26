using System;
using System.Collections.Generic;
using System.Text;
using Backend.Classes.Core.Class_Features;

namespace Backend.Classes.Core
{
    public class Cleric : Class
    {
        //public List<Domain> Domains { get; } = new List<Domain>(); //domains to be set up

        public Cleric()
        {
            Cleric_Class_Features class_Features = new Cleric_Class_Features();
        }
    }
}

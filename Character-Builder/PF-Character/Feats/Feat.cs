using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Feats
{
    public class Feat
    {
        public string Feat_Type { get; set; }
        public List<object> Prerequisites { get; } = new List<object>();
        public string Name { get; set; }
        public string Description { get; set; }

        public Feat() { }
    }
}

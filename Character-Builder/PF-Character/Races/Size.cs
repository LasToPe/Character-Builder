using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Races
{
    public class Size
    {
        public string Name { get; set; }
        public int AC_Mod { get; set; }
        public int Attack_Roll_Mod { get; set; }
        public int CMB_Mod { get; set; }
        public int CMD_Mod { get; set; }
        public int Fly_Mod { get; set; }
        public int Stealth_Mod { get; set; }

        public Size Medium()
        {
            Name = "Medium";
            AC_Mod = 0;
            Attack_Roll_Mod = 0;
            CMB_Mod = 0;
            CMD_Mod = 0;
            Fly_Mod = 0;
            Stealth_Mod = 0;

            return this;
        }

        public Size Small()
        {
            Name = "Small";
            AC_Mod = 1;
            Attack_Roll_Mod = 1;
            CMB_Mod = -1;
            CMD_Mod = -1;
            Fly_Mod = 2;
            Stealth_Mod = 4;

            return this;
        }

        public Size Large()
        {
            Name = "Large";
            AC_Mod = -1;
            Attack_Roll_Mod = -1;
            CMB_Mod = 1;
            CMD_Mod = 1;
            Fly_Mod = -2;
            Stealth_Mod = -4;

            return this;
        }
    }
}

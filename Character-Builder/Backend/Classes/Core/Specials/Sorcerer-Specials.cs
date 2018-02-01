using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Classes.Core.Specials
{
    class Sorcerer_Specials : Special
    {
        public Special Bloodline()
        {
            Name = "Bloodline";
            Description = "Each sorcerer has a source of magic somewhere in her heritage that grants her spells, bonus feats, an additional class skill, and other special abilities. This source can represent a blood relation or an extreme event involving a creature somewhere in the family’s past. For example, a sorcerer might have a dragon as a distant relative or her grandfather might have signed a terrible contract with a devil. Regardless of the source, this influence manifests in a number of ways as the sorcerer gains levels. A sorcerer must pick one bloodline upon taking her first level of sorcerer. Once made, this choice cannot be changed."
                + "\n\n" +
                "At 3rd level, and every two levels thereafter, a sorcerer learns an additional spell, derived from her bloodline. These spells are in addition to the number of spells given on Table: Sorcerer Spells Known. These spells cannot be exchanged for different spells at higher levels."
                + "\n\n" +
                "At 7th level, and every six levels thereafter, a sorcerer receives one bonus feat, chosen from a list specific to each bloodline. The sorcerer must meet the prerequisites for these bonus feats."
                + "\n\n" +
                "Filled with magical power that screams for release, sorcery is not so much a calling as a blessing—or a curse. For some sorcerers, this arcane birthright manifests in subtle and carefully controlled ways, assisting in their manipulation of others or the pursuit of lofty goals. For others, it is wild and unpredictable, the primal and explosive lashing out of a power greater than themselves. Presented below are a number of bloodlines representing the mysterious origin of your sorcerer’s abilities.Filled with magical power that screams for release, sorcery is not so much a calling as a blessing—or a curse. For some sorcerers, this arcane birthright manifests in subtle and carefully controlled ways, assisting in their manipulation of others or the pursuit of lofty goals. For others, it is wild and unpredictable, the primal and explosive lashing out of a power greater than themselves. Presented below are a number of bloodlines representing the mysterious origin of your sorcerer’s abilities.";
            //functionality for choosing
            return this;
        }

        public Special Bloodline_Power() //combined into bloodline?
        {
            Name = "Bloodline Power";
            //get from bloodline
            return this;
        }

        public Special Bloodline_Spell() //combined into bloodline?
        {
            Name = "Bloodline Spell";
            //get from bloodline
            return this;
        }

        public Special Bloodline_Feat()
        {
            Name = "Bloodline Feat";
            //add choice -> get from bloodline
            return this;
        }

        public Special Cantrips() //dunno is needed 
        {
            Name = "Cantrips";
            Description = "Sorcerers learn a number of cantrips, or 0-level spells, as noted on Table: Sorcerer Spells Known under “Spells Known.” These spells are cast like any other spell, but they do not consume any slots and may be used again.";
            return this;
        }

        public Special Eschew_Materials()
        {
            Name = "Eschew Materials";
            Description = "A sorcerer gains Eschew Materials as a bonus feat at 1st level.";
            //add feat
            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Classes.Core.Specials
{
    public class Wizard_Specials : Special
    {
        public List<object> Special_List()
        {
            List<object> list = new List<object>();
            Type type = typeof(Wizard_Specials);

            foreach (var method in type.GetMethods())
            {
                if (method.ReturnType.Equals(typeof(Special)))
                {
                    list.Add(method.Invoke(new Wizard_Specials(), new object[]{ }));
                }
            }

            return list;
        }

        public Special Arcane_Bond()
        {
            Name = "Arcane Bond";
            Description = "At 1st level, wizards form a powerful bond with an object or a creature. This bond can take one of two forms: a familiar or a bonded object. A familiar is a magical pet that enhances the wizard’s skills and senses and can aid him in magic, while a bonded object is an item a wizard can use to cast additional spells or to serve as a magical item. Once a wizard makes this choice, it is permanent and cannot be changed."
                + "\n\n" +
                "Wizards who select a bonded object begin play with one at no cost. Objects that are the subject of an arcane bond must fall into one of the following categories: amulet, ring, staff, wand, or weapon. These objects are always masterwork quality. Weapons acquired at 1st level are not made of any special material. If the object is an amulet or ring, it must be worn to have effect, while staves, wands, and weapons must be held in one hand. If a wizard attempts to cast a spell without his bonded object worn or in hand, he must make a concentration check or lose the spell. The DC for this check is equal to 20 + the spell’s level. If the object is a ring or amulet, it occupies the ring or neck slot accordingly."
                + "\n\n" +
                "A bonded object can be used once per day to cast any one spell that the wizard has in his spellbook and is capable of casting, even if the spell is not prepared. This spell is treated like any other spell cast by the wizard, including casting time, duration, and other effects dependent on the wizard’s level. This spell cannot be modified by metamagic feats or other abilities. The bonded object cannot be used to cast spells from the wizard’s opposition schools (see arcane school below)."
                + "\n\n" +
                "A wizard can add additional magic abilities to his bonded object as if he has the required Item Creation Feats and if he meets the level prerequisites of the feat. For example, a wizard with a bonded dagger must be at least 5th level to add magic abilities to the dagger (see Craft Magic Arms and Armor feat). If the bonded object is a wand, it loses its wand abilities when its last charge is consumed, but it is not destroyed and it retains all of its bonded object properties and can be used to craft a new wand. The magic properties of a bonded object, including any magic abilities added to the object, only function for the wizard who owns it. If a bonded object’s owner dies, or the item is replaced, the object reverts to being an ordinary masterwork item of the appropriate type."
                + "\n\n" +
                "If a bonded object is damaged, it is restored to full hit points the next time the wizard prepares his spells. If the object of an arcane bond is lost or destroyed, it can be replaced after 1 week in a special ritual that costs 200 gp per wizard level plus the cost of the masterwork item. This ritual takes 8 hours to complete. Items replaced in this way do not possess any of the additional enchantments of the previous bonded item. A wizard can designate an existing magic item as his bonded item. This functions in the same way as replacing a lost or destroyed item except that the new magic item retains its abilities while gaining the benefits and drawbacks of becoming a bonded item.";
            //choices
            return this;
        }

        public Special Arcane_School()
        {
            Name = "Arcane School";
            Description = "A wizard can choose to specialize in one school of magic, gaining additional spells and powers based on that school. This choice must be made at 1st level, and once made, it cannot be changed. A wizard that does not select a school receives the universalist school instead."
                + "\n\n" +
                "A wizard that chooses to specialize in one school of magic must select two other schools as his opposition schools, representing knowledge sacrificed in one area of arcane lore to gain mastery in another. A wizard who prepares spells from his opposition schools must use two spell slots of that level to prepare the spell. For example, a wizard with evocation as an opposition school must expend two of his available 3rd-level spell slots to prepare a fireball. In addition, a specialist takes a –4 penalty on any skill checks made when crafting a magic item that has a spell from one of his opposition schools as a prerequisite. A universalist wizard can prepare spells from any school without restriction."
                + "\n\n" +
                "Each arcane school gives the wizard a number of school powers. In addition, specialist wizards receive an additional spell slot of each spell level he can cast, from 1st on up. Each day, a wizard can prepare a spell from his specialty school in that slot. This spell must be in the wizard’s spellbook. A wizard can select a spell modified by a metamagic feat to prepare in his school slot, but it uses up a higher-level spell slot. Wizards with the universalist school do not receive a school slot.";
            //functionality choice + elemental and sin schools
            return this;
        }

        public Special Cantrips() //setup under spells
        {
            Name = "Cantrips";
            Description = "Wizards can prepare a number of cantrips, or 0-level spells, each day, as noted on Table: Wizard under “Spells per Day.” These spells are cast like any other spell, but they are not expended when cast and may be used again. A wizard can prepare a cantrip from an opposition school, but it uses up two of his available slots (see below).";
            return this;
        }

        public Special Scribe_Scroll()
        {
            Name = "Scribe Scroll";
            Description = "At 1st level, a wizard gains Scribe Scroll as a bonus feat.";
            return this;
        }

        public Special Bonus_Feat() //set up functionality and arcane discoveries
        {
            Name = "Bonus Feat";
            Description = "At 5th, 10th, 15th, and 20th level, a wizard gains a bonus feat. At each such opportunity, he can choose a metamagic feat, an item creation, or Spell Mastery. The wizard must still meet all prerequisites for a bonus feat, including caster level minimums. These bonus feats are in addition to the feats that a character of any class gets from advancing levels. The wizard is not limited to the categories of Item Creation Feats, Metamagic Feats, or Spell Mastery when choosing those feats."
                + "\n\n" +
                "A wizard may also choose an Arcane Discovery that he qualifies for in place of a bonus feat at these levels.";
            return this;
        }
    }
}

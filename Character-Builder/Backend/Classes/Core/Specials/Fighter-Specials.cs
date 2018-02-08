using System;
using System.Collections.Generic;
using System.Text;

namespace PF_Character.Classes.Core.Specials
{
    class Fighter_Specials : Special
    {
        public Special Bonus_Feats(Fighter fighter)
        {
            Name = "Bonus Feats"; //maybe remove (s)
            Description = "At 1st level, and at every even level thereafter, a fighter gains a bonus feat in addition to those gained from normal advancement (meaning that the fighter gains a feat at every level). These bonus feats must be selected from those listed as Combat Feats, sometimes also called 'fighter bonus feats.'"
                + "\n\n" +
                "Upon reaching 4th level, and every four levels thereafter (8th, 12th, and so on), a fighter can choose to learn a new bonus feat in place of a bonus feat he has already learned. In effect, the fighter loses the bonus feat in exchange for the new one. The old feat cannot be one that was used as a prerequisite for another feat, prestige class, or other ability. A fighter can only change one feat at any given level and must choose whether or not to swap the feat at the time he gains a new bonus feat for the level.";
            //functionality if(fighter.Level == 1 || fighter.Level % 2)
            return this;
        }

        public Special Bravery(Fighter fighter)
        {
            int bonus = (fighter.Level - 2) / 4 + 1;
            Name = "Bravery +" + bonus;
            Description = "Starting at 2nd level, a fighter gains a +1 bonus on Will saves against fear. This bonus increases by +1 for every four levels beyond 2nd.";
            return this;
        }

        public Special Armor_Training(Fighter fighter)
        {
            int bonus;
            if (fighter.Level >= 15) { bonus = 4; }
            else { bonus = (fighter.Level - 3) / 4 + 1; }
            Name = "Armor Training " + bonus;
            Description = "Starting at 3rd level, a fighter learns to be more maneuverable while wearing armor. Whenever he is wearing armor, he reduces the armor check penalty by 1 (to a minimum of 0) and increases the maximum Dexterity bonus allowed by his armor by 1. Every four levels thereafter (7th, 11th, and 15th), these bonuses increase by +1 each time, to a maximum –4 reduction of the armor check penalty and a +4 increase of the maximum Dexterity bonus allowed."
                + "\n\n" +
                "In addition, a fighter can also move at his normal speed while wearing medium armor. At 7th level, a fighter can move at his normal speed while wearing heavy armor.";
            //functionality
            //Advanced Armor Training
            return this;
        }

        public Special Weapon_Training(Fighter fighter) //+ choice
        {
            Name = "Weapon Training";
            Description = "Starting at 5th level, a fighter can select one group of weapons, as noted below. Whenever he attacks with a weapon from this group, he gains a +1 bonus on attack and damage rolls."
                + "\n\n" +
                "Every four levels thereafter (9th*, 13th, and 17th), a fighter becomes further trained in another group of weapons. He gains a +1 bonus on attack and damage rolls when using a weapon from this group. In addition, the bonuses granted by previous weapon groups increase by +1 each. For example, when a fighter reaches 9th level, he receives a +1 bonus on attack and damage rolls with one weapon group and a +2 bonus on attack and damage rolls with the weapon group selected at 5th level. Bonuses granted from overlapping groups do not stack. Take the highest bonus granted for a weapon if it resides in two or more groups."
                + "\n\n" +
                "A fighter also adds this bonus to any combat maneuver checks made with weapons from his group. This bonus also applies to the fighter’s Combat Maneuver Defense when defending against disarm and sunder attempts made against weapons from this group.";
            //functionality + multiple additions, how to keep track of bonus?
            return this;
        }

        public Special Armor_Mastery(Fighter fighter)
        {
            Name = "Armor Mastery";
            Description = "At 19th level, a fighter gains Damage Reduction 5/— whenever he is wearing armor or using a shield.";
            //functionality
            return this;
        }

        public Special Weapon_Mastery(Fighter fighter)
        {
            Name = "Weapon Mastery";
            Description = "At 20th level, a fighter chooses one weapon, such as the longsword, greataxe, or longbow. Any attacks made with that weapon automatically confirm all critical threats and have their damage multiplier increased by 1 (×2 becomes ×3, for example). In addition, he cannot be disarmed while wielding a weapon of this type.";
            //functionality
            return this;
        }
    }
}

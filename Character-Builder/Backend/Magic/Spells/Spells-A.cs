using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Magic.Spells
{
    class Spells_A : Spell
    {
        public Spell Abeyance()
        {
            Name = "Abeyance";

            School = new Abjuration();
            Level.Add("Cleric", 2);
            Level.Add("Inquisitor", 2);
            Level.Add("Paladin", 2);

            Casting_Time = "1 minute";
            Components.AddRange(new List<string> { "V", "S", "M (a flask of holy water worth 25 gp)", "DF" });

            Range = "touch";
            Target = "creature touched";
            Duration = "24 hours";
            Saving_Throw = "Will negates (harmless)";
            Spell_Resistance = "yes (harmless)";

            Description = "Abeyance suppresses the effects of a single curse on a creature. It does not restore any damage or drain that might have been caused by the curse. Abeyance cannot suppress curses that cannot be removed by remove curse, but it can suppress curses such as lycanthropy that require remove curse along with additional measures. An individual curse can be suppressed only once by abeyance, even if cast by a different caster."
                + "\n\n" +
                "Abeyance does not allow a creature to divest itself of cursed objects, though it can suppress a curse contracted from an object.";

            return this;
        }

        public Spell Abhorrent_Blight()
        {
            Name = "Abhorrent Blight";

            School = new Necromancy();
            Level.Add("Sorcerer/Wizard", 3);

            Casting_Time = "1 standard action";
            Components.AddRange(new List<string> { "V", "S" });

            Range = "close (25 ft. + 5 ft./2 levels)";
            Target = "One living creature";
            Duration = "instantaneous";
            Saving_Throw = "Will partial";
            Spell_Resistance = "yes";

            Description = "With necromantic energies you attack the bond between a living soul and its body which also damages its driving force of will. The target creature suffers 1d6 hit points/level (maximum 10d6) and 1 point/2 levels of Charisma damage (maximum 5). Upon a successful save the target suffers only half the hit point damage and negates the Charisma damage.";

            return this;
        }

        public Spell Ablative_Barrier()
        {
            Name = "Ablative Barrier";

            School = new Conjuration();
            Sub_School = new Conjuration.Creation();
            Descriptors.Add(new Force());
            Level.Add("Alchemist", 2);
            Level.Add("Bloodrager", 2);
            Level.Add("Magus", 2);
            Level.Add("Occultist", 2);
            Level.Add("Psychic", 3);
            Level.Add("Sorcerer/Wizard", 3);
            Level.Add("Summoner", 2);
            Level.Add("Unchained Summoner", 3);

            Casting_Time = "1 standard action";
            Components.AddRange(new List<string> { "V", "S", "M(a piece of metal cut from a shield)" });

            Range = "touch";
            Target = "creature touched";
            Duration = "1 hour/level or until discharged";
            Saving_Throw = "Will negates (harmless)";
            Spell_Resistance = "no";

            Description = "Invisible layers of solid force surround and protect the target, granting that target a +2 armor bonus to AC. Additionally, the first 5 points of lethal damage the target takes from each attack are converted into nonlethal damage. Against attacks that already deal nonlethal damage, the target gains DR 5/—. Once this spell has converted 5 points of damage to nonlethal damage per caster level (maximum 50 points), the spell is discharged.";

            return this;
        }

        //Ablative Sphere
    }
}

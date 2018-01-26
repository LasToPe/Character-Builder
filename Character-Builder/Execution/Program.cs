using System;
using Backend.Classes.Core.Class_Features;
using Backend;
using Backend.Classes.Core;

namespace Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            var list = new ALT_Barbarian_Rage_Powers().Rage_Powers(new Barbarian());

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in character.Character_Classes)
                Console.WriteLine(item);
            Console.WriteLine(character.Favored_Class);
            Console.ReadLine();
        }
    }
}

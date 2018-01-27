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

            character.Character_Classes.RemoveAt(0);
            character.Character_Classes.Add(new Druid(character));

            character.Character_Classes[0].Level = 14;
            character.Character_Classes[0].Update();

            Console.WriteLine("BAB = " + character.BAB);
            foreach(var item in character.Character_Classes[0].Class_Features)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}

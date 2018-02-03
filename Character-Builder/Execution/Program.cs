using System;
using Backend.Classes.Core.Specials;
using Backend;
using Backend.Classes;
using Backend.Classes.Core;
using System.Reflection;
using System.Collections.Generic;

namespace Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            Barbarian barbarian = new Barbarian(character);

            /*character.Character_Classes.RemoveAt(0);
            character.Character_Classes.Add(new Druid(character));

            character.Character_Classes[0].Level = 14;
            character.Character_Classes[0].Update();

            Console.WriteLine("BAB = " + character.BAB);
            foreach(var item in character.Character_Classes[0].Class_Features)
            {
                Console.WriteLine(item.Name);
            }*/

            var test = new Barbarian_Rage_Powers();
            var list = test.Power_List(barbarian);

            foreach(var item in list)
            {
                var temp = (MethodBase)item;
                barbarian.Rage_Powers.Add((Rage_Power)temp.Invoke(new Barbarian_Rage_Powers(), new object[] { barbarian }));
            }

            foreach(var item in barbarian.Rage_Powers)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}

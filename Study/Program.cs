using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            war_worldDB WorldDB = new war_worldDB();
            // Darkest Magus
            creature_template darkestMagus = new creature_template() { Guid = 10145, Name = "Darkest Magus", Level = 12 };
            // Knight of the Sun
            creature_template sunKnight = new creature_template() { Guid = 10125, Name = "LIght Knight", Level = 11 };

            var npcCollection = new List<creature_template>() { darkestMagus, sunKnight };

            foreach (var npc in npcCollection) WorldDB.Creature_Template.Add(npc);
            WorldDB.SaveChanges();

            var npcData = WorldDB.Creature_Template;
            Console.WriteLine("war_world Data:");
            foreach (creature_template item in npcData)
            {
                Console.WriteLine("{0} - {1}", item.Guid, item.Name, item.Level);
            }

            Console.WriteLine("=====");
        }
    }
}
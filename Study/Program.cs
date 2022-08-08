using System.Collections.Generic;

namespace Study
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            war_worldContainer war_WorldDB = new war_worldContainer();

            // DarkArrow ID = 12340
            // SwordSlash ID = 13305
            // AbilityID = /abilityid/ ( set ID from the game )
            // Range = /range/ ( in ft attack distance, for range distance 100, melee distance 10)
            // Target = /target/ ( for enemy 4, self 1, friend 2 )

            creature_abilities darkArrow = new creature_abilities { AbilityID = "12350", RangeCast = "100", TargetCast = "4" };
            creature_abilities swordSlash = new creature_abilities { AbilityID = "13305", RangeCast = "10", TargetCast = "4" };

            // Terrifying Magus = 10035
            // Knight of the Sun = 10128
            // Entry = /entry/ ( NPC entry from the game )
            // Name = /name/ ( NPC name from the game )
            // Level = /level/ ( NPC level from DB )
            creature_template chaosMagus = new creature_template { Entry = "10035", Name = "Terrifying Magus", Level = "12" };
            creature_template sunKnight = new creature_template { Entry = "10128", Name = "Knight of the Sun", Level = "11" };

            List<creature_abilities> creature_abilities = new List<creature_abilities>() { darkArrow, swordSlash };
            foreach (var item in creature_abilities) war_WorldDB.creature_abilitiesSet.Add(item);

            List<creature_template> creature_template = new List<creature_template>() { chaosMagus, sunKnight };
            foreach (var item in creature_template) war_WorldDB.creature_templateSet.Add(item);

            war_WorldDB.SaveChanges();
        }
    }
}
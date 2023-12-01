using System;
using System.Collections.Generic;
using System.Linq;



public class Entity
{
    public string Name { get; set; }
    public EntityType Type { get; set; }
    public List<string> Abilities { get; } = new List<string>();
}

public class Location
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Dictionary<string, Entity> Entities { get; } = new Dictionary<string, Entity>();
    public Dictionary<string, string> Exits { get; } = new Dictionary<string, string>();
}

public class DungeonGame
{
    private static Dictionary<string, Location> currentDungeon;
    private static Location currentLocation;

    public static void StartGame()
    {
        Console.WriteLine("Welcome to the Dungeon Game!");
        currentDungeon = DungeonGenerator.GenerateDungeon();
        currentLocation = currentDungeon["Entrance"];
        Play();
    }

    private static void Play()
    {
        while (true)
        {
            Console.WriteLine($"Current Location: {currentLocation.Name}");
            Console.WriteLine(currentLocation.Description);

            PrintEntitiesInLocation();

            Console.Write("Exits: ");
            foreach (var exit in currentLocation.Exits.Keys)
            {
                Console.Write($"{exit} ");
            }

            Console.WriteLine();
            Console.Write("Choose an exit: ");
            string chosenExit = Console.ReadLine();

            if (currentLocation.Exits.ContainsKey(chosenExit))
            {
                string newLocationName = currentLocation.Exits[chosenExit];
                if (currentDungeon.ContainsKey(newLocationName))
                {
                    currentLocation = currentDungeon[newLocationName];
                }
                else
                {
                    Console.WriteLine("Invalid exit. Please choose a valid exit.");
                }
            }
            else
            {
                Console.WriteLine("Invalid exit. Please choose a valid exit.");
            }
        }
    }

    private static void PrintEntitiesInLocation()
    {
        Console.WriteLine("Entities in this location:");
        foreach (var entity in currentLocation.Entities.Values)
        {
            Console.WriteLine($"{entity.Name} ({entity.Type}) - Abilities: {string.Join(", ", entity.Abilities)}");
        }
    }
}

public class DungeonGenerator
{
    public static Dictionary<string, Location> GenerateDungeon()
    {
        var locations = new Dictionary<string, Location>();

        // Define entities
        Entity spirit = new Entity { Name = "Spirit", Type = EntityType.Spirit, Abilities = { "Invisibility", "Teleportation" } };
        Entity soul = new Entity { Name = "Soul", Type = EntityType.Soul, Abilities = { "Possession", "Ethereal Form" } };
        Entity mind = new Entity { Name = "Mind", Type = EntityType.Mind, Abilities = { "Telekinesis", "Mind Reading" } };
        Entity heart = new Entity { Name = "Heart", Type = EntityType.Heart, Abilities = { "Healing", "Empathy" } };
        Entity body = new Entity { Name = "Body", Type = EntityType.Body, Abilities = { "Strength", "Endurance" } };
        Entity demon = new Entity { Name = "Demon", Type = EntityType.Demon, Abilities = { "Fire Breath", "Flight" } };

        // Define locations
        Location entrance = new Location
        {
            Name = "Entrance",
            Description = "You stand at the entrance of the dungeon.",
            Entities = { { "Spirit", spirit }, { "Soul", soul } },
            Exits = { { "North", "Hallway1" } }
        };

        Location hallway1 = new Location
        {
            Name = "Hallway1",
            Description = "A dimly lit hallway stretches ahead.",
            Entities = { { "Mind", mind }, { "Heart", heart } },
            Exits = { { "North", "Chamber1" }, { "East", "Hallway2" }, { "South", "Entrance" } }
        };

        Location chamber1 = new Location
        {
            Name = "Chamber1",
            Description = "You enter a small chamber.",
            Entities = { { "Body", body } },
            Exits = { { "South", "Hallway1" } }
        };

        Location hallway2 = new Location
        {
            Name = "Hallway2",
            Description = "A cold draft blows through the hallway.",
            Entities = { { "Demon", demon } },
            Exits = { { "West", "Hallway1" }, { "East", "Chamber2" } }
        };

        Location chamber2 = new Location
        {
            Name = "Chamber2",
            Description = "You find yourself in a large chamber.",
            Entities = { { "Soul", soul } },
            Exits = { { "West", "Hallway2" } }
        };

        // Add locations to the dungeon
        locations.Add("Entrance", entrance);
        locations.Add("Hallway1", hallway1);
        locations.Add("Chamber1", chamber1);
        locations.Add("Hallway2", hallway2);
        locations.Add("Chamber2", chamber2);

        return locations;
    }
}

class Program
{
    static void Main()
    {
        DungeonGame.StartGame();
    }
}
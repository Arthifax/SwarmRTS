using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals
{
    public static BuildingData[] BUILDING_DATA = new BuildingData[]
    {
        new BuildingData("House", 100, new Dictionary<string, int>()
        {
            { "sugar", 100 },
            { "wood", 120 }
        }),
        new BuildingData("Tower", 50, new Dictionary<string, int>()
        {
            { "sugar", 100 },
            { "water", 80 },
            { "wood", 80 }
        })
    };
    
    public static Dictionary<string, GameResource> GAME_RESOURCES = new Dictionary<string, GameResource>()
    {
        { "sugar", new GameResource("Sugar", 0) },
        { "water", new GameResource("Water", 0) },
        { "wood", new GameResource("Wood", 0) }
    };

    public static int TERRAIN_LAYER_MASK = 1 << 8;
}

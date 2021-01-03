﻿using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_TemperateSwamp : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < 5f || tile.temperature > 19f || tile.rainfall < 1684)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >=  5f && tile.temperature <=  6f && tile.rainfall >= 1684f ||
                tile.temperature >=  6f && tile.temperature <=  7f && tile.rainfall >= 1800f ||
                tile.temperature >=  7f && tile.temperature <=  8f && tile.rainfall >= 1851f ||
                tile.temperature >=  8f && tile.temperature <=  9f && tile.rainfall >= 1902f ||
                tile.temperature >=  9f && tile.temperature <= 10f && tile.rainfall >= 1952f ||
                tile.temperature >= 10f && tile.temperature <= 11f && tile.rainfall >= 1999f ||
                tile.temperature >= 11f && tile.temperature <= 12f && tile.rainfall >= 2044f ||
                tile.temperature >= 12f && tile.temperature <= 13f && tile.rainfall >= 2086f ||
                tile.temperature >= 13f && tile.temperature <= 14f && tile.rainfall >= 2129f ||
                tile.temperature >= 14f && tile.temperature <= 15f && tile.rainfall >= 2170f ||
                tile.temperature >= 15f && tile.temperature <= 16f && tile.rainfall >= 2208f ||
                tile.temperature >= 16f && tile.temperature <= 17f && tile.rainfall >= 2245f ||
                tile.temperature >= 17f && tile.temperature <= 18f && tile.rainfall >= 2281f ||
                tile.temperature >= 18f && tile.temperature <= 19f && tile.rainfall >= 2317f )
                return tile.temperature + (tile.rainfall / 75f) / (tile.elevation / 100f) + (tile.swampiness * 5);

            return 0f;
        }
    }
}
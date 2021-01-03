using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_MoistDeciduousForest : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < 19f || tile.rainfall < 1579f || tile.rainfall > 2640f)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >= 19f && tile.temperature <= 20f && tile.rainfall >= 1579f && tile.rainfall <= 2317f ||
                tile.temperature >= 20f && tile.temperature <= 21f && tile.rainfall >= 1605f && tile.rainfall <= 2351f ||
                tile.temperature >= 21f && tile.temperature <= 22f && tile.rainfall >= 1628f && tile.rainfall <= 2385f ||
                tile.temperature >= 22f && tile.temperature <= 23f && tile.rainfall >= 1650f && tile.rainfall <= 2417f ||
                tile.temperature >= 23f && tile.temperature <= 24f && tile.rainfall >= 1668f && tile.rainfall <= 2448f ||
                tile.temperature >= 24f && tile.temperature <= 25f && tile.rainfall >= 1685f && tile.rainfall <= 2479f ||
                tile.temperature >= 25f && tile.temperature <= 26f && tile.rainfall >= 1700f && tile.rainfall <= 2509f ||
                tile.temperature >= 26f && tile.temperature <= 27f && tile.rainfall >= 1714f && tile.rainfall <= 2536f ||
                tile.temperature >= 27f && tile.temperature <= 28f && tile.rainfall >= 1726f && tile.rainfall <= 2563f ||
                tile.temperature >= 28f && tile.temperature <= 29f && tile.rainfall >= 1736f && tile.rainfall <= 2590f ||
                tile.temperature >= 29f && tile.temperature <= 30f && tile.rainfall >= 1745f && tile.rainfall <= 2615f ||
                tile.temperature >= 30f                            && tile.rainfall >= 1750f && tile.rainfall <= 2640f )
                return tile.temperature * (tile.elevation / 500f) + (tile.rainfall / 100f) - tile.swampiness;

            return 0f;
        }
    }
}
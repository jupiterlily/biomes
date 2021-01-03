using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_TropicalRainforest : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < 19f || tile.rainfall < 2317f)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >= 19f && tile.temperature <= 20f && tile.rainfall >= 2317f && tile.rainfall <= 3450f ||
                tile.temperature >= 20f && tile.temperature <= 21f && tile.rainfall >= 2351f && tile.rainfall <= 3572f ||
                tile.temperature >= 21f && tile.temperature <= 22f && tile.rainfall >= 2385f && tile.rainfall <= 3705f ||
                tile.temperature >= 22f && tile.temperature <= 23f && tile.rainfall >= 2417f && tile.rainfall <= 3848f ||
                tile.temperature >= 23f && tile.temperature <= 24f && tile.rainfall >= 2448f && tile.rainfall <= 4004f ||
                tile.temperature >= 24f && tile.temperature <= 25f && tile.rainfall >= 2479f && tile.rainfall <= 4215f ||
                tile.temperature >= 25f && tile.temperature <= 26f && tile.rainfall >= 2509f && tile.rainfall <= 4422f ||
                tile.temperature >= 26f && tile.temperature <= 27f && tile.rainfall >= 2536f && tile.rainfall <= 4478f ||
                tile.temperature >= 27f && tile.temperature <= 28f && tile.rainfall >= 2563f && tile.rainfall <= 4404f ||
                tile.temperature >= 28f && tile.temperature <= 29f && tile.rainfall >= 2590f && tile.rainfall <= 4232f ||
                tile.temperature >= 29f && tile.temperature <= 30f && tile.rainfall >= 2615f && tile.rainfall <= 3900f ||
                tile.temperature >= 30f &&                            tile.rainfall >= 2640f && tile.rainfall <= 3500f )
                return tile.temperature + (tile.rainfall / 100f) - (tile.elevation / 100f);
            return 0f;
        }
    }
}
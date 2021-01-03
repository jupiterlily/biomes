using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_Savanna : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < 18f || tile.rainfall < 759f || tile.rainfall > 1315f)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >= 18f && tile.temperature <= 19f && tile.rainfall >= 759f && tile.rainfall <= 1212f ||
                tile.temperature >= 19f && tile.temperature <= 20f && tile.rainfall >= 774f && tile.rainfall <= 1228f ||
                tile.temperature >= 20f && tile.temperature <= 21f && tile.rainfall >= 789f && tile.rainfall <= 1242f ||
                tile.temperature >= 21f && tile.temperature <= 22f && tile.rainfall >= 802f && tile.rainfall <= 1256f ||
                tile.temperature >= 22f && tile.temperature <= 23f && tile.rainfall >= 815f && tile.rainfall <= 1269f ||
                tile.temperature >= 23f && tile.temperature <= 24f && tile.rainfall >= 828f && tile.rainfall <= 1279f ||
                tile.temperature >= 24f && tile.temperature <= 25f && tile.rainfall >= 840f && tile.rainfall <= 1288f ||
                tile.temperature >= 25f && tile.temperature <= 26f && tile.rainfall >= 850f && tile.rainfall <= 1296f ||
                tile.temperature >= 26f && tile.temperature <= 27f && tile.rainfall >= 860f && tile.rainfall <= 1304f ||
                tile.temperature >= 27f && tile.temperature <= 28f && tile.rainfall >= 870f && tile.rainfall <= 1309f ||
                tile.temperature >= 28f && tile.temperature <= 29f && tile.rainfall >= 878f && tile.rainfall <= 1314f ||
                tile.temperature >= 29f                            && tile.rainfall >= 885f && tile.rainfall <= 1315f )
                return 5f * tile.temperature / ((tile.rainfall / 100) + (tile.elevation / 100));

            return 0f;
        }
    }
}
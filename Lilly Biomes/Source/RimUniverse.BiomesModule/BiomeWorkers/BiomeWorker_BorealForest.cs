using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_BorealForest : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -8f || tile.temperature > 5f || tile.rainfall < 389f || tile.rainfall > 1684f)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >= -8f && tile.temperature <= -7f && tile.rainfall >= 451f && tile.rainfall <=  451f ||
                tile.temperature >= -7f && tile.temperature <= -6f && tile.rainfall >= 412f && tile.rainfall <=  750f ||
                tile.temperature >= -6f && tile.temperature <= -5f && tile.rainfall >= 400f && tile.rainfall <=  890f ||
                tile.temperature >= -5f && tile.temperature <= -4f && tile.rainfall >= 382f && tile.rainfall <= 1001f ||
                tile.temperature >= -4f && tile.temperature <= -3f && tile.rainfall >= 389f && tile.rainfall <= 1100f ||
                tile.temperature >= -3f && tile.temperature <= -2f && tile.rainfall >= 402f && tile.rainfall <= 1190f ||
                tile.temperature >= -2f && tile.temperature <= -1f && tile.rainfall >= 427f && tile.rainfall <= 1272f ||
                tile.temperature >= -1f && tile.temperature <=  0f && tile.rainfall >= 460f && tile.rainfall <= 1350f ||
                tile.temperature >=  0f && tile.temperature <=  1f && tile.rainfall >= 505f && tile.rainfall <= 1422f ||
                tile.temperature >=  1f && tile.temperature <=  2f && tile.rainfall >= 566f && tile.rainfall <= 1492f ||
                tile.temperature >=  2f && tile.temperature <=  3f && tile.rainfall >= 643f && tile.rainfall <= 1560f ||
                tile.temperature >=  3f && tile.temperature <=  4f && tile.rainfall >= 731f && tile.rainfall <= 1623f ||
                tile.temperature >=  4f && tile.temperature <=  5f && tile.rainfall >= 836f && tile.rainfall <= 1684f )
                return -tile.temperature + (tile.rainfall / 100f) * (tile.elevation / 300f);

            return 5f + (tile.rainfall / 100f) * (tile.elevation / 500f);
        }
    }
}
using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_ExtremeDesert : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            if (tile.WaterCovered)
                return -100f;
            if (tile.rainfall >= 500f)
                return 0f;

            if (tile.temperature > -2f && tile.temperature <= -1f && tile.rainfall <  50f ||
                tile.temperature > -1f && tile.temperature <=  0f && tile.rainfall <  55f ||
                tile.temperature >  0f && tile.temperature <=  1f && tile.rainfall <  60f ||
                tile.temperature >  1f && tile.temperature <=  2f && tile.rainfall <  65f ||
                tile.temperature >  2f && tile.temperature <=  3f && tile.rainfall <  70f ||
                tile.temperature >  3f && tile.temperature <=  4f && tile.rainfall <  75f ||
                tile.temperature >  4f && tile.temperature <=  5f && tile.rainfall <  80f ||
                tile.temperature >  5f && tile.temperature <=  6f && tile.rainfall <  85f ||
                tile.temperature >  6f && tile.temperature <=  7f && tile.rainfall <  90f ||
                tile.temperature >  7f && tile.temperature <=  8f && tile.rainfall <  95f ||
                tile.temperature >  8f && tile.temperature <=  9f && tile.rainfall < 100f ||
                tile.temperature >  9f && tile.temperature <= 10f && tile.rainfall < 110f ||
                tile.temperature > 10f && tile.temperature <= 11f && tile.rainfall < 120f ||
                tile.temperature > 11f && tile.temperature <= 12f && tile.rainfall < 130f ||
                tile.temperature > 12f && tile.temperature <= 13f && tile.rainfall < 140f ||
                tile.temperature > 13f && tile.temperature <= 14f && tile.rainfall < 150f ||
                tile.temperature > 14f && tile.temperature <= 15f && tile.rainfall < 160f ||
                tile.temperature > 15f && tile.temperature <= 16f && tile.rainfall < 170f ||
                tile.temperature > 16f && tile.temperature <= 17f && tile.rainfall < 180f ||
                tile.temperature > 17f && tile.temperature <= 18f && tile.rainfall < 190f ||
                tile.temperature > 18f && tile.temperature <= 19f && tile.rainfall < 200f ||
                tile.temperature > 19f && tile.temperature <= 20f && tile.rainfall < 220f ||
                tile.temperature > 20f && tile.temperature <= 21f && tile.rainfall < 240f ||
                tile.temperature > 21f && tile.temperature <= 22f && tile.rainfall < 260f ||
                tile.temperature > 22f && tile.temperature <= 23f && tile.rainfall < 280f ||
                tile.temperature > 23f && tile.temperature <= 24f && tile.rainfall < 300f ||
                tile.temperature > 24f && tile.temperature <= 25f && tile.rainfall < 320f ||
                tile.temperature > 25f && tile.temperature <= 26f && tile.rainfall < 340f ||
                tile.temperature > 26f && tile.temperature <= 27f && tile.rainfall < 360f ||
                tile.temperature > 27f && tile.temperature <= 28f && tile.rainfall < 380f ||
                tile.temperature > 28f && tile.temperature <= 29f && tile.rainfall < 400f ||
                tile.temperature > 29f && tile.temperature <= 30f && tile.rainfall < 425f ||
                tile.temperature > 30f && tile.temperature <= 31f && tile.rainfall < 460f ||
                tile.temperature > 31f                            && tile.rainfall < 520f )
            { return tile.temperature * 1.5f - tile.rainfall / 100f; }
            return 0f;
        }
    }
}
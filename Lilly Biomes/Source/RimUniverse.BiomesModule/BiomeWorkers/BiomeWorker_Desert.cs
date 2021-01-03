using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_Desert : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -8f || tile.temperature > 510f)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >= -8f && tile.temperature <= -7f && tile.rainfall <= 296f ||
                tile.temperature >= -7f && tile.temperature <= -6f && tile.rainfall <= 152f ||
                tile.temperature >= -6f && tile.temperature <= -5f && tile.rainfall <= 132f ||
                tile.temperature >= -5f && tile.temperature <= -4f && tile.rainfall <= 129f ||
                tile.temperature >= -4f && tile.temperature <= -3f && tile.rainfall <= 130f ||
                tile.temperature >= -3f && tile.temperature <= -2f && tile.rainfall <= 140f ||
                tile.temperature >= -2f && tile.temperature <= -1f && tile.rainfall <= 151f ||
                tile.temperature >= -1f && tile.temperature <=  0f && tile.rainfall <= 162f ||
                tile.temperature >=  0f && tile.temperature <=  1f && tile.rainfall <= 172f ||
                tile.temperature >=  1f && tile.temperature <=  2f && tile.rainfall <= 182f ||
                tile.temperature >=  2f && tile.temperature <=  3f && tile.rainfall <= 192f ||
                tile.temperature >=  3f && tile.temperature <=  4f && tile.rainfall <= 202f ||
                tile.temperature >=  4f && tile.temperature <=  5f && tile.rainfall <= 212f ||
                tile.temperature >=  5f && tile.temperature <=  6f && tile.rainfall <= 220f ||
                tile.temperature >=  6f && tile.temperature <=  7f && tile.rainfall <= 230f ||
                tile.temperature >=  7f && tile.temperature <=  8f && tile.rainfall <= 240f ||
                tile.temperature >=  8f && tile.temperature <=  9f && tile.rainfall <= 250f ||
                tile.temperature >=  9f && tile.temperature <= 10f && tile.rainfall <= 260f ||
                tile.temperature >= 10f && tile.temperature <= 11f && tile.rainfall <= 270f ||
                tile.temperature >= 11f && tile.temperature <= 12f && tile.rainfall <= 280f ||
                tile.temperature >= 12f && tile.temperature <= 13f && tile.rainfall <= 290f ||
                tile.temperature >= 13f && tile.temperature <= 14f && tile.rainfall <= 301f ||
                tile.temperature >= 14f && tile.temperature <= 15f && tile.rainfall <= 313f ||
                tile.temperature >= 15f && tile.temperature <= 16f && tile.rainfall <= 325f ||
                tile.temperature >= 16f && tile.temperature <= 17f && tile.rainfall <= 338f ||
                tile.temperature >= 17f && tile.temperature <= 18f && tile.rainfall <= 351f ||
                tile.temperature >= 18f && tile.temperature <= 19f && tile.rainfall <= 365f ||
                tile.temperature >= 19f && tile.temperature <= 20f && tile.rainfall <= 378f ||
                tile.temperature >= 20f && tile.temperature <= 21f && tile.rainfall <= 392f ||
                tile.temperature >= 21f && tile.temperature <= 22f && tile.rainfall <= 406f ||
                tile.temperature >= 22f && tile.temperature <= 23f && tile.rainfall <= 419f ||
                tile.temperature >= 23f && tile.temperature <= 24f && tile.rainfall <= 432f ||
                tile.temperature >= 24f && tile.temperature <= 25f && tile.rainfall <= 445f ||
                tile.temperature >= 25f && tile.temperature <= 26f && tile.rainfall <= 459f ||
                tile.temperature >= 26f && tile.temperature <= 27f && tile.rainfall <= 472f ||
                tile.temperature >= 27f && tile.temperature <= 28f && tile.rainfall <= 485f ||
                tile.temperature >= 28f && tile.temperature <= 29f && tile.rainfall <= 498f ||
                tile.temperature >= 29f                            && tile.rainfall <= 510f )
                return 10f + tile.temperature - (tile.rainfall / 100) - (tile.elevation / 100);
            return 0f;
        }
    }
}
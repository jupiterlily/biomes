using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_AridShrubland : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {

            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -8f || tile.rainfall < 129f || tile.rainfall > 885f)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >= -8f && tile.temperature <= -7f && tile.rainfall >= 296f && tile.rainfall < 296f ||
                tile.temperature >= -7f && tile.temperature <= -6f && tile.rainfall >= 152f && tile.rainfall < 278f ||
                tile.temperature >= -6f && tile.temperature <= -5f && tile.rainfall >= 132f && tile.rainfall < 270f ||
                tile.temperature >= -5f && tile.temperature <= -4f && tile.rainfall >= 129f && tile.rainfall < 266f ||
                tile.temperature >= -4f && tile.temperature <= -3f && tile.rainfall >= 130f && tile.rainfall < 271f ||
                tile.temperature >= -3f && tile.temperature <= -2f && tile.rainfall >= 140f && tile.rainfall < 282f ||
                tile.temperature >= -2f && tile.temperature <= -1f && tile.rainfall >= 151f && tile.rainfall < 301f ||
                tile.temperature >= -1f && tile.temperature <=  0f && tile.rainfall >= 162f && tile.rainfall < 323f ||
                tile.temperature >=  0f && tile.temperature <=  1f && tile.rainfall >= 172f && tile.rainfall < 346f ||
                tile.temperature >=  1f && tile.temperature <=  2f && tile.rainfall >= 182f && tile.rainfall < 369f ||
                tile.temperature >=  2f && tile.temperature <=  3f && tile.rainfall >= 192f && tile.rainfall < 392f ||
                tile.temperature >=  3f && tile.temperature <=  4f && tile.rainfall >= 202f && tile.rainfall < 416f ||
                tile.temperature >=  4f && tile.temperature <=  5f && tile.rainfall >= 212f && tile.rainfall < 440f ||
                tile.temperature >=  5f && tile.temperature <=  6f && tile.rainfall >= 220f && tile.rainfall < 465f ||
                tile.temperature >=  6f && tile.temperature <=  7f && tile.rainfall >= 230f && tile.rainfall < 491f ||
                tile.temperature >=  7f && tile.temperature <=  8f && tile.rainfall >= 240f && tile.rainfall < 518f ||
                tile.temperature >=  8f && tile.temperature <=  9f && tile.rainfall >= 250f && tile.rainfall < 543f ||
                tile.temperature >=  9f && tile.temperature <= 10f && tile.rainfall >= 260f && tile.rainfall < 568f ||
                tile.temperature >= 10f && tile.temperature <= 11f && tile.rainfall >= 270f && tile.rainfall < 592f ||
                tile.temperature >= 11f && tile.temperature <= 12f && tile.rainfall >= 280f && tile.rainfall < 617f ||
                tile.temperature >= 12f && tile.temperature <= 13f && tile.rainfall >= 290f && tile.rainfall < 642f ||
                tile.temperature >= 13f && tile.temperature <= 14f && tile.rainfall >= 301f && tile.rainfall < 667f ||
                tile.temperature >= 14f && tile.temperature <= 15f && tile.rainfall >= 313f && tile.rainfall < 690f ||
                tile.temperature >= 15f && tile.temperature <= 16f && tile.rainfall >= 325f && tile.rainfall < 709f ||
                tile.temperature >= 16f && tile.temperature <= 17f && tile.rainfall >= 338f && tile.rainfall < 727f ||
                tile.temperature >= 17f && tile.temperature <= 18f && tile.rainfall >= 351f && tile.rainfall < 743f ||
                tile.temperature >= 18f && tile.temperature <= 19f && tile.rainfall >= 365f && tile.rainfall < 759f ||
                tile.temperature >= 19f && tile.temperature <= 20f && tile.rainfall >= 378f && tile.rainfall < 774f ||
                tile.temperature >= 20f && tile.temperature <= 21f && tile.rainfall >= 392f && tile.rainfall < 789f ||
                tile.temperature >= 21f && tile.temperature <= 22f && tile.rainfall >= 406f && tile.rainfall < 802f ||
                tile.temperature >= 22f && tile.temperature <= 23f && tile.rainfall >= 419f && tile.rainfall < 815f ||
                tile.temperature >= 23f && tile.temperature <= 24f && tile.rainfall >= 432f && tile.rainfall < 828f ||
                tile.temperature >= 24f && tile.temperature <= 25f && tile.rainfall >= 445f && tile.rainfall < 840f ||
                tile.temperature >= 25f && tile.temperature <= 26f && tile.rainfall >= 459f && tile.rainfall < 850f ||
                tile.temperature >= 26f && tile.temperature <= 27f && tile.rainfall >= 472f && tile.rainfall < 860f ||
                tile.temperature >= 27f && tile.temperature <= 28f && tile.rainfall >= 485f && tile.rainfall < 870f ||
                tile.temperature >= 28f && tile.temperature <= 29f && tile.rainfall >= 498f && tile.rainfall < 878f ||
                tile.temperature >= 29f &&                            tile.rainfall >= 510f && tile.rainfall < 885f )
                return ((-tile.temperature * -tile.temperature) / 2f) - (tile.rainfall / 100f) + (tile.elevation / 100f);

            return 1f;
        }
    }
}
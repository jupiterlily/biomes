using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_Grassland : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < -8f || tile.temperature > 18f || tile.rainfall < 266f || tile.rainfall > 1194f)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >= -8f && tile.temperature <= -7f && tile.rainfall >= 296f && tile.rainfall <=  451f ||
                tile.temperature >= -7f && tile.temperature <= -6f && tile.rainfall >= 278f && tile.rainfall <=  412f ||
                tile.temperature >= -6f && tile.temperature <= -5f && tile.rainfall >= 270f && tile.rainfall <=  400f ||
                tile.temperature >= -5f && tile.temperature <= -4f && tile.rainfall >= 266f && tile.rainfall <=  382f ||
                tile.temperature >= -4f && tile.temperature <= -3f && tile.rainfall >= 271f && tile.rainfall <=  389f ||
                tile.temperature >= -3f && tile.temperature <= -2f && tile.rainfall >= 282f && tile.rainfall <=  402f ||
                tile.temperature >= -2f && tile.temperature <= -1f && tile.rainfall >= 301f && tile.rainfall <=  427f ||
                tile.temperature >= -1f && tile.temperature <=  0f && tile.rainfall >= 323f && tile.rainfall <=  460f ||
                tile.temperature >=  0f && tile.temperature <=  1f && tile.rainfall >= 346f && tile.rainfall <=  505f ||
                tile.temperature >=  1f && tile.temperature <=  2f && tile.rainfall >= 369f && tile.rainfall <=  566f ||
                tile.temperature >=  2f && tile.temperature <=  3f && tile.rainfall >= 392f && tile.rainfall <=  643f ||
                tile.temperature >=  3f && tile.temperature <=  4f && tile.rainfall >= 416f && tile.rainfall <=  710f ||
                tile.temperature >=  4f && tile.temperature <=  5f && tile.rainfall >= 440f && tile.rainfall <=  770f ||
                tile.temperature >=  5f && tile.temperature <=  6f && tile.rainfall >= 465f && tile.rainfall <=  822f ||
                tile.temperature >=  6f && tile.temperature <=  7f && tile.rainfall >= 491f && tile.rainfall <=  870f ||
                tile.temperature >=  7f && tile.temperature <=  8f && tile.rainfall >= 518f && tile.rainfall <=  912f ||
                tile.temperature >=  8f && tile.temperature <=  9f && tile.rainfall >= 543f && tile.rainfall <=  951f ||
                tile.temperature >=  9f && tile.temperature <= 10f && tile.rainfall >= 568f && tile.rainfall <=  990f ||
                tile.temperature >= 10f && tile.temperature <= 11f && tile.rainfall >= 592f && tile.rainfall <= 1021f ||
                tile.temperature >= 11f && tile.temperature <= 12f && tile.rainfall >= 617f && tile.rainfall <= 1051f ||
                tile.temperature >= 12f && tile.temperature <= 13f && tile.rainfall >= 642f && tile.rainfall <= 1080f ||
                tile.temperature >= 13f && tile.temperature <= 14f && tile.rainfall >= 667f && tile.rainfall <= 1108f ||
                tile.temperature >= 14f && tile.temperature <= 15f && tile.rainfall >= 690f && tile.rainfall <= 1132f ||
                tile.temperature >= 15f && tile.temperature <= 16f && tile.rainfall >= 709f && tile.rainfall <= 1155f ||
                tile.temperature >= 16f && tile.temperature <= 17f && tile.rainfall >= 727f && tile.rainfall <= 1176f ||
                tile.temperature >= 17f && tile.temperature <= 18f && tile.rainfall >= 743f && tile.rainfall <= 1194f )
                return 5f + tile.temperature + (tile.rainfall / 100);

            return 0f;
        }
    }
}
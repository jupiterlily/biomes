using RimWorld;
using RimWorld.Planet;

namespace RimUniverse.BiomesModule
{
    public class BiomeWorker_Woodland : BiomeWorker
    {
        public override float GetScore(Tile tile, int tileID)
        {
            // ABSOLUTE PARAMETERS
            if (tile.WaterCovered || tile.temperature < 4f || tile.rainfall < 710f || tile.rainfall > 1750f)
                return -100f;

            // CONDITIONAL PARAMETERS
            if (tile.temperature >=  4f && tile.temperature <=  5f && tile.rainfall >=  710f && tile.rainfall <  731f ||
                tile.temperature >=  5f && tile.temperature <=  6f && tile.rainfall >=  770f && tile.rainfall <  836f ||
                tile.temperature >=  6f && tile.temperature <=  7f && tile.rainfall >=  822f && tile.rainfall <  929f ||
                tile.temperature >=  7f && tile.temperature <=  8f && tile.rainfall >=  870f && tile.rainfall < 1001f ||
                tile.temperature >=  8f && tile.temperature <=  9f && tile.rainfall >=  912f && tile.rainfall < 1080f ||
                tile.temperature >=  9f && tile.temperature <= 10f && tile.rainfall >=  951f && tile.rainfall < 1148f ||
                tile.temperature >= 10f && tile.temperature <= 11f && tile.rainfall >=  990f && tile.rainfall < 1209f ||
                tile.temperature >= 11f && tile.temperature <= 12f && tile.rainfall >= 1021f && tile.rainfall < 1265f ||
                tile.temperature >= 12f && tile.temperature <= 13f && tile.rainfall >= 1051f && tile.rainfall < 1318f ||
                tile.temperature >= 13f && tile.temperature <= 14f && tile.rainfall >= 1080f && tile.rainfall < 1365f ||
                tile.temperature >= 14f && tile.temperature <= 15f && tile.rainfall >= 1108f && tile.rainfall < 1408f ||
                tile.temperature >= 15f && tile.temperature <= 16f && tile.rainfall >= 1132f && tile.rainfall < 1449f ||
                tile.temperature >= 16f && tile.temperature <= 17f && tile.rainfall >= 1155f && tile.rainfall < 1486f ||
                tile.temperature >= 17f && tile.temperature <= 18f && tile.rainfall >= 1176f && tile.rainfall < 1520f ||
                tile.temperature >= 18f && tile.temperature <= 19f && tile.rainfall >= 1194f && tile.rainfall < 1550f ||
                tile.temperature >= 19f && tile.temperature <= 20f && tile.rainfall >= 1212f && tile.rainfall < 1579f ||
                tile.temperature >= 20f && tile.temperature <= 21f && tile.rainfall >= 1228f && tile.rainfall < 1605f ||
                tile.temperature >= 21f && tile.temperature <= 22f && tile.rainfall >= 1242f && tile.rainfall < 1628f ||
                tile.temperature >= 22f && tile.temperature <= 23f && tile.rainfall >= 1256f && tile.rainfall < 1650f ||
                tile.temperature >= 23f && tile.temperature <= 24f && tile.rainfall >= 1269f && tile.rainfall < 1668f ||
                tile.temperature >= 24f && tile.temperature <= 25f && tile.rainfall >= 1279f && tile.rainfall < 1685f ||
                tile.temperature >= 25f && tile.temperature <= 26f && tile.rainfall >= 1288f && tile.rainfall < 1700f ||
                tile.temperature >= 26f && tile.temperature <= 27f && tile.rainfall >= 1296f && tile.rainfall < 1714f ||
                tile.temperature >= 27f && tile.temperature <= 28f && tile.rainfall >= 1304f && tile.rainfall < 1726f ||
                tile.temperature >= 28f && tile.temperature <= 29f && tile.rainfall >= 1309f && tile.rainfall < 1736f ||
                tile.temperature >= 29f && tile.temperature <= 30f && tile.rainfall >= 1314f && tile.rainfall < 1745f ||
                tile.temperature >= 30f &&                            tile.rainfall >= 1315f && tile.rainfall < 1750f)
                return tile.temperature + (tile.rainfall / 100f) - tile.swampiness;
            return 0f;
        }
    }
}
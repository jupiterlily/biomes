using HarmonyLib;
using RimWorld;
using Verse;

namespace RimUniverse.BiomesModule
{
    [HarmonyPatch(typeof(GenStep_RockChunks), "Generate")]
    public class GenStep_RockChunks_Generate
    {
        [HarmonyPrefix]
        public static bool Prefix(Map map)
        {
            if(map.Biome == BiomeDefOf.IceSheet)
            { return false; } return true;
        }
    }
}
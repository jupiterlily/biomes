using Multiplayer.API;
using RimUniverse.CoreModule;
using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace RimUniverse.BiomesModule.Submods.WaterFreezes
{
    public class WaterFreezes : MapComponent
    {
        public WaterFreezes(Map map) : base(map) { }
        public int loopCycle;
        public override void MapComponentTick()
        {
            if (Controller.Settings.waterResponsive.Equals(false) || map.Biome == BiomeDefOf.SeaIce)
                return;
            base.MapComponentTick();
            int mapArea;
            if (MP.enabled)
                mapArea = Mathf.RoundToInt(map.Area * 0.000175f);
            else mapArea = Mathf.RoundToInt(map.Area * Rand.Range(0.000065f, 0.000320f));
            for (int i = 0; i < mapArea; i++)
            {
                loopCycle++;
                if (loopCycle >= map.Area)
                    loopCycle = 0;
                IntVec3 terrainCell = map.cellsInRandomOrder.Get(loopCycle);
                GenTemperature.TryGetTemperatureForCell(terrainCell, map, out float terrainTemp);
                float shallowSpeed = terrainTemp < 0f && terrainTemp > -20f ? -terrainTemp * 7f : -terrainTemp * 18f;
                float deepSpeed = terrainTemp < 0f && terrainTemp > -20f ? -terrainTemp / 10f : -terrainTemp / 3f;
                float thawSpeed = terrainTemp < 0f ? -terrainTemp * 10f : terrainTemp * 21f;
                var terrainDef = map.terrainGrid.TerrainAt(terrainCell);

                // freeze process
                if (terrainTemp < -35f)
                {
                    if (terrainDef.defName == "WaterOceanShallow")
                    {
                        int toFreeze = 0;
                        float tempConstant = 0f;
                        List<IntVec3> tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                        tileList.Add(terrainCell);
                        IntVec3 newTile = tileList.RandomElement();
                        if (newTile.InBounds(map))
                        {
                            if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Water") &&
                                map.terrainGrid.TerrainAt(newTile).defName != "Marsh" &&
                                map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                                map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                            {
                                toFreeze++;
                                tempConstant++;
                            }
                            if (terrainDef.defName == "WaterOceanShallow")
                            {
                                if (Rand.Value < shallowSpeed * toFreeze * (tempConstant * 30f))
                                {
                                    string iceName;
                                    if (terrainDef.defName == "WaterOceanShallow") { iceName = "IceOceanShallow"; }
                                    else { continue; }
                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }
                            }
                        }
                    }
                }
                if (terrainTemp < -20f)
                {
                    if (terrainDef.defName == "WaterMovingShallow" || terrainDef.defName == "WaterMovingChestDeep")
                    {
                        int toFreeze = 0;
                        float tempConstant = 0f;
                        List<IntVec3> tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                        tileList.Add(terrainCell);
                        IntVec3 newTile = tileList.RandomElement();
                        if (newTile.InBounds(map))
                        {
                            if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Water") &&
                                map.terrainGrid.TerrainAt(newTile).defName != "Marsh" &&
                                map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                                map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                            {
                                toFreeze++;
                                tempConstant++;
                            }
                            if (terrainDef.defName == "WaterMovingShallow")
                            {
                                if (Rand.Value < shallowSpeed * toFreeze * (tempConstant * 30f))
                                {
                                    string iceName;
                                    if (terrainDef.defName == "WaterMovingShallow") { iceName = "IceMovingShallow"; }
                                    else { continue; }
                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }
                            }
                            if (terrainDef.defName == "WaterMovingChestDeep")
                            {
                                if (Rand.Value < deepSpeed * toFreeze * (tempConstant * 3f))
                                {
                                    string iceName;
                                    if (terrainDef.defName == "WaterMovingChestDeep") { iceName = "IceMovingChestDeep"; }
                                    else { continue; }
                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }
                            }
                        }
                    }
                }
                if (terrainTemp < 0f)
                {
                    if (terrainDef.defName == "WaterShallow" || terrainDef.defName == "Marsh" || terrainDef.defName == "WaterDeep" || terrainDef.defName == "WaterOceanShallow")
                    {
                        int toFreeze = 0;
                        float tempConstant = 0f;
                        List<IntVec3> tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                        tileList.Add(terrainCell);
                        IntVec3 newTile = tileList.RandomElement();
                        if (newTile.InBounds(map))
                        {
                            if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Water") &&
                                map.terrainGrid.TerrainAt(newTile).defName != "Marsh" &&
                                map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                                map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                            {
                                toFreeze++;
                                tempConstant++;
                            }
                            if (terrainDef.defName == "WaterShallow" || terrainDef.defName == "Marsh")
                            {
                                if (Rand.Value < shallowSpeed * toFreeze * (tempConstant * 10f))
                                {
                                    string iceName;
                                    if (terrainDef.defName == "WaterShallow") { iceName = "IceShallow"; }
                                    else { iceName = "IceMarsh"; }
                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }
                            }
                            if (terrainDef.defName == "WaterDeep")
                            {
                                if (Rand.Value < deepSpeed * toFreeze * (tempConstant * 10f))
                                {
                                    string iceName;
                                    if (terrainDef.defName == "WaterDeep") { iceName = "IceDeep"; }
                                    else { continue; }
                                    map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(iceName));
                                }
                            }
                        }
                    }
                }

                // Thaw process
                if (terrainTemp > -19f)
                {
                    if (terrainDef.defName == "IceOceanShallow")
                    {
                        int toThaw = 0;
                        float tempConstant = 0f;
                        List<IntVec3> tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                        tileList.Add(terrainCell);
                        IntVec3 newTile = tileList.RandomElement();
                        if (newTile.InBounds(map))
                        {
                            if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Ice") &&
                                    map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                                    map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                            {
                                toThaw++;
                                tempConstant++;
                            }
                            if (Rand.Value < thawSpeed * toThaw * (tempConstant * 5f))
                            {
                                string waterName;
                                if (terrainDef.defName == "IceOceanShallow") { waterName = "WaterOceanShallow"; }
                                else { continue; }
                                if (waterName.Contains("Water"))
                                {
                                    map.snowGrid.SetDepth(terrainCell, 0f);
                                }
                                map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(waterName));
                            }
                        }
                    }
                }
                if (terrainTemp > -13f)
                {
                    if (terrainDef.defName == "IceMovingShallow" || terrainDef.defName == "IceMovingChestDeep")
                    {
                        int toThaw = 0;
                        float tempConstant = 0f;
                        List<IntVec3> tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                        tileList.Add(terrainCell);
                        IntVec3 newTile = tileList.RandomElement();
                        if (newTile.InBounds(map))
                        {
                            if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Ice") &&
                                    map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                                    map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                            {
                                toThaw++;
                                tempConstant++;
                            }
                            if (Rand.Value < thawSpeed * toThaw * (tempConstant * 5f))
                            {
                                string waterName;
                                if (terrainDef.defName == "IceMovingShallow") { waterName = "WaterMovingShallow"; }
                                else { waterName = "WaterMovingChestDeep"; }

                                if (waterName.Contains("Water"))
                                {
                                    map.snowGrid.SetDepth(terrainCell, 0f);
                                }
                                map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(waterName));
                            }
                        }
                    }
                }
                if (terrainTemp > 0f)
                {
                    if (terrainDef.defName == "IceShallow" || terrainDef.defName == "IceDeep" || terrainDef.defName == "IceMarsh")
                    {
                        int toThaw = 0;
                        List<IntVec3> tileList = GenAdjFast.AdjacentCellsCardinal(terrainCell);
                        tileList.Add(terrainCell);
                        IntVec3 newTile = tileList.RandomElement();
                        if (newTile.InBounds(map))
                        {
                            if (!map.terrainGrid.TerrainAt(newTile).defName.Contains("Ice") &&
                                        map.terrainGrid.TerrainAt(newTile).defName != "BridgeMarsh" &&
                                        map.terrainGrid.TerrainAt(newTile).defName != "Bridge")
                            {
                                toThaw++;
                            }
                            if (Rand.Value < thawSpeed * toThaw)
                            {
                                string waterName;
                                if (terrainDef.defName == "IceShallow") { waterName = "WaterShallow"; }
                                else if (terrainDef.defName == "IceDeep") { waterName = "WaterDeep"; }
                                else { waterName = "Marsh"; }

                                if (waterName.Contains("Water") || waterName == "Marsh")
                                {
                                    map.snowGrid.SetDepth(terrainCell, 0f);
                                }
                                map.terrainGrid.SetTerrain(terrainCell, TerrainDef.Named(waterName));
                            }
                        }
                    }
                }
            }
        }
    }
}
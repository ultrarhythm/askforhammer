using BepInEx;
using HarmonyLib;
using BepInEx.Logging;
using System;
using System.Linq;

namespace wishForHammerTest
{
    internal static class ModInfo
    {
        internal const string Guid = "dingus.AskForHammer.nowaythisconflictsorelseiKILLsomeone";
        internal const string Name = "Custom Hammer";
        internal const string Version = "0.1";
    }

    [BepInPlugin(ModInfo.Guid, ModInfo.Name, ModInfo.Version)]
    internal class newMod : BaseUnityPlugin
    {
        internal static ManualLogSource newLog;
        private void Awake()
        {
            newLog = Logger;
            Logger.LogInfo("TESTING TESTING HAMMER MOD");
            Logger.LogInfo($"PLUGIN LOADED: {ModInfo.Guid}");
            Harmony h = new Harmony(ModInfo.Guid);
            h.PatchAll();

            Logger.LogInfo("TEST\n");
            try
            {
                var mats = EClass.sources.materials.rows;
                Logger.LogInfo(mats.GetType()); // System.Collections.Generic.List`1[SourceMaterial+Row]
                for (int i = 0; i < mats.Count; i++)
                {
                    try
                    {
                        for (int e = 0; e < mats[i].Count; e++)
                        {
                            Logger.LogInfo(mats[i][e])
                        }
                    }
                    catch (Exception e)
                    {
                        Logger.LogInfo(e.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.LogInfo(ex.Message);
            }
        }
    }

    [HarmonyPatch]
    internal class mod
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(TraitGodStatue), nameof(TraitGodStatue._OnUse))]
        internal static void newPatch()
        {
            newMod.newLog.LogInfo("STATUE USED");

            try
            {
                Thing hammer = ThingGen.Create("mathammer", -1, -1);
                hammer.ChangeMaterial("rubinus", false);
                EClass.pc.Pick(hammer, true, true);
            }
            catch (Exception ex)
            {
                newMod.newLog.LogInfo(ex.Message);
            }
        }
    }
}

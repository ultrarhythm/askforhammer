using BepInEx;
using HarmonyLib;
using BepInEx.Logging;

namespace wishForHammerTest
{
    internal static class ModInfo
    {
        internal const string Guid = "unique.id.here";
        internal const string Name = "modName";
        internal const string Version = "modVersionHere";
    }

    [BepInPlugin(ModInfo.Guid, ModInfo.Name, ModInfo.Version)]
    internal class newMod : BaseUnityPlugin
    {
        internal static new ManualLogSource newLog;
        private void Awake()
        {
            newLog.LogInfo($"PLUGIN LOADED: {ModInfo.Guid}");
            //Harmony h = new Harmony(ModInfo.Guid);
            //h.PatchAll();

            newLog.LogInfo("TEST\n");
            var mats = EClass.sources.materials.rows;
            newLog.LogInfo(mats.GetType());
        }
    }

    /*
    [HarmonyPatch]
    internal class mod
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(TraitGodStatue), nameof(TraitGodStatue._OnUse))]
        internal static void newPatch()
        {
            newMod.newLog.LogInfo("STATUE USED");
            Thing hammer = ThingGen.Create("mathammer", -1, -1);
            hammer.ChangeMaterial("", false);
            EClass.pc.Pick(hammer, true, true);
        }
    }
    */
}

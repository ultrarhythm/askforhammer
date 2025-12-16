using BepInEx;
using BepInEx.Logging;
using HarmonyLib;   

namespace AskForHammer
{
    internal static class ModInfo
    {
        internal const string Guid = "dingus.AskForHammer.nowaythisconflictsorelseiKILLsomeone";
        internal const string Name = "Ask For Hammer";
        internal const string Version = "1.0";
    }

    [BepInPlugin(ModInfo.Guid, ModInfo.Name, ModInfo.Version)]
    internal class newMod : BaseUnityPlugin
    {
        internal static ManualLogSource newLog;
        private void Awake()
        {
            newLog = Logger;
            Logger.LogInfo($"PLUGIN LOADED: {ModInfo.Guid}");
            Harmony h = new Harmony(ModInfo.Guid);
            h.PatchAll();
        }
    }

}

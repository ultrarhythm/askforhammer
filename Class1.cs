using BepInEx;
using HarmonyLib;
using BepInEx.Logging;
using System;
using System.Linq;
using System.Collections.Generic;

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

            var itzpaltDrops = new Dictionary<string, (string, string)>
            {
                { "gold", ("gold", "金")},
                { "", ("hide","")},
                { "", ("dragon scale","")},
                { "", ("pearl","")},
                { "", ("straw","")},
                { "", ("cotton","")},
                { "", ("silk","")},
                { "", ("scale","")},
                { "", ("cashmere","")},
                { "", ("zylon","")},
                { "", ("spirit cloth","")},
                { "", ("dawn cloth","")},
                { "", ("griffon scale","")},
                { "", ("wool","")},
                { "", ("spider silk","")},
                { "", ("hemp","")},
                { "", ("oak","")},
                { "", ("grass","")},
                { "", ("sand","")},
                { "", ("jelly","")},
                { "", ("raw food","")},
                { "", ("silver","")},
                { "", ("mica","")},
                { "", ("rubynus","")},
                { "", ("bone","")},
                { "", ("paper","")},
                { "", ("ether","")},
                { "", ("plastic","")},
            };

            var opatosDrops = new Dictionary<string, (string, string)>
            {
                { "gold", ("iron", "金")},
                { "", ("granite","")},
                { "", ("copper","")},
                { "", ("bronze","")},
                { "", ("chromite","")},
                { "", ("diamond","")},
                { "", ("steel","")},
                { "", ("coral","")},
                { "", ("quartz sand","")},
                { "", ("crystal","")},
                { "", ("emerald","")},
                { "", ("adamantite","")},
                { "", ("platinum","")},
                { "", ("obsidian","")},
                { "", ("mithril","")},
                { "", ("titanium","")},
                { "", ("amethyst","")},
                { "", ("rose quartz","")},
                { "", ("oak","")},
                { "", ("grass","")},
                { "", ("sand","")},
                { "", ("jelly","")},
                { "", ("raw food","")},
                { "", ("silver","")},
                { "", ("mica","")},
                { "", ("rubynus","")},
                { "", ("bone","")},
                { "", ("paper","")},
                { "", ("ether","")},
                { "", ("plastic","")},
            };


        }

        internal static bool confirmValid(string material)
        {
            var mat = material.ToLower();
            var valid = EClass.sources.materials.alias.ContainsKey(mat);
            return valid;
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
                var material = "void"; // assume input here
                if (newMod.confirmValid(material))
                {

                    newMod.newLog.LogInfo("VALID MATERIAL");
                    Thing hammer = ThingGen.Create("mathammer", -1 -1);
                    hammer.ChangeMaterial(material, false);
                    EClass.pc.Pick(hammer, true, true);
                }
                else
                {
                    Msg.Say("wishFail");
                }
            }
            catch (Exception ex)
            {
                newMod.newLog.LogInfo(ex.Message);
            }
        }
    }
}

using HarmonyLib;

namespace AskForHammer
{
    [HarmonyPatch]
    internal class mod
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(TraitGodStatue), nameof(TraitGodStatue._OnUse))]
        internal static bool newPatch(TraitGodStatue __instance)
        {
            var religion = __instance.Religion.id;
            __instance.Religion.Talk("shrine", null, null);
            if (religion == "earth" || religion == "element")
            {
                Dialog.InputName("dialogWish", "q", delegate(bool cancel, string text)
                // took an embarassingly long time to figure out this was the method
                // to open the text box
                {
                    if (!cancel)
                    {
                        newMod.newLog.LogInfo($"Checking if material valid: {text}");

                        var valid = drops.isValid(text, religion).Item1;
                        var newMat = drops.isValid(text, religion).Item2;

                        if (valid)
                        {
                            Thing hammer = ThingGen.Create("mathammer", -1, -1);
                            hammer.ChangeMaterial(newMat, false);
                            EClass.pc.Pick(hammer, true, true);
                            return;
                        }
                    }
                    Msg.Say("wishFail");

                }, Dialog.InputType.Default);
                return false;
            }
            return true;
        }
    }
}
using MelonLoader;
using HarmonyLib;
using Il2Cpp;
using UnityEngine;

[assembly: MelonInfo(typeof(SwornRerollMod.Core), "SwornRerollMod", "1.0.0", "Vercility", null)]
[assembly: MelonGame("Windwalk Games", "SWORN")]

namespace SwornRerollMod
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }
    }
}

[HarmonyPatch(typeof(RerollManager), "OnRunStarted")]
class Patch2
{
    static void Prefix(RerollManager __instance)
    {
        __instance.baseRerolls += 5;
    }

}
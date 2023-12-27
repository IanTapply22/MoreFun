using HarmonyLib;
using UnityEngine;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(Landmine))]
    internal class SilentLandmines
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void makeAllLandminesSilent(Landmine __instance)
        {
            __instance.mineAudio.volume = 0f;
            __instance.mineFarAudio.volume = 0f;
        }
    }
}

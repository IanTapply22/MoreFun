using HarmonyLib;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof (SandWormAI))]
    internal class WormGummy
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void makeWormGummy(SandWormAI __instance)
        {
            __instance.creatureSFX.Stop();
        }
    }
}

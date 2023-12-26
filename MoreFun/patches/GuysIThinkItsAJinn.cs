using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(RoundManager))]
    internal class GuysIThinkItsAJinn
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void ahhhhhhhFlashlightsGoFlicky(RoundManager __instance)
        {
            // Make flashlights flicker
            __instance.FlickerLights(true, false);
        }
    }
}

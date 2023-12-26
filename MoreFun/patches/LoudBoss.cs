using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(DepositItemsDesk))]
    internal class LoudBoss
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void makeBossLoud(DepositItemsDesk __instance)
        {
            // wow, my boi is so loud
            __instance.MakeLoudNoise(1);
        }
    }
}

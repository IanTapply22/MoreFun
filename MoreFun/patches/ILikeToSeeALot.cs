using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(Turret))]
    internal class ILikeToSeeALot
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void aroundTheWorld(Turret __instance)
        {
            __instance.rotationRange = 359f;
            }
    }
}

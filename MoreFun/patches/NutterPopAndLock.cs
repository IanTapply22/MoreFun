using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(NutcrackerEnemyAI))]
    internal class NutterPopAndLock
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void turnMugShot(NutcrackerEnemyAI __instance)
        {
            __instance.torsoTurnSpeed = 8f;
        }
    }
}

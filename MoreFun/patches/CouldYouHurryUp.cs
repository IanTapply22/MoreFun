using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(SelectableLevel))]
    internal class CouldYouHurryUp
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void sooooooooooSlowwwwwwwwwww(SelectableLevel __instance)
        {
            // Makes the boss unhappy
            __instance.timeToArrive = 18f;
        }
    }
}

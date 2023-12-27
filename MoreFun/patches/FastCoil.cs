using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(SpringManAI))]
    internal class FastCoil
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void fastAhhhhCoilHead(ref float ___currentChaseSpeed)
        {
            // fast ahhhh coil head
            ___currentChaseSpeed = 30f;
        }
    }
}

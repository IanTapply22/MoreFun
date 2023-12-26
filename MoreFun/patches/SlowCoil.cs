using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(SpringManAI))]
    internal class SlowCoil
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void slowAhhhhCoilHead(ref float ___currentChaseSpeed)
        {
            // slow ahhhh coil head
            ___currentChaseSpeed = 7f;
        }
    }
}

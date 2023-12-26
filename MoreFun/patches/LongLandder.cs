using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(ExtensionLadderItem))]
    internal class LongLadder
    {

        [HarmonyPatch("GetLadderExtensionDistance")]
/*        [HarmonyPostfix]*/
        private static float GetLadderExtensionDistance(ExtensionLadderItem __instance)
        {
            RaycastHit hit;
            int layerMask = 268437761;
            if (Physics.Raycast(__instance.baseNode.transform.position, Vector3.up, out hit, 15f, layerMask, QueryTriggerInteraction.Ignore))
            {
                return hit.distance;
            }
            return 15f;
        }
    }
}

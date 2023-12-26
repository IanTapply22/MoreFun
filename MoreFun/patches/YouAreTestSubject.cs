using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(RagdollGrabbableObject))]
    internal class YouAreTestSubject
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void strangerThingsTestSubject(RagdollGrabbableObject __instance)
        {
            __instance.testBody = true;
        }
    }
}

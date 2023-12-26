using GameNetcodeStuff;
using HarmonyLib;
using System;
using UnityEngine;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class AlwaysDrunkPatch
    {

        // Your original function with modifications
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void alwaysDrunkPatch(ref float ___drunknessInertia, ref bool ___increasingDrunknessThisFrame)
        {
            ___drunknessInertia = 1.3f;
            ___increasingDrunknessThisFrame = false;
        }
    }
}

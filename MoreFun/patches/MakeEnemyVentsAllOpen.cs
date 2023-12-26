using GameNetcodeStuff;
using HarmonyLib;
using System;
using UnityEngine;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(EnemyVent))]
    internal class MakeEnemyVentsAllOpen
    {

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void makeVentsAllOpen(EnemyVent __instance)
        {
            // Opens all vents???????
            __instance.OpenVentClientRpc();
        }
    }
}

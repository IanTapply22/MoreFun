using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(ShipLights))]
    internal class LightsGoBoom
    {
        [HarmonyPatch("ToggleShipLights")]
        [HarmonyPostfix]
        static void lightsGoBoom()
        {
            // Wwow, why tf are you messing with the lights so much, just shut up and actually work. Now you must pay the price.
            if (UnityEngine.Random.Range(0, 30) == 3)
            {
                // kaboom
                var player = GameNetworkManager.Instance.localPlayerController;
                Vector3 bodyVelocity = (player.gameplayCamera.transform.position - player.gameplayCamera.transform.position) * 80f / Vector3.Distance(player.gameplayCamera.transform.position, player.gameplayCamera.transform.position);
                player.KillPlayer(bodyVelocity, true, CauseOfDeath.Blast, 0);
            }
        }
    }
}

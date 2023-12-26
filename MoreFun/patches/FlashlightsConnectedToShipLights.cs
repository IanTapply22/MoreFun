using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MoreFun.patches
{
    [HarmonyPatch(typeof(FlashlightItem))]
    internal class FlashlightsConnectedToShipLights
    {

        [HarmonyPatch("SwitchFlashlight")]
        [HarmonyPostfix]
        static void makeFlashlightsConnectedToShipLights()
        {
            // When anyone uses the flashlight, toggle the ship lights for a 1 in 17 chance
            if (UnityEngine.Random.Range(0, 27) == 14)
            {
                // This will turn off the lights, but like lets hope this doesnt blow them up lol
                UnityEngine.Object.FindObjectOfType<ShipLights>().ToggleShipLightsOnLocalClientOnly();
            }
        }
    }
}

using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFun
{
    internal class Configuration
    {
        public static ConfigEntry<bool> enableExperimentationMode;

        public static ConfigEntry<bool> enableAllEnemyVentsOpen;
        public static ConfigEntry<bool> enableSilentLandmines;
        public static ConfigEntry<bool> enableFlashlightsConnectedToShip;
        public static ConfigEntry<bool> enableLightsGoBoom;
        public static ConfigEntry<bool> enableAlwaysFlickerLights;
        public static ConfigEntry<bool> enableSlowCoilHead;
        public static ConfigEntry<bool> enableNutcrackerFastTurn;
        public static ConfigEntry<bool> enableTestBodyMode;


        public static void Init()
        {
            enableExperimentationMode = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable Experimentation Mode", false, "Enable this to enable all the other options. This is for testing purposes only. ENABLE AT YOUR OWN RISK");

            enableAllEnemyVentsOpen = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable All Enemy Vents Open", true, "Enable this to make all enemy vents open by default but still usable.");
            enableSilentLandmines = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable Silent Landmines", true, "Enable this to make landmines silent.");
            enableFlashlightsConnectedToShip = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable Flashlights Connected To Ship", true, "Enable this to make flashlights connected to the ship lights, this will trigger lights rarely.");
            enableLightsGoBoom = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable Lights Go Boom", true, "Enable this to make lights blow up sometimes, stop messing with the ship lights.");
            enableAlwaysFlickerLights = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable Always Flicker Lights", true, "Enable this to make lights always flicker.");
            enableSlowCoilHead = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable Slow Coil Head", true, "Enable this to make coil heads slow when they sneak up on you.");
            enableNutcrackerFastTurn = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable Nutcracker Fast Turn", true, "Enable this to make nutcrackers turn fast.");

            enableTestBodyMode = MoreFunBase.instance.Config.Bind("Experimentation Mode", "Enable Test Body Mode", false, "Enable this to make ragdolls test bodies.");
        }   
    }
}

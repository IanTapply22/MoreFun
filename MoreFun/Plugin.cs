using MoreFun.patches;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace MoreFun
{
    [BepInPlugin(PluginModInfo.MOD_GUID, PluginModInfo.MOD_NAME, PluginModInfo.MOD_VERSION)]
    public class MoreFunBase : BaseUnityPlugin
    {   
        private readonly Harmony harmony = new Harmony(PluginModInfo.MOD_GUID);
        public static MoreFunBase instance;
        internal ManualLogSource log;

        void Awake()
        {
            if (instance == null) { instance = this; } // Set instance to this instance

            log = Logger; // Set log to BepInEx logger
            log.LogInfo($"{PluginModInfo.MOD_NAME} lethal company mod loading...");
            Configuration.Init(); // Load config file with defaults
            log.LogInfo($"{PluginModInfo.MOD_NAME} configuration loaded. Loading patches...");

            if (Configuration.enableExperimentationMode.Value)
            {
                harmony.PatchAll(typeof(AlwaysDrunkPatch));
                harmony.PatchAll(typeof(LoudBoss));
                harmony.PatchAll(typeof(LongLadder));
            }

            if (Configuration.enableAllEnemyVentsOpen.Value) { harmony.PatchAll(typeof(MakeEnemyVentsAllOpen)); }
            if (Configuration.enableSilentLandmines.Value) { harmony.PatchAll(typeof(SilentLandmines)); }
            if (Configuration.enableFlashlightsConnectedToShip.Value) { harmony.PatchAll(typeof(FlashlightsConnectedToShipLights)); }
            if (Configuration.enableLightsGoBoom.Value) { harmony.PatchAll(typeof(LightsGoBoom)); }
            if (Configuration.enableAlwaysFlickerLights.Value) { harmony.PatchAll(typeof(GuysIThinkItsAJinn)); }
            if (Configuration.enableSlowCoilHead.Value) { harmony.PatchAll(typeof(SlowCoil)); }
            if (Configuration.enableNutcrackerFastTurn.Value) { harmony.PatchAll(typeof(NutterPopAndLock)); }
            if (Configuration.enableTestBodyMode.Value) { harmony.PatchAll(typeof(YouAreTestSubject)); }
            if (Configuration.enableSilentSandWorm.Value) { harmony.PatchAll(typeof(WormGummy)); }
            if (Configuration.enableFastCoil.Value) { harmony.PatchAll(typeof(FastCoil)); }
            if (Configuration.enableFullViewTurrets.Value) { harmony.PatchAll(typeof(ILikeToSeeALot)); }

            log.LogInfo($"{PluginModInfo.MOD_NAME} patches loaded. Happy playing!");
        }
    }

    // TODO: make everything fast, make fog in facility, make config in terminal

    /**
     * Contains all plugin/mod related information
    **/
    class PluginModInfo
    {
        public const string MOD_GUID = "me.iantapply.morefun";
        public const string MOD_NAME = "MoreFun";
        public const string MOD_VERSION = "1.2.0";
    }
}

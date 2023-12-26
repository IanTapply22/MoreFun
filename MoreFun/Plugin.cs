using MoreFun.patches;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace MoreFun
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class MoreFunBase : BaseUnityPlugin
    {
        private const string modGUID = "me.iantapply.morefun";
        private const string modName = "MoreFun";
        private const string modVersion = "1.0.0.0";
        
        private readonly Harmony harmony = new Harmony(modGUID);

        private static MoreFunBase instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("More Fun mod loaded");

            // harmony.PatchAll(typeof(AlwaysDrunkPatch));
            harmony.PatchAll(typeof(MakeEnemyVentsAllOpen));
            harmony.PatchAll(typeof(SilentLandmines));
            harmony.PatchAll(typeof(FlashlightsConnectedToShipLights));
            harmony.PatchAll(typeof(LightsGoBoom));
/*            harmony.PatchAll(typeof(LoudBoss));*/
            harmony.PatchAll(typeof(GuysIThinkItsAJinn));
            harmony.PatchAll(typeof(SlowCoil));
            harmony.PatchAll(typeof(NutterPopAndLock));
            harmony.PatchAll(typeof(YouAreTestSubject));
/*            harmony.PatchAll(typeof(LongLadder));*/

            // TODO: 

        }
    }
}

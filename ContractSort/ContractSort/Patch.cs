using BattleTech;
using BattleTech.Framework;
using BattleTech.UI;
using Harmony;
using System;

namespace ContractSort {

    [HarmonyPatch(typeof(SGContractsWidget), "GetContractComparePriority")]
    public static class SGContractsWidget_GetContractComparePriority_Patch {
        static bool Prefix(SGContractsWidget __instance, ref int __result, Contract contract) {
            try {
                int result = 100;
                SimGameState Sim = (SimGameState)ReflectionHelper.InvokePrivateMethode(__instance, "get_Sim", null);
                if (Sim.ContractUserMeetsReputation(contract)) {
                    if (contract.Override.contractDisplayStyle == ContractDisplayStyle.BaseCampaignRestoration) {
                        result = 0;
                    }
                    else if (contract.Override.contractDisplayStyle == ContractDisplayStyle.BaseCampaignStory) {
                        result = 1;
                    }
                    else if (contract.TargetSystem.Replace("starsystemdef_","").Equals(Sim.CurSystem.Name)) {
                        result = contract.Override.GetUIDifficulty() + 1;
                    }
                    else {
                        result = contract.Override.GetUIDifficulty() + 11;
                    }
                } else {
                    result = contract.Override.GetUIDifficulty() + 21;
                }            
                __result = result;
                return false;
            }
            catch (Exception e) {
                Logger.LogError(e);
                return false;
            }
        }
    }
}
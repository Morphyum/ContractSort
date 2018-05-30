using BattleTech;
using Harmony;
using System;
using System.Collections.Generic;

namespace ContractSort {

    [HarmonyPatch(typeof(Contract), "GenerateSalvage")]
    public static class Contract_GenerateSalvage_Patch {
        static void Prefix(Contract __instance, List<UnitResult> enemyMechs, List<VehicleDef> enemyVehicles, List<UnitResult> lostUnits, bool logResults = false) {
            try {
               
            }
            catch (Exception e) {
                Logger.LogError(e);
                return false;

            }
        }
    }
}
using HarmonyLib;
using System;

namespace DWNO_UnlockAllRequirements
{
  class Patches
  {
    [HarmonyPatch(typeof(PlayerData), "GetEvolutionConditionFlag") ]
    [HarmonyPatch(new Type[] { typeof(uint), typeof(uint) })]
    [HarmonyPrefix]
    static bool GetEvolutionConditionFlag_Prefix(uGenelogyInformationUI __instance, ref bool __result, uint id, uint flagIndex)
    {
      __result = true;
      return false;
    }

  }
}

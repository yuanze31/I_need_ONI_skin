using System;
using HarmonyLib;

namespace I_need_ONI_skin
{
    public static class FU_KLEI
    {
        [HarmonyPatch(typeof(PermitItems))]
        [HarmonyPatch("IsPermitUnlocked")]
        public static class ChangePermitStatus
        {
            public static void Postfix(ref bool __result)
            {
                __result = true;
            }
        }
    }
}

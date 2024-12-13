using System;
using HarmonyLib;

namespace I_need_ONI_skin
{
    public static class Patches
    {
        [HarmonyPatch(typeof(PermitItems))]
        [HarmonyPatch("GetOwnedCount")]
        public static class AA__Patch
        {
            public static void Postfix(ref int __result)
            {
                if (__result == 0)
                {
                    __result++;
                }
            }
        }
    }
}

using System;
using HarmonyLib;

namespace I_need_ONI_skin
{
    public static class Patches
    {
        //[HarmonyPatch(typeof(PermitItems))]
        //[HarmonyPatch("GetOwnedCount")]
        //public static class ChangeOwnedCount
        //{
        //    public static void Postfix(ref int __result)
        //    {
        //        if (__result == 0)
        //        {
        //            __result++;
        //        }
        //    }
        //}

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

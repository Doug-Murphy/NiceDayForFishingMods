using FusionPlay.Enemy;
using FusionPlay.GamePlay.YABS.BattleSystem;
using FusionPlay.Player;
using HarmonyLib;

namespace GuysNight.NiceDayForFishingMod.InstantWin.Patches;

[HarmonyPatch(typeof(FishEnemy))]
public class FishEnemyPatches
{
    [HarmonyPatch("StartBattle")]
    [HarmonyPostfix]
    public static void StartBattlePostfix(FishEnemy __instance, BattleManagerBase battleManager, Player player)
    {
        __instance.TakeDamage(5_000_000, false, false);
    }
}

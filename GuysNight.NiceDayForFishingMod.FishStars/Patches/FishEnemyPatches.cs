using FusionPlay.Enemy;
using FusionPlay.GamePlay.YABS.BattleSystem;
using FusionPlay.Player;
using HarmonyLib;

namespace GuysNight.NiceDayForFishingMod.FishStars.Patches;

[HarmonyPatch(typeof(FishEnemy))]
public class FishEnemyPatches
{
    [HarmonyPatch("StartBattle")]
    [HarmonyPostfix]
    public static void StartBattlePostfix(FishEnemy __instance, BattleManagerBase battleManager, Player player)
    {
        SharedComponents.Logger.LogInfo($"StartBattlePostfix. __instance.EnemyData.EnemyName: {__instance.EnemyData.EnemyName}");
        SharedComponents.Logger.LogInfo($"StartBattlePostfix. __instance.EnemyData.EnemyLevel: {__instance.EnemyData.EnemyLevel}");
    }
    
    [HarmonyPatch("EndBattle")]
    [HarmonyPrefix]
    public static void EndBattlePrefix(FishEnemy __instance)
    {
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyName: {__instance.EnemyData.EnemyName}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.Bait.ItemName: {__instance.EnemyData.Bait.ItemName}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.attacks: {__instance.EnemyData.attacks}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyAgility: {__instance.EnemyData.EnemyAgility}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyDefense: {__instance.EnemyData.EnemyDefense}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyHealth: {__instance.EnemyData.EnemyHealth}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyLevel: {__instance.EnemyData.EnemyLevel}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyMovementSpeed: {__instance.EnemyData.EnemyMovementSpeed}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyPullTime: {__instance.EnemyData.EnemyPullTime}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyRelaxTime: {__instance.EnemyData.EnemyRelaxTime}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyStrength: {__instance.EnemyData.EnemyStrength}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.EnemyTimeBetweenAttacks: {__instance.EnemyData.EnemyTimeBetweenAttacks}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.ExperiencePoints: {__instance.EnemyData.ExperiencePoints}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.FishLength: {__instance.EnemyData.FishLength}");
        SharedComponents.Logger.LogInfo($"EndBattle Prefix. __instance.EnemyData.FishWeight: {__instance.EnemyData.FishWeight}");
        SharedComponents.Logger.LogInfo("-------------------------------");
    }
}

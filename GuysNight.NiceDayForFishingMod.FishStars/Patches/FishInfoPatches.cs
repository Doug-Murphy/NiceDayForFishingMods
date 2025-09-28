using FusionPlay.Characters;
using HarmonyLib;

namespace GuysNight.NiceDayForFishingMod.FishStars.Patches;

[HarmonyPatch(typeof(FishInfo))]
public class FishInfoPatches
{
	[HarmonyPatch("CalculateFishWeight")]
	[HarmonyPrefix]
	public static void CalculateFishWeightPrefix(EnemyData data)
	{
		//This method does not seem to be called in any gameplay I've done.
		//It does not get called when a biome loads, and certainly not when a fish is caught.
		//It may be a leftover from an earlier version of the game.
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyName: {data.EnemyName}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.Bait: {data.Bait}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.attacks: {data.attacks}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyAgility: {data.EnemyAgility}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyDefense: {data.EnemyDefense}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyHealth: {data.EnemyHealth}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyLevel: {data.EnemyLevel}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyMovementSpeed: {data.EnemyMovementSpeed}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyPullTime: {data.EnemyPullTime}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyRelaxTime: {data.EnemyRelaxTime}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyStrength: {data.EnemyStrength}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.EnemyTimeBetweenAttacks: {data.EnemyTimeBetweenAttacks}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.ExperiencePoints: {data.ExperiencePoints}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.FishLength: {data.FishLength}");
		SharedComponents.Logger.LogInfo($"CalculateFishWeight Prefix. EnemyData.FishWeight: {data.FishWeight}");
		SharedComponents.Logger.LogInfo("-------------------------------");
	}
	
	[HarmonyPatch("GetDataValues")]
	[HarmonyPrefix]
	public static void GetDataValuesPrefix(FishInfo __instance)
	{
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyName: {__instance.enemyData.EnemyName}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.Bait.ItemName: {__instance.enemyData.Bait.ItemName}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.attacks: {__instance.enemyData.attacks}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyAgility: {__instance.enemyData.EnemyAgility}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyDefense: {__instance.enemyData.EnemyDefense}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyHealth: {__instance.enemyData.EnemyHealth}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyLevel: {__instance.enemyData.EnemyLevel}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyMovementSpeed: {__instance.enemyData.EnemyMovementSpeed}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyPullTime: {__instance.enemyData.EnemyPullTime}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyRelaxTime: {__instance.enemyData.EnemyRelaxTime}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyStrength: {__instance.enemyData.EnemyStrength}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.EnemyTimeBetweenAttacks: {__instance.enemyData.EnemyTimeBetweenAttacks}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.ExperiencePoints: {__instance.enemyData.ExperiencePoints}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.FishLength: {__instance.enemyData.FishLength}");
		SharedComponents.Logger.LogInfo($"GetDataValuesPrefix Prefix. __instance.enemyData.FishWeight: {__instance.enemyData.FishWeight}");
		SharedComponents.Logger.LogInfo("-------------------------------");
	}
}

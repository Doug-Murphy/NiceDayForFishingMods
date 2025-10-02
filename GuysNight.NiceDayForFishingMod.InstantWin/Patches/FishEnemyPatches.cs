using FusionPlay.Enemy;
using FusionPlay.GamePlay.YABS.BattleSystem;
using FusionPlay.Player;
using HarmonyLib;

namespace GuysNight.NiceDayForFishingMod.InstantWin.Patches;

[HarmonyPatch(typeof(FishEnemy))]
public class FishEnemyPatches {
	[HarmonyPatch("StartBattle")]
	[HarmonyPostfix]
	public static void StartBattlePostfix(FishEnemy __instance, BattleManagerBase battleManager, Player player) {
		SharedComponents.ConfigFile.Reload();

		var isModEnabled = true;

		if (SharedComponents.ConfigFile.TryGetEntry<bool>(Constants.ConfigSectionHeaderToggles, Constants.ConfigKeyEnableMod, out var featureToggleConfigEntry)) {
			isModEnabled = featureToggleConfigEntry.Value;
			SharedComponents.Logger.LogDebug($"Successfully retrieved mod feature toggle. Value is '{isModEnabled}'");
		}
		else {
			SharedComponents.Logger.LogWarning("Could not retrieve mod feature toggle from config. Assuming it was set to true.");
		}

		if (!isModEnabled) {
			return;
		}

		__instance.TakeDamage(5_000_000, false, false);
	}
}
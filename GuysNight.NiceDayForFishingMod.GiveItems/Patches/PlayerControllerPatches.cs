using HarmonyLib;
using UnityEngine.InputSystem;

namespace GuysNight.NiceDayForFishingMod.GiveItems.Patches;

[HarmonyPatch(typeof(PlayerController))]
public class PlayerControllerPatches {
	[HarmonyPatch("Update")]
	[HarmonyPostfix]
	public static void Postfix() {
		var kb = Keyboard.current;
		if (kb == null) {
			return; // Not initialized yet
		}

		if (kb.f1Key.wasPressedThisFrame) {
			SharedComponents.Logger.LogInfo("F1 pressed: executing feature.");
		}
		else {
			SharedComponents.Logger.LogInfo("F1 not pressed");
		}
	}
}

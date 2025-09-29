using HarmonyLib;

namespace GuysNight.NiceDayForFishingMod.FishStars.Patches;

[HarmonyPatch(typeof(FishInfo))]
public class FishInfoPatches
{
    [HarmonyPatch("Start")]
    [HarmonyPostfix]
    public static void StartPostfix(FishInfo __instance)
    {
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
        
        var targetFishRating = 5; //fishRating only changes the LEVEL of the fish as DISPLAYED while battling it. The rating is actually based on the WEIGHT and calculated after catch.
        var targetFishWeight = __instance.fishWeight * 4; //quadrupling the weight should safely get all fish to 5 stars without being too crazy.
        SharedComponents.Logger.LogInfo($"Setting fish {__instance.name} to have fishRating {targetFishRating} and fishWeight {targetFishWeight}");

        __instance.fishRating = targetFishRating; 
        __instance.fishWeight = targetFishWeight;
    }
}

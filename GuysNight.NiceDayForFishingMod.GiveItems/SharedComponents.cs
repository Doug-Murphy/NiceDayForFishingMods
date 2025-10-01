using BepInEx.Configuration;
using BepInEx.Logging;

namespace GuysNight.NiceDayForFishingMod.GiveItems;

internal static class SharedComponents {
	internal static ManualLogSource Logger { get; set; }

	internal static ConfigFile ConfigFile { get; set; }
}


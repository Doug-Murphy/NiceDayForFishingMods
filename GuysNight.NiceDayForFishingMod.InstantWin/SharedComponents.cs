using BepInEx.Configuration;
using BepInEx.Logging;

namespace GuysNight.NiceDayForFishingMod.InstantWin;

internal static class SharedComponents {
	internal static ManualLogSource Logger { get; set; }

	internal static ConfigFile ConfigFile { get; set; }
}
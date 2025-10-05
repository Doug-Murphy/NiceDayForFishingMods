using System;
using System.Collections.Generic;
using BepInEx.Configuration;
using BepInEx.Logging;
using FusionPlay.Inventory;

namespace GuysNight.NiceDayForFishingMod.GiveItems;

internal static class SharedComponents {
	internal static ItemBase GoldItem;
	internal static readonly Dictionary<string, ItemBase> BaitByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> BuildingMaterialsByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> ConsumablesByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> FishByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> FishingRodsByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> HatsByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> HooksByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> HookAddonsByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> LinesByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> NecklacesByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> RingsByName = new(StringComparer.OrdinalIgnoreCase);
	internal static readonly Dictionary<string, ItemBase> SailsByName = new(StringComparer.OrdinalIgnoreCase);
	
	internal static ManualLogSource Logger { get; set; }

	internal static ConfigFile ConfigFile { get; set; }
}

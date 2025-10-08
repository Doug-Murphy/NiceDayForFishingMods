using FusionPlay.Inventory;
using GuysNight.NiceDayForFishingMod.GiveItems.Utilities;
using HarmonyLib;
using UnityEngine.InputSystem;

namespace GuysNight.NiceDayForFishingMod.GiveItems.Patches;

[HarmonyPatch(typeof(PlayerController))]
public class PlayerControllerPatches {
	private static InventoryInfo _inventoryInfo;
	private static Keyboard _kb;

	[HarmonyPatch("Update")]
	[HarmonyPostfix]
	public static void UpdatePostfix(PlayerController __instance) {
		_inventoryInfo ??= __instance.GetComponent<InventoryInfo>();
		_kb ??= Keyboard.current;

		if (_kb == null) {
			return;
		}

		if (_kb.f1Key.wasPressedThisFrame) {
			if (!IsModEnabled()) {
				SharedComponents.Logger.LogDebug("Mod is disabled in config. Not giving items.");
				return;
			}

			SharedComponents.Logger.LogDebug("F1 pressed: Attempting to give bait.");

			if (_inventoryInfo?.ItemEntries == null) {
				SharedComponents.Logger.LogWarning("ItemEntries is null.");
				return;
			}

			CacheItemReferences();

			GivePlayerBait();
		}
		else if (_kb.f2Key.wasPressedThisFrame) {
			if (!IsModEnabled()) {
				SharedComponents.Logger.LogDebug("Mod is disabled in config. Not giving items.");
				return;
			}

			SharedComponents.Logger.LogDebug("F2 pressed: Attempting to give building supplies for Honeywood buildings.");

			if (_inventoryInfo?.ItemEntries == null) {
				SharedComponents.Logger.LogWarning("ItemEntries is null.");
				return;
			}

			CacheItemReferences();

			GivePlayerBuildingMaterials();
		}
		else if (_kb.f3Key.wasPressedThisFrame) {
			if (!IsModEnabled()) {
				SharedComponents.Logger.LogDebug("Mod is disabled in config. Not giving items.");
				return;
			}

			SharedComponents.Logger.LogDebug("F3 pressed: Attempting to give building supplies for portals.");

			if (_inventoryInfo?.ItemEntries == null) {
				SharedComponents.Logger.LogWarning("ItemEntries is null.");
				return;
			}

			CacheItemReferences();

			GivePlayerPortalMaterials();
		}
	}

	/// <summary>
	/// Give the player some bait items.
	/// If an ItemBase reference was not cached (player never had one), it will be skipped.
	/// </summary>
	private static void GivePlayerBait() {
		GiveItemToPlayer(Constants.ItemNames.Bait.ArgonsMushroom, 100);
		GiveItemToPlayer(Constants.ItemNames.Bait.BoBoBerry, 100);
		GiveItemToPlayer(Constants.ItemNames.Bait.Fairy, 100);
		GiveItemToPlayer(Constants.ItemNames.Bait.Garlic, 100);
		GiveItemToPlayer(Constants.ItemNames.Bait.PalmNut, 100);
		GiveItemToPlayer(Constants.ItemNames.Bait.WrigglingWorm, 100);
	}

	/// <summary>
	/// Give the player enough building materials to build/upgrade every Honeywood building (all levels).
	/// If an ItemBase reference was not cached (player never had one), it will be skipped.
	/// </summary>
	private static void GivePlayerBuildingMaterials() {
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.DriftWood, 15);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Ectoplasm, 6);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Fossil, 6);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.IronOre, 7);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Obsidian, 6);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.RawCrystal, 9);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.RuneStone, 14);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.SandDollar, 13);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Seashell, 11);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Slime, 6);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.SoulGem, 6);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Stone, 13);

		// Gold is needed too!
		GiveItemToPlayer(Constants.ItemNames.Gold, 8_670);
	}

	/// <summary>
	/// Give the player the materials required to build all portals (both directions).
	/// If an ItemBase reference was not cached (player never had one), it will be skipped.
	/// </summary>
	private static void GivePlayerPortalMaterials() {
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.DriftWood, 3);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Stone, 2);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Seashell, 2);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Obsidian, 2);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.RuneStone, 3);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.RawCrystal, 2);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.SandDollar, 3);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Fossil, 2);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.Ectoplasm, 2);
		GiveItemToPlayer(Constants.ItemNames.BuildingMaterials.IronOre, 2);
	}

	/// <summary>
	/// Cache item references in dictionaries so that they can be referenced later when giving items to the player.
	/// </summary>
	private static void CacheItemReferences() {
		foreach (var entry in _inventoryInfo.ItemEntries) {
			var item = entry.item;

			if (item == null || string.IsNullOrWhiteSpace(item.name)) {
				continue;
			}

			var itemName = item.name;

			if (itemName == Constants.ItemNames.Gold) {
				SharedComponents.GoldItem = item;
				SharedComponents.Logger.LogDebug($"Cached gold: {itemName}");
			}
			else if (ItemUtility.ItemIsBait(itemName)) {
				if (SharedComponents.BaitByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached bait: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsBuildingMaterial(itemName)) {
				if (SharedComponents.BuildingMaterialsByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached building material: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsConsumable(itemName)) {
				if (SharedComponents.ConsumablesByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached consumable: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsFish(itemName)) {
				if (SharedComponents.FishByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached fish: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsFishingRod(itemName)) {
				if (SharedComponents.FishingRodsByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached fishing rod: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsHat(itemName)) {
				if (SharedComponents.HatsByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached hat: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsHook(itemName)) {
				if (SharedComponents.HooksByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached hook: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsHookAddon(itemName)) {
				if (SharedComponents.HookAddonsByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached hook addon: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsLine(itemName)) {
				if (SharedComponents.LinesByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached line: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsNecklace(itemName)) {
				if (SharedComponents.NecklacesByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached necklace: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsRing(itemName)) {
				if (SharedComponents.RingsByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached ring: {itemName}");
				}
			}
			else if (ItemUtility.ItemIsSail(itemName)) {
				if (SharedComponents.SailsByName.TryAdd(itemName, item)) {
					SharedComponents.Logger.LogDebug($"Cached sail: {itemName}");
				}
			}
			else {
				SharedComponents.Logger.LogWarning($"Item is of unknown type. Unable to cache it. item.name is {item.name}");
				SharedComponents.Logger.LogDebug($"Player has '{_inventoryInfo.GetItemCount(item):N0}' of this item.");
				SharedComponents.Logger.LogDebug($"item.name is '{item.name}' item.ItemName is '{item.ItemName}' item.ItemNameAlias is '{item.ItemNameAlias}' item.ItemDescription is '{item.ItemDescription}' item.ItemMoneyValue is '{item.ItemMoneyValue}'");
			}
		}
	}

	/// <summary>
	/// Check if the mod is enabled or not.
	/// </summary>
	/// <returns>True if the mod is enabled in the config file. Otherwise, false.</returns>
	private static bool IsModEnabled() {
		SharedComponents.ConfigFile.Reload();

		var isModEnabled = true;

		if (SharedComponents.ConfigFile.TryGetEntry<bool>(Constants.ConfigSectionHeaderToggles, Constants.ConfigKeyEnableMod, out var featureToggleConfigEntry)) {
			isModEnabled = featureToggleConfigEntry.Value;
			SharedComponents.Logger.LogDebug($"Successfully retrieved mod feature toggle. Value is '{isModEnabled}'");
		}
		else {
			SharedComponents.Logger.LogWarning("Could not retrieve mod feature toggle from config. Assuming it was set to true.");
		}

		return isModEnabled;
	}

	private static void GiveItemToPlayer(string itemName, int amount) {
		if (SharedComponents.BuildingMaterialsByName.TryGetValue(itemName, out var item)) {
			_inventoryInfo.AddItem(item, amount);
			SharedComponents.Logger.LogDebug($"Gave {amount} of building material '{itemName}'.");
			return;
		}

		if (SharedComponents.BaitByName.TryGetValue(itemName, out item)) {
			_inventoryInfo.AddItem(item, amount);
			SharedComponents.Logger.LogDebug($"Gave {amount} of bait '{itemName}'.");
			return;
		}

		SharedComponents.Logger.LogWarning($"Could not give item '{itemName}' because it was not cached in any supported dictionary.");
	}
}

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
			SharedComponents.Logger.LogDebug("F1 pressed: Attempting to give bait.");

			if (_inventoryInfo?.ItemEntries == null) {
				SharedComponents.Logger.LogWarning("ItemEntries is null.");
				return;
			}

			CacheItemReferences();

			GivePlayerBait();
		}
	}

	/// <summary>
	/// Give the player some bait items.
	/// </summary>
	private static void GivePlayerBait() {
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

		//We can only call AddItem() if we have an ItemBase reference, so we need to look them up from our cached dictionary.
		//I do not see a way to create new ItemBase instances directly since this is using IL2CPP.
		if (SharedComponents.BaitByName.TryGetValue(Constants.ItemNames.Bait.ArgonsMushroom, out var argonsMushroom)) {
			_inventoryInfo.AddItem(argonsMushroom, 100);
		}

		if (SharedComponents.BaitByName.TryGetValue(Constants.ItemNames.Bait.BoBoBerry, out var boboBerry)) {
			_inventoryInfo.AddItem(boboBerry, 100);
		}

		if (SharedComponents.BaitByName.TryGetValue(Constants.ItemNames.Bait.Fairy, out var fairy)) {
			_inventoryInfo.AddItem(fairy, 100);
		}

		if (SharedComponents.BaitByName.TryGetValue(Constants.ItemNames.Bait.Garlic, out var garlic)) {
			_inventoryInfo.AddItem(garlic, 100);
		}

		if (SharedComponents.BaitByName.TryGetValue(Constants.ItemNames.Bait.PalmNut, out var palmNut)) {
			_inventoryInfo.AddItem(palmNut, 100);
		}

		if (SharedComponents.BaitByName.TryGetValue(Constants.ItemNames.Bait.WrigglingWorm, out var wrigglingWorm)) {
			_inventoryInfo.AddItem(wrigglingWorm, 100);
		}
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
}

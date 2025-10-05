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
		_inventoryInfo = __instance.GetComponent<InventoryInfo>();

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

			foreach (var entry in _inventoryInfo.ItemEntries) {
				CacheItem(entry.item);
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
	}

	private static void CacheItem(ItemBase item) {
		if (item == null) {
			return;
		}

		var key = item.name;
		if (string.IsNullOrWhiteSpace(key)) {
			return;
		}

		if (item.name == Constants.ItemNames.Gold) {
			SharedComponents.GoldItem = item;
			SharedComponents.Logger.LogDebug($"Cached gold: {key}");
		}
		else if (ItemUtility.ItemIsBait(item.name)) {
			if (SharedComponents.BaitByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached bait: {key}");
			}
		}
		else if (ItemUtility.ItemIsBuildingMaterial(item.name)) {
			if (SharedComponents.BuildingMaterialsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached building material: {key}");
			}
		}
		else if (ItemUtility.ItemIsConsumable(item.name)) {
			if (SharedComponents.ConsumablesByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached consumable: {key}");
			}
		}
		else if (ItemUtility.ItemIsFish(item.name)) {
			if (SharedComponents.FishByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached fish: {key}");
			}
		}
		else if (ItemUtility.ItemIsFishingRod(item.name)) {
			if (SharedComponents.FishingRodsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached fishing rod: {key}");
			}
		}
		else if (ItemUtility.ItemIsHat(item.name)) {
			if (SharedComponents.HatsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached hat: {key}");
			}
		}
		else if (ItemUtility.ItemIsHook(item.name)) {
			if (SharedComponents.HooksByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached hook: {key}");
			}
		}
		else if (ItemUtility.ItemIsHookAddon(item.name)) {
			if (SharedComponents.HookAddonsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached hook addon: {key}");
			}
		}
		else if (ItemUtility.ItemIsLine(item.name)) {
			if (SharedComponents.LinesByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached line: {key}");
			}
		}
		else if (ItemUtility.ItemIsNecklace(item.name)) {
			if (SharedComponents.NecklacesByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached necklace: {key}");
			}
		}
		else if (ItemUtility.ItemIsRing(item.name)) {
			if (SharedComponents.RingsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached ring: {key}");
			}
		}
		else if (ItemUtility.ItemIsSail(item.name)) {
			if (SharedComponents.SailsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached sail: {key}");
			}
		}
		else {
			SharedComponents.Logger.LogWarning($"Item is of unknown type. Unable to cache it. item.name is {item.name}");
			SharedComponents.Logger.LogDebug($"Player has '{_inventoryInfo.GetItemCount(item):N0}' of this item.");
			SharedComponents.Logger.LogDebug($"item.name is '{item.name}' item.ItemName is '{item.ItemName}' item.ItemNameAlias is '{item.ItemNameAlias}' item.ItemDescription is '{item.ItemDescription}' item.ItemMoneyValue is '{item.ItemMoneyValue}'");
		}
	}
}

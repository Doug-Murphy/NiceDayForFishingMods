using FusionPlay.Inventory;
using HarmonyLib;
using UnityEngine.InputSystem;

namespace GuysNight.NiceDayForFishingMod.GiveItems.Patches;

[HarmonyPatch(typeof(PlayerController))]
public class PlayerControllerPatches {
	private static InventoryInfo _inventoryInfo;

	private static bool _hasInitialized;
	private static Keyboard _kb;

	[HarmonyPatch("Update")]
	[HarmonyPostfix]
	public static void Postfix(PlayerController __instance) {
		_inventoryInfo = __instance.GetComponent<InventoryInfo>();

		_kb ??= Keyboard.current;
		if (_kb == null) {
			return;
		}

		if (_kb.f1Key.wasPressedThisFrame) {
			SharedComponents.Logger.LogDebug("F1 pressed: Giving items.");

			if (_inventoryInfo?.ItemEntries == null) {
				SharedComponents.Logger.LogWarning("ItemEntries is null.");
				return;
			}

			SharedComponents.Logger.LogDebug($"Found {_inventoryInfo.ItemEntries.Count} items in inventory.");

			foreach (var entry in _inventoryInfo.ItemEntries) {
				SharedComponents.Logger.LogDebug($"Player has {_inventoryInfo.GetItemCount(entry.item)} of this item");

				if (Constants.ItemNames.Bait.ItemIsBait(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.BuildingMaterials.ItemIsBuildingMaterial(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.Fish.ItemIsFish(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.FishingRods.ItemIsFishingRod(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.Hats.ItemIsHat(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.Hooks.ItemIsHook(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.HookAddons.ItemIsHookAddon(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.Lines.ItemIsLine(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.Necklaces.ItemIsNecklace(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.Rings.ItemIsRing(entry.item.name)) {
					CacheItem(entry.item);
				}
				else if (Constants.ItemNames.Sails.ItemIsSail(entry.item.name)) {
					CacheItem(entry.item);
				}
				else {
					SharedComponents.Logger.LogDebug($"Item is of unknown type: {entry.item.name}");
				}

				// SharedComponents.Logger.LogDebug($"InternalItemName = {entry.item.name} and ItemName is {entry?.item.ItemName}");
				// SharedComponents.Logger.LogDebug($"item.ItemDescription is {entry.item.ItemDescription}");
				// SharedComponents.Logger.LogDebug($"item.ItemMoneyValue is {entry.item.ItemMoneyValue}");
				// SharedComponents.Logger.LogDebug($"item.ItemName is {entry.item.ItemName}");
				// SharedComponents.Logger.LogDebug($"item.ItemNameAlias is {entry.item.ItemNameAlias}");
				// SharedComponents.Logger.LogDebug("".PadLeft(50, '-'));
			}

			_inventoryInfo.AddItem(SharedComponents.BaitByName[Constants.ItemNames.Bait.ArgonsMushroom], 100);
			_inventoryInfo.AddItem(SharedComponents.BaitByName[Constants.ItemNames.Bait.BoBoBerry], 100);
			_inventoryInfo.AddItem(SharedComponents.BaitByName[Constants.ItemNames.Bait.Fairy], 100);
			_inventoryInfo.AddItem(SharedComponents.BaitByName[Constants.ItemNames.Bait.Garlic], 100);
			_inventoryInfo.AddItem(SharedComponents.BaitByName[Constants.ItemNames.Bait.PalmNut], 100);
			_inventoryInfo.AddItem(SharedComponents.BaitByName[Constants.ItemNames.Bait.WrigglingWorm], 100);
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
		else if (Constants.ItemNames.Bait.ItemIsBait(item.name)) {
			if (SharedComponents.BaitByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached bait: {key}");
			}
		}
		else if (Constants.ItemNames.BuildingMaterials.ItemIsBuildingMaterial(item.name)) {
			if (SharedComponents.BuildingMaterialsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached building material: {key}");
			}
		}
		else if (Constants.ItemNames.Consumables.ItemIsConsumable(item.name)) {
			if (SharedComponents.ConsumablesByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached consumable: {key}");
			}
		}
		else if (Constants.ItemNames.Fish.ItemIsFish(item.name)) {
			if (SharedComponents.FishByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached fish: {key}");
			}
		}
		else if (Constants.ItemNames.FishingRods.ItemIsFishingRod(item.name)) {
			if (SharedComponents.FishingRodsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached fishing rod: {key}");
			}
		}
		else if (Constants.ItemNames.Hats.ItemIsHat(item.name)) {
			if (SharedComponents.HatsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached hat: {key}");
			}
		}
		else if (Constants.ItemNames.Hooks.ItemIsHook(item.name)) {
			if (SharedComponents.HooksByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached hook: {key}");
			}
		}
		else if (Constants.ItemNames.HookAddons.ItemIsHookAddon(item.name)) {
			if (SharedComponents.HookAddonsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached hook addon: {key}");
			}
		}
		else if (Constants.ItemNames.Lines.ItemIsLine(item.name)) {
			if (SharedComponents.LinesByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached line: {key}");
			}
		}
		else if (Constants.ItemNames.Necklaces.ItemIsNecklace(item.name)) {
			if (SharedComponents.NecklacesByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached necklace: {key}");
			}
		}
		else if (Constants.ItemNames.Rings.ItemIsRing(item.name)) {
			if (SharedComponents.RingsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached ring: {key}");
			}
		}
		else if (Constants.ItemNames.Sails.ItemIsSail(item.name)) {
			if (SharedComponents.SailsByName.TryAdd(key, item)) {
				SharedComponents.Logger.LogDebug($"Cached sail: {key}");
			}
		}
		else {
			SharedComponents.Logger.LogDebug($"Item is of unknown type: {item.name}");
			SharedComponents.Logger.LogDebug($"InternalItemName = {item.name} and ItemName is {item.ItemName}");
		}
	}
}

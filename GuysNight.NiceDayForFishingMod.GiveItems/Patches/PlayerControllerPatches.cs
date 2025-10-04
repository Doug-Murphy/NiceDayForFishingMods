using System;
using System.Collections.Generic;
using FusionPlay.Inventory;
using HarmonyLib;
using UnityEngine.InputSystem;

namespace GuysNight.NiceDayForFishingMod.GiveItems.Patches;

[HarmonyPatch(typeof(PlayerController))]
public class PlayerControllerPatches {
	private static InventoryInfo _inventory;
	private static InventoryInfo _inventoryInfo;

	private static Keyboard _kb;
	private static readonly Dictionary<string, ItemBait> BaitByName = new(StringComparer.OrdinalIgnoreCase);

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

			_inventory = __instance.GetComponent<InventoryInfo>();

			if (_inventory?.ItemEntries == null) {
				SharedComponents.Logger.LogWarning("ItemEntries is null.");
				return;
			}

			SharedComponents.Logger.LogDebug($"Found {_inventory.ItemEntries.Count} items in inventory.");

			foreach (var entry in _inventory.ItemEntries) {
				SharedComponents.Logger.LogDebug($"Player has {_inventoryInfo.GetItemCount(entry.item)} of this item");

				switch (entry.item) {
					case ItemFish itemAsFish:
						break;
					case ItemBait itemAsBait:
						SharedComponents.Logger.LogDebug($"item type is {entry?.item.GetType()}");

						CacheBait(itemAsBait);
						break;
					case ItemEquipmentBoots itemAsBoots:
						break;
					case ItemEquipmentFishingRod itemAsFishingRod:
						// Handle fishing rod
						break;
					case ItemEquipmentHat itemAsHat:
						// Handle hat
						break;
					case ItemEquipmentHook itemAsHook:
						// Handle hook
						break;
					case ItemEquipmentHookAddOn itemAsHookAddOn:
						// Handle hook add-on
						break;
					case ItemEquipmentJewelery itemAsJewelry:
						// Handle jewelry
						break;
					case ItemEquipmentNecklace itemAsNecklace:
						// Handle necklace
						break;
					case ItemEquipmentReel itemAsReel:
						// Handle reel
						break;
					case ItemEquipmentSail itemAsSail:
						// Handle sail
						break;
					case ItemEquipmentBase itemAsEquipment:
						break;
					default:
						SharedComponents.Logger.LogDebug($"item is of base type");
						break;
				}

				SharedComponents.Logger.LogDebug($"item.name is {entry?.item.name}");
				SharedComponents.Logger.LogDebug($"item.ItemDescription is {entry?.item.ItemDescription}");
				SharedComponents.Logger.LogDebug($"item.ItemMoneyValue is {entry?.item.ItemMoneyValue}");
				SharedComponents.Logger.LogDebug($"item.ItemName is {entry?.item.ItemName}");
				SharedComponents.Logger.LogDebug($"item.ItemNameAlias is {entry?.item.ItemNameAlias}");
				SharedComponents.Logger.LogDebug("".PadLeft(50, '-'));
			}
		}
	}


	private static void CacheBait(ItemBait bait) {
		if (bait == null) {
			return;
		}

		var key = bait.name;
		if (string.IsNullOrWhiteSpace(key)) {
			return;
		}

		if (!BaitByName.TryAdd(key, bait)) {
			return;
		}

		SharedComponents.Logger.LogDebug($"Cached ItemBait: {key}");
	}
}

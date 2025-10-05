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

				
				if (Constants.ItemNames.Bait.ItemIsBait(entry.item.ItemName)) {
					CacheBait((ItemBait)entry.item);
				}
				else if (Constants.ItemNames.BuildingMaterials.ItemIsBuildingMaterial(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.Fish.ItemIsFish(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.FishingRods.ItemIsFishingRod(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.Hats.ItemIsHat(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.Hooks.ItemIsHook(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.HookAddons.ItemIsHookAddon(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.Lines.ItemIsLine(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.Necklaces.ItemIsNecklace(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.Rings.ItemIsRing(entry.item.ItemName)) {
					
				}
				else if (Constants.ItemNames.Sails.ItemIsSail(entry.item.ItemName)) {
					
				}
				else {
					SharedComponents.Logger.LogDebug($"Item is of unknown type: {entry.item.ItemName}");
				}

				SharedComponents.Logger.LogDebug($"InternalItemName = {entry.item.name} and ItemName is {entry?.item.ItemName}");
				// SharedComponents.Logger.LogDebug($"item.ItemDescription is {entry.item.ItemDescription}");
				// SharedComponents.Logger.LogDebug($"item.ItemMoneyValue is {entry.item.ItemMoneyValue}");
				// SharedComponents.Logger.LogDebug($"item.ItemName is {entry.item.ItemName}");
				// SharedComponents.Logger.LogDebug($"item.ItemNameAlias is {entry.item.ItemNameAlias}");
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

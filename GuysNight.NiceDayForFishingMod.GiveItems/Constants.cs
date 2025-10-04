namespace GuysNight.NiceDayForFishingMod.GiveItems;

internal static class Constants {
	internal const string ConfigSectionHeaderToggles = "Feature Toggles";
	internal const string ConfigKeyEnableMod = "EnableMod";

	internal const string ConfigSectionHeaderKeybinds = "Keybinds";
	internal const string ConfigKeyGiveHoneywoodItems = "Keybind for giving all building materials needed to fully level up Honeywood.";

	internal static class ItemNames {
		internal static class Bait {
			internal const string ArgonsMushroom = "ItemBait03_Mushrooms";
			internal const string BoBoBerry = "ItemBait04_Berry";
			internal const string Fairy = "ItemBait06_Fairy";
			internal const string Garlic = "ItemBait01_Garlic";
			internal const string PalmNut = "ItemBait05_PalmNuts";
			internal const string WrigglingWorm = "ItemBait02_Worm";
		}

		internal static class BuildingMaterials {
			//verified in-game names
			internal const string DriftWood = "ItemBuildingMaterial01";
			internal const string Ectoplasm = "ItemBuildingMaterial08";
			internal const string Fossil = "ItemBuildingMaterial07";
			internal const string IronOre = "ItemBuildingMaterial03";
			internal const string Obsidian = "ItemBuildingMaterial11";
			internal const string RawCrystal = "ItemBuildingMaterial10";
			internal const string RuneStone = "ItemBuildingMaterial09";
			internal const string SandDollar = "ItemBuildingMaterial05";
			internal const string Seashell = "ItemBuildingMaterial06";
			internal const string Slime = "ItemBuildingMaterial04";
			internal const string SoulGem = "ItemBuildingMaterial12";
			internal const string Stone = "ItemBuildingMaterial02";
			
			//to be verified
		}

		internal static class Consumables {
			//verified in-game names
			internal const string CheeseWedge = "ItemConsumable06_StaminaFood";
			internal const string HealthPotion = "ItemConsumable01_HealthPotion";
			internal const string HealthyApple = "ItemConsumable07_HealthFood";
			internal const string PeaceBloom = "ItemConsumable08_ImmuneFood"; 
			internal const string StaminaPotion = "ItemConsumable02_StaminaPotion";
			internal const string StoneSkinPotion = "ItemConsumable04_DefensePotion";
			internal const string StrengthPotion = "ItemConsumable03_StrenghtPotion"; //intentional typo in internal ID
			internal const string TalonMushroom = "ItemConsumable05_EffectRemoveFood";
			
			//to be verified
		}
		
		internal static class FishingRods
		{
			internal const string TrainingRod = "ItemEquipmentFishingRod01_TrainingRod";
			internal const string CommonRod = "ItemEquipmentFishingRod02_CommonRod";
			internal const string ExpertRod = "ItemEquipmentFishingRod03_ExpertRod";
			internal const string ProfiRod = "ItemEquipmentFishingRod04_ProfiRod";
			internal const string BladeRod = "ItemEquipmentFishingRod05_BladeRod";
			internal const string BruteRod = "ItemEquipmentFishingRod06_BruteRod";
			internal const string WizardRod = "ItemEquipmentFishingRod07_WizardRod";
			internal const string PickAxeRod = "ItemEquipmentFishingRod08_PickAxeRod";
			internal const string GoldRod = "ItemEquipmentFishingRod09_GoldRod";
			internal const string HolyRod = "ItemEquipmentFishingRod10_HolyRod";
			internal const string KingsRod = "ItemEquipmentFishingRod11_KingsRod";
			internal const string BaradunsRod = "ItemEquipmentFishingRod12_BaradunsRod";
			internal const string BodgersHammerRod = "ItemEquipmentFishingRod13_BodgersHammerRod";
			internal const string GarlicSwordRod = "ItemEquipmentFishingRod14_GarlicSwordRod";
			internal const string DragonRod = "ItemEquipmentFishingRod15_DragonRod";
			internal const string ThurdotRod = "ItemEquipmentFishingRod16_ThurdothRod";
			internal const string StrongRod = "ItemEquipmentFishingRod17_StrongRod";
			internal const string ShieldRod = "ItemEquipmentFishingRod18_ShieldRod";
			internal const string AncientRod = "ItemEquipmentFishingRod19_AncientRod";
			internal const string DLCRod01 = "ItemEquipmentFishingRod20_DLCRod01"; //Not sure if this is "Legendary Rod" or "Overpriced Cosmetic Item" Rod
			internal const string DLCRod02 = "ItemEquipmentFishingRod21_DLCRod02"; //Not sure if this is "Legendary Rod" or "Overpriced Cosmetic Item" Rod
		}
		
		internal static class Hats
		{
			internal const string BaelinHat = "ItemEquipmentHat00_BaelinHat";
			internal const string Hat01 = "ItemEquipmentHat01";
			internal const string Hat02 = "ItemEquipmentHat02";
			internal const string Hat03 = "ItemEquipmentHat03";
			internal const string Hat04 = "ItemEquipmentHat04";
			internal const string Hat05 = "ItemEquipmentHat05";
			internal const string Hat06 = "ItemEquipmentHat06";
			internal const string Hat07 = "ItemEquipmentHat07";
			internal const string Hat08 = "ItemEquipmentHat08";
			internal const string Hat09 = "ItemEquipmentHat09";
			internal const string Hat10 = "ItemEquipmentHat10";
			internal const string Hat11 = "ItemEquipmentHat11";
			internal const string Hat12 = "ItemEquipmentHat12";
			internal const string Hat13 = "ItemEquipmentHat13";
			internal const string Hat14 = "ItemEquipmentHat14";
			internal const string Hat15 = "ItemEquipmentHat15";
			internal const string DLC1Hat01 = "ItemEquipmentHat16_DLC1Hat01"; //Not sure if this is "Legendary Hat" or "Tinfoil Hat"
			internal const string DLC1Hat02 = "ItemEquipmentHat17_DLC1Hat02"; //Not sure if this is "Legendary Hat" or "Tinfoil Hat"
		}

		internal static class Hooks {
			//verified in-game names
			internal const string DrillHook = "ItemEquipmentHook02_DrillHook";
			internal const string MagnetHook = "ItemEquipmentHook10_MagnetHook";
			internal const string SimpleHook = "ItemEquipmentHook01_SimpleHook";
			
			//to be verified
		}
		
		internal static class Necklaces
		{
			internal const string None = "ItemEquipmentNecklace00_None";
			internal const string MinorDamageSpellNecklace = "ItemEquipmentNecklace01_MinorDamageSpellNecklace";
			internal const string WarriorNecklace = "ItemEquipmentNecklace02_WarriorNecklace";
			internal const string MinorHealNecklace = "ItemEquipmentNecklace03_MinorHealNecklace";
			internal const string ArmorNecklace = "ItemEquipmentNecklace04_ArmorNecklace";
			internal const string PowerNecklace = "ItemEquipmentNecklace05_PowerNecklace";
			internal const string PaladinNecklace = "ItemEquipmentNecklace06_PaladinNecklace";
			internal const string WizardsNecklace = "ItemEquipmentNecklace07_WizardsNecklace";
			internal const string HeroNecklace = "ItemEquipmentNecklace08_HeroNecklace";
			internal const string HighPaladinNecklace = "ItemEquipmentNecklace09_HighPaladinNecklace";
			internal const string HighWizardNecklace = "ItemEquipmentNecklace10_HighWizardNecklace";
			internal const string DamageSpellNecklace = "ItemEquipmentNecklace11_DamageSpellNecklace";
			internal const string BoostNecklace = "ItemEquipmentNecklace12_BoostNecklace";
			internal const string DotNecklace = "ItemEquipmentNecklace13_DotNecklace";
			internal const string BigArmorNecklace = "ItemEquipmentNecklace14_BigArmorNecklace";
			internal const string DLC1Necklace01 = "ItemEquipmentNecklace15_DLC1Necklace01"; //Not sure if this is "Legendary Necklace" or "Company Property Necklace"
			internal const string DLC1Necklace02 = "ItemEquipmentNecklace16_DLC1Necklace02"; //Not sure if this is "Legendary Necklace" or "Company Property Necklace"
		}
		
		internal static class Rings
		{
			internal const string None = "ItemEquipmentJewelry00_None";
			internal const string StrengthRing = "ItemEquipmentJewelry01_StrengthRing";
			internal const string StaminaRing = "ItemEquipmentJewelry02_StaminaRing";
			internal const string StaminaRegRing = "ItemEquipmentJewelry03_StaminaRegRing";
			internal const string BigStaminaRing = "ItemEquipmentJewelry04_BigStaminaRing";
			internal const string HealthRegRing = "ItemEquipmentJewelry05_HealthRegRing";
			internal const string SuperStaminaRing = "ItemEquipmentJewelry06_SuperStaminaRing";
			internal const string SuperStaminaRegRing = "ItemEquipmentJewelry07_SuperStaminaRegRing";
			internal const string SuperHealthRegRing = "ItemEquipmentJewelry08_SuperHealthRegRing";
			internal const string Boss1Ring = "ItemEquipmentJewelry09_Boss1Ring";
			internal const string Boss2Ring = "ItemEquipmentJewelry10_Boss2Ring";
			internal const string Boss3Ring = "ItemEquipmentJewelry11_Boss3Ring";
			internal const string BigStaminaEgRing = "ItemEquipmentJewelry12_BigStaminaEgRing";
			internal const string SmallHealthRegRing = "ItemEquipmentJewelry13_SmallHealthRegRing";
			internal const string TraingRing = "ItemEquipmentJewelry14_TraingRing";
			internal const string DLC1Ring01 = "ItemEquipmentJewelry15_DLC1Ring01"; //Not sure if this is "Legendary Ring" or "Ring of Dormor"
			internal const string DLC1Ring02 = "ItemEquipmentJewelry16_DLC1Ring02"; //Not sure if this is "Legendary Ring" or "Ring of Dormor"
		}
		
		internal static class Sails
		{
			internal const string VLDL = "ItemEquipmentSail01_VLDL";
			internal const string Stripes = "ItemEquipmentSail02_Stripes";
			internal const string Wave = "ItemEquipmentSail03_Wave";
			internal const string Landscape = "ItemEquipmentSail04_Landscape";
			internal const string Angler = "ItemEquipmentSail05_Angler";
			internal const string Shell = "ItemEquipmentSail06_Shell";
			internal const string Pirate = "ItemEquipmentSail07_Pirate";
			internal const string Lava = "ItemEquipmentSail08_Lava";
			internal const string Repaired = "ItemEquipmentSail09_Repaired";
			internal const string Heart = "ItemEquipmentSail10_Heart";
			internal const string Garlic = "ItemEquipmentSail11_Garlic";
			internal const string Sail12 = "ItemEquipmentSail12";
			internal const string Sail13 = "ItemEquipmentSail13";
			internal const string DLC1Sail01 = "ItemEquipmentSail14_DLC1Sail01"; //I think this is another VLDL one?
			internal const string DLC1Sail02 = "ItemEquipmentSail15_DLC1Sail02"; //I think this is the worm one
			internal const string DLC1Sail03 = "ItemEquipmentSail16_DLC1Sail03"; //I think this is Dingo
			internal const string DLC1Sail04 = "ItemEquipmentSail17_DLC1Sail04"; //I think this is the rainbow mushroom one.
		}
	}
	
	
	/*
	 * Item Costs:
	 * Undead Mines to Honeywood Portal -> 2 stone, 2 seashell, 1 obsidian
	 * Honeywood to Undead Mines Portla -> 3 Rune stone, 2 raw crystal, 1 obsidian
	 * Honeywood to Azerim Coast -> 3 drift wood, 2 iron ore, 1 ectoplasm
	 * Azerim Coast to Honeywood -> 3 sand dollar, 2 fossil, 1 ectoplasm
	 *
	 * Gregs Item Shop:
	 * Level 1 -> 50 gold, 1 drift wood, 1 stone, 1 sand dollar
	 * Level 2 -> 200 gold, 1 drift wood, 1 stone, 1 iron ore, 2 fossil
	 * Level 3 -> 1,500 gold, 2 stone, 1 slime, 2 seashell, 1 ectoplasm, 2 raw crystal, 1 obsidian, 1 soul gem

	 * Bodgers Smithy:
	 * Level 1 -> 50 gold, 1 drift wood, 1 sand dollar, 1 seashell
	 * Level 2 -> 350 gold, 1 drift wood, 1 iron ore, 1 sand dollar, 2 raw crystal
	 * Level 3 -> 2,000 gold, 2 drift wood, 1 slime, 2 sand dollar, 1 ectoplasm, 2 rune stone, 1 obisidian, 1 soul gem
	 *
	 * Freds Friendly Fish Forum
	 * Level 1 -> 50 gold, 1 drift wood, 1 stone, 1 seashell
	 * Level 2 -> 100 gold, 1 iron ore, 2 sand dollar, 1 seashell, 1 rune stone
	 * Level 3 -> 200 gold, 1 slime, 2 sand dollar, 2 seashell, 1 ectoplasm, 2 raw crystal, 1 obsidian, 1 soul gem
	 *
	 * Willow's Royal Home
	 * Level 1 -> 50 gold, 3 drift wood, 3 stone
	 * Level 2 -> 250 gold, 1 iron ore, 1 sand dollar, 1 fossil, 2 rune stone
	 * Level 3 -> 1,200 gold, 3 driftwood, 1 stone, 1 slime, 1 ectoplasm, 2 rune stone, 1 obsidian, 1 soul gem
	 *
	 * Eugene's Hat Emporium
	 * Level 1 -> 50 gold, 1 stone, 1 sand dollar, 1 seashell
	 * Level 2 -> 300 gold, 1 drift wood, 1 seashell, 1 fossil, 2 raw crystal
	 * Level 3 -> 1,700 gold, 1 iron ore, 1 slime, 2 seashell, 1 ectoplasm, 3 rune stone, 1 obsidian, 1 soul gem
	 *
	 * Mayor's Manor
	 * Level 1 -> 20 gold, 1 driftwood, 1 stone, 1 iron ore, 1 rune stone
	 * Level 2 -> 100 gold, 1 iron ore, 1 fossil, 1 rune stone, 1 raw crystal, 1 obsidian
	 * Level 3 -> 500 gold, 2 stone, 1 slime, 2 sand dollar, 1 fossil, 1 ectoplasm, 2 rune stone, 1 soul gem
	 */
}

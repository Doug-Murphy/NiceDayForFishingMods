namespace GuysNight.NiceDayForFishingMod.GiveItems;

internal static class Constants {
	internal const string ConfigSectionHeaderToggles = "Feature Toggles";
	internal const string ConfigKeyEnableMod = "EnableMod";

	internal const string ConfigSectionHeaderKeybinds = "Keybinds";
	internal const string ConfigKeyGiveHoneywoodItems = "Keybind for giving all building materials needed to fully level up Honeywood.";

	internal static class ItemNames {
		internal const string Gold = "ItemMoney";

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

		internal static class FishingRods {
			//verified in-game names
			internal const string AdvancedRod = "ItemEquipmentFishingRod03_ExpertRod";
			internal const string AncientRod = "ItemEquipmentFishingRod19_AncientRod";
			internal const string BlackSmack = "ItemEquipmentFishingRod06_BruteRod";
			internal const string BonecallersRod = "ItemEquipmentFishingRod16_ThurdothRod";
			internal const string Crossrod = "ItemEquipmentFishingRod10_HolyRod";
			internal const string EssentialRod = "ItemEquipmentFishingRod02_CommonRod";
			internal const string GoldenRod = "ItemEquipmentFishingRod09_GoldRod";
			internal const string HackNSplash = "ItemEquipmentFishingRod17_StrongRod";
			internal const string KelpDigger = "ItemEquipmentFishingRod08_PickAxeRod";
			internal const string KingfishSlayer = "ItemEquipmentFishingRod11_KingsRod";
			internal const string NPCRod = "ItemEquipmentFishingRod01_TrainingRod";
			internal const string ProRod = "ItemEquipmentFishingRod04_ProfiRod";
			internal const string SashimiMaster1000 = "ItemEquipmentFishingRod05_BladeRod";
			internal const string SeaStaff = "ItemEquipmentFishingRod07_WizardRod";
			internal const string TheBuckler = "ItemEquipmentFishingRod18_ShieldRod";
			internal const string TheHeirloom = "ItemEquipmentFishingRod13_BodgersHammerRod";
			internal const string YorTolShum = "ItemEquipmentFishingRod15_DragonRod";
			
			//to be verified
			internal const string BaradunsRod = "ItemEquipmentFishingRod12_BaradunsRod";
			internal const string GarlicSwordRod = "ItemEquipmentFishingRod14_GarlicSwordRod";
			internal const string DLCRod01 = "ItemEquipmentFishingRod20_DLCRod01"; //Not sure if this is "Legendary Rod" or "Overpriced Cosmetic Item" Rod
			internal const string DLCRod02 = "ItemEquipmentFishingRod21_DLCRod02"; //Not sure if this is "Legendary Rod" or "Overpriced Cosmetic Item" Rod
		}

		internal static class Hats {
			//verified in-game names
			internal const string BaelinsHat = "ItemEquipmentHat00_BaelinHat";
			internal const string BlackFishingHat = "ItemEquipmentHat14";
			internal const string BodgersBowler = "ItemEquipmentHat01";
			internal const string CapOfTheWoods = "ItemEquipmentHat06";
			internal const string DragonhornHelmet = "ItemEquipmentHat11";
			internal const string GnomeHat = "ItemEquipmentHat15";
			internal const string GrandmasBonnet = "ItemEquipmentHat03";
			internal const string GuardHelmet = "ItemEquipmentHat05";
			internal const string HolyHayHat = "ItemEquipmentHat12";
			internal const string LegendaryHat = "ItemEquipmentHat16_DLC1Hat01";
			internal const string MiningHelmet = "ItemEquipmentHat08";
			internal const string OldPirateHat = "ItemEquipmentHat09";
			internal const string SketchySquareTop = "ItemEquipmentHat07";
			internal const string TinfoilHat = "ItemEquipmentHat17_DLC1Hat02";
			internal const string WoodenBucket = "ItemEquipmentHat02";

			//to be verified - maybe these don't exist?
			internal const string Hat04 = "ItemEquipmentHat04";
			internal const string Hat10 = "ItemEquipmentHat10";
			internal const string Hat13 = "ItemEquipmentHat13";
		}

		internal static class Hooks {
			//verified in-game names
			internal const string DrillHook = "ItemEquipmentHook02_DrillHook";
			internal const string MagnetHook = "ItemEquipmentHook10_MagnetHook";
			internal const string SimpleHook = "ItemEquipmentHook01_SimpleHook";

			//to be verified
		}

		internal static class HookAddons {
			//verified in-game names
			internal const string AnglingBud2000 = "HookAddonWeakFin";
			internal const string FishingPal5000 = "HookAddonFin";
			internal const string GlimmerGarlic = "HookAddonHolyLight";
			internal const string HolyGarlic = "HookAddonSuperHolyLight";
			internal const string WeakLight = "HookAddonSimpleLight";
			internal const string WiggleFin = "HookAddonWiggleFin";

			//to be verified
		}

		internal static class Lines {
			//verified in-game names
			internal const string AdventurerLine = "ItemEquipmentReel03_SilverReel";
			internal const string DiamondLine3000 = "ItemEquipmentReel06_DiamondReel";
			internal const string HoneywoodLine = "ItemEquipmentReel02_BronzeReel";
			internal const string ObsidianLine = "ItemEquipmentReel05_ObsidianReel";
			internal const string RopeLine = "ItemEquipmentReel04_GoldReel";

			//to be verified
		}

		internal static class Necklaces {
			//verified in-game names
			internal const string AmuletOfArno = "ItemEquipmentNecklace02_WarriorNecklace";
			internal const string BaradunsSpareAmulet = "ItemEquipmentNecklace07_WizardsNecklace";
			internal const string ClericCollar = "ItemEquipmentNecklace03_MinorHealNecklace";
			internal const string CompanyProperty = "ItemEquipmentNecklace16_DLC1Necklace02";
			internal const string GildedAmuletOfRestitution = "ItemEquipmentNecklace09_HighPaladinNecklace";
			internal const string IconicNecklace = "ItemEquipmentNecklace08_HeroNecklace";
			internal const string KalaborsEnchantment = "ItemEquipmentNecklace10_HighWizardNecklace";
			internal const string LegendaryNecklace = "ItemEquipmentNecklace15_DLC1Necklace01";
			internal const string LilShield = "ItemEquipmentNecklace04_ArmorNecklace";
			internal const string MuscleCharm = "ItemEquipmentNecklace05_PowerNecklace";
			internal const string NeckbandOfChanneling = "ItemEquipmentNecklace01_MinorDamageSpellNecklace";
			internal const string PaladinsInsignia = "ItemEquipmentNecklace06_PaladinNecklace";
			internal const string SylwynPendant = "ItemEquipmentNecklace13_DotNecklace";
			internal const string TankOfCorrosion = "ItemEquipmentNecklace14_BigArmorNecklace";

			//to be verified - I think these actually don't exist in the game.
			internal const string None = "ItemEquipmentNecklace00_None";
			internal const string DamageSpellNecklace = "ItemEquipmentNecklace11_DamageSpellNecklace";
			internal const string BoostNecklace = "ItemEquipmentNecklace12_BoostNecklace";
		}

		internal static class Rings {
			//verified in-game names
			internal const string DuelRing = "ItemEquipmentJewelery14_TraingRing";
			internal const string LegendaryRing = "ItemEquipmentJewelery15_DLC1Ring01";
			internal const string MagicalMoodRing = "ItemEquipmentJewelery13_SmallHealthRegRing";
			internal const string RefreshingRing = "ItemEquipmentJewelery12_BigStaminaEgRing";
			internal const string RingOfBiggerEndurance = "ItemEquipmentJewelery04_BigStaminaRing";
			internal const string RingOfDormor = "ItemEquipmentJewelery16_DLC1Ring02";
			internal const string RingOfEndurance = "ItemEquipmentJewelery02_StaminaRing";
			internal const string RingOfFastRestoration = "ItemEquipmentJewelery07_SuperStaminaRegRing";
			internal const string RingOfGreatRecovery = "ItemEquipmentJewelery08_SuperHealthRegRing";
			internal const string RingOfRecovery = "ItemEquipmentJewelery05_HealthRegRing";
			internal const string RingOfRestoration = "ItemEquipmentJewelery03_StaminaRegRing";
			internal const string SpectralRing = "ItemEquipmentJewelery11_Boss3Ring";

			//to be verified - maybe these don't actually exist in the game?
			internal const string None = "ItemEquipmentJewelery00_None";
			internal const string StrengthRing = "ItemEquipmentJewelery01_StrengthRing";
			internal const string SuperStaminaRing = "ItemEquipmentJewelery06_SuperStaminaRing";
			internal const string Boss1Ring = "ItemEquipmentJewelery09_Boss1Ring";
			internal const string Boss2Ring = "ItemEquipmentJewelery10_Boss2Ring";
		}

		internal static class Sails {
			//verified in-game names
			internal const string BasicSail = "ItemEquipmentSail01_VLDL";
			internal const string IconicSail = "ItemEquipmentSail14_DLC1Sail01";
			internal const string ThatShitsDingoSail = "ItemEquipmentSail16_DLC1Sail03";
			internal const string WormsSail = "ItemEquipmentSail15_DLC1Sail02";

			//to be verified
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
			internal const string DLC1Sail04 = "ItemEquipmentSail17_DLC1Sail04"; //I think this is MCU sail
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

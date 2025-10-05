namespace GuysNight.NiceDayForFishingMod.GiveItems.Utilities;

public static class ItemUtility {
	//This is annoying and dumb, but downcasting from ItemBase to the specific item type doesn't work.
	//I've even done pattern matching with `is` and `as`. Of course explicit casting won't work either.
	public static bool ItemIsBait(string itemName) {
		return itemName is
			Constants.ItemNames.Bait.ArgonsMushroom or
			Constants.ItemNames.Bait.BoBoBerry or
			Constants.ItemNames.Bait.Fairy or
			Constants.ItemNames.Bait.Garlic or
			Constants.ItemNames.Bait.PalmNut or
			Constants.ItemNames.Bait.WrigglingWorm;
	}

	public static bool ItemIsBuildingMaterial(string itemName) {
		return itemName is
			Constants.ItemNames.BuildingMaterials.DriftWood or
			Constants.ItemNames.BuildingMaterials.Ectoplasm or
			Constants.ItemNames.BuildingMaterials.Fossil or
			Constants.ItemNames.BuildingMaterials.IronOre or
			Constants.ItemNames.BuildingMaterials.Obsidian or
			Constants.ItemNames.BuildingMaterials.RawCrystal or
			Constants.ItemNames.BuildingMaterials.RuneStone or
			Constants.ItemNames.BuildingMaterials.SandDollar or
			Constants.ItemNames.BuildingMaterials.Seashell or
			Constants.ItemNames.BuildingMaterials.Slime or
			Constants.ItemNames.BuildingMaterials.SoulGem or
			Constants.ItemNames.BuildingMaterials.Stone;
	}

	public static bool ItemIsConsumable(string itemName) {
		return itemName is
			Constants.ItemNames.Consumables.CheeseWedge or
			Constants.ItemNames.Consumables.HealthPotion or
			Constants.ItemNames.Consumables.HealthyApple or
			Constants.ItemNames.Consumables.PeaceBloom or
			Constants.ItemNames.Consumables.StaminaPotion or
			Constants.ItemNames.Consumables.StoneskinPotion or
			Constants.ItemNames.Consumables.StrengthPotion or
			Constants.ItemNames.Consumables.TalonMushroom;
	}

	public static bool ItemIsFish(string itemName) {
		return itemName is Constants.ItemNames.Fish.AmethystAngler or
			Constants.ItemNames.Fish.AshenSnapper or
			Constants.ItemNames.Fish.AzerimAnglerfish or
			Constants.ItemNames.Fish.BasicBass or
			Constants.ItemNames.Fish.BeheadedBarracuda or
			Constants.ItemNames.Fish.BelCathShark or
			Constants.ItemNames.Fish.BigMeatShieldFish or
			Constants.ItemNames.Fish.CodZombie or
			Constants.ItemNames.Fish.CommonCarp or
			Constants.ItemNames.Fish.Corpsebiter or
			Constants.ItemNames.Fish.DarkstoneTunnelHead or
			Constants.ItemNames.Fish.DarkwoodDaggertooth or
			Constants.ItemNames.Fish.DarkwoodDigger or
			Constants.ItemNames.Fish.DeepseaMauler or
			Constants.ItemNames.Fish.DolderothDreadscale or
			Constants.ItemNames.Fish.EastwatchEel or
			Constants.ItemNames.Fish.ElderWoefish or
			Constants.ItemNames.Fish.EmeraldEmperor or
			Constants.ItemNames.Fish.FeatheredFlounder or
			Constants.ItemNames.Fish.FyrefynFish or
			Constants.ItemNames.Fish.GarOfGradockh or
			Constants.ItemNames.Fish.GerdawnGrouper or
			Constants.ItemNames.Fish.GloomyLantern or
			Constants.ItemNames.Fish.GoldfishOfRahul or
			Constants.ItemNames.Fish.Grimtooth or
			Constants.ItemNames.Fish.HoneywoodAnglerfish or
			Constants.ItemNames.Fish.HoneywoodHerring or
			Constants.ItemNames.Fish.JollyJelly or
			Constants.ItemNames.Fish.LavacoreCatfish or
			Constants.ItemNames.Fish.LichfinEel or
			Constants.ItemNames.Fish.MagicCarp or
			Constants.ItemNames.Fish.MagmaMullet or
			Constants.ItemNames.Fish.MilUisceMahiMahi or
			Constants.ItemNames.Fish.Mimic or
			Constants.ItemNames.Fish.MurgolianMorbideye or
			Constants.ItemNames.Fish.NetherwindNeedlefish or
			Constants.ItemNames.Fish.ObsidianOxEye or
			Constants.ItemNames.Fish.Oyster or
			Constants.ItemNames.Fish.PickyPike or
			Constants.ItemNames.Fish.PistolPerch or
			Constants.ItemNames.Fish.RoseBrace or
			Constants.ItemNames.Fish.RubyRonquil or
			Constants.ItemNames.Fish.SapphireSalmon or
			Constants.ItemNames.Fish.ShadeSkipper or
			Constants.ItemNames.Fish.ShyShrimp or
			Constants.ItemNames.Fish.Skeletuna or
			Constants.ItemNames.Fish.Skullmaw or
			Constants.ItemNames.Fish.Slimefish or
			Constants.ItemNames.Fish.SlimySnail or
			Constants.ItemNames.Fish.SnakeFish or
			Constants.ItemNames.Fish.SouthwindAnchovy or
			Constants.ItemNames.Fish.SpectatorsGawker or
			Constants.ItemNames.Fish.ThilivernTurbot or
			Constants.ItemNames.Fish.TouletTuna or
			Constants.ItemNames.Fish.Unicod or
			Constants.ItemNames.Fish.VaerTorhanTrout or
			Constants.ItemNames.Fish.ValgothVampireCrab or
			Constants.ItemNames.Fish.VikendiCatfish or
			Constants.ItemNames.Fish.WaveWhisperer or
			Constants.ItemNames.Fish.WestEndCoveWolfFish;
	}

	public static bool ItemIsFishingRod(string itemName) {
		return itemName is
			Constants.ItemNames.FishingRods.AdvancedRod or
			Constants.ItemNames.FishingRods.AncientRod or
			Constants.ItemNames.FishingRods.BlackSmack or
			Constants.ItemNames.FishingRods.BonecallersRod or
			Constants.ItemNames.FishingRods.Crossrod or
			Constants.ItemNames.FishingRods.EssentialRod or
			Constants.ItemNames.FishingRods.ExGarlibur or
			Constants.ItemNames.FishingRods.GoldenRod or
			Constants.ItemNames.FishingRods.HackNSplash or
			Constants.ItemNames.FishingRods.HighSorcerersRod or
			Constants.ItemNames.FishingRods.KelpDigger or
			Constants.ItemNames.FishingRods.KingfishSlayer or
			Constants.ItemNames.FishingRods.LegendaryRod or
			Constants.ItemNames.FishingRods.NPCRod or
			Constants.ItemNames.FishingRods.OverpricedCosmeticItem or
			Constants.ItemNames.FishingRods.ProRod or
			Constants.ItemNames.FishingRods.SashimiMaster1000 or
			Constants.ItemNames.FishingRods.SeaStaff or
			Constants.ItemNames.FishingRods.TheBuckler or
			Constants.ItemNames.FishingRods.TheHeirloom or
			Constants.ItemNames.FishingRods.YorTolShum;
	}

	public static bool ItemIsHat(string itemName) {
		return itemName is Constants.ItemNames.Hats.BaelinsHat or
			Constants.ItemNames.Hats.BerserkCrown or
			Constants.ItemNames.Hats.BlackFishingHat or
			Constants.ItemNames.Hats.BodgersBowler or
			Constants.ItemNames.Hats.CapOfTheWoods or
			Constants.ItemNames.Hats.DragonhornHelmet or
			Constants.ItemNames.Hats.GnomeHat or
			Constants.ItemNames.Hats.GrandmasBonnet or
			Constants.ItemNames.Hats.GuardHelmet or
			Constants.ItemNames.Hats.HolyHayHat or
			Constants.ItemNames.Hats.LegendaryHat or
			Constants.ItemNames.Hats.MayorsPlumeHat or
			Constants.ItemNames.Hats.MiningHelmet or
			Constants.ItemNames.Hats.ObviousWizardHat or
			Constants.ItemNames.Hats.OldPirateHat or
			Constants.ItemNames.Hats.SketchySquareTop or
			Constants.ItemNames.Hats.TinfoilHat or
			Constants.ItemNames.Hats.WoodenBucket or
			Constants.ItemNames.Hats.Hat10 or
			Constants.ItemNames.Hats.Hat13;
	}

	public static bool ItemIsHook(string itemName) {
		return itemName is
			Constants.ItemNames.Hooks.DrillHook or
			Constants.ItemNames.Hooks.MagnetHook or
			Constants.ItemNames.Hooks.SimpleHook;
	}

	public static bool ItemIsHookAddon(string itemName) {
		return itemName is Constants.ItemNames.HookAddons.AnglingBud2000 or
			Constants.ItemNames.HookAddons.FishingPal5000 or
			Constants.ItemNames.HookAddons.GlimmerGarlic or
			Constants.ItemNames.HookAddons.HolyGarlic or
			Constants.ItemNames.HookAddons.WeakLight or
			Constants.ItemNames.HookAddons.WiggleFin;
	}

	public static bool ItemIsLine(string itemName) {
		return itemName is
			Constants.ItemNames.Lines.AdventurerLine or
			Constants.ItemNames.Lines.DiamondLine3000 or
			Constants.ItemNames.Lines.HoneywoodLine or
			Constants.ItemNames.Lines.ObsidianLine or
			Constants.ItemNames.Lines.RopeLine;
	}

	public static bool ItemIsNecklace(string itemName) {
		return itemName is Constants.ItemNames.Necklaces.AmuletOfArno or
			Constants.ItemNames.Necklaces.BaradunsSpareAmulet or
			Constants.ItemNames.Necklaces.ClericCollar or
			Constants.ItemNames.Necklaces.CompanyProperty or
			Constants.ItemNames.Necklaces.DarkwoodJewel or
			Constants.ItemNames.Necklaces.GildedAmuletOfRestitution or
			Constants.ItemNames.Necklaces.IconicNecklace or
			Constants.ItemNames.Necklaces.KalaborsEnchantment or
			Constants.ItemNames.Necklaces.LegendaryNecklace or
			Constants.ItemNames.Necklaces.LilShield or
			Constants.ItemNames.Necklaces.MuscleCharm or
			Constants.ItemNames.Necklaces.NeckbandOfChanneling or
			Constants.ItemNames.Necklaces.OverdriveOpal or
			Constants.ItemNames.Necklaces.PaladinsInsignia or
			Constants.ItemNames.Necklaces.SylwynPendant or
			Constants.ItemNames.Necklaces.TankOfCorrosion or
			Constants.ItemNames.Necklaces.None;
	}

	public static bool ItemIsRing(string itemName) {
		return itemName is
			Constants.ItemNames.Rings.DrakniteRing or
			Constants.ItemNames.Rings.DuelRing or
			Constants.ItemNames.Rings.LegendaryRing or
			Constants.ItemNames.Rings.MagicalMoodRing or
			Constants.ItemNames.Rings.RefreshingRing or
			Constants.ItemNames.Rings.RingOfBiggerEndurance or
			Constants.ItemNames.Rings.RingOfDormor or
			Constants.ItemNames.Rings.RingOfEndlessEndurance or
			Constants.ItemNames.Rings.RingOfEndurance or
			Constants.ItemNames.Rings.RingOfFastRestoration or
			Constants.ItemNames.Rings.RingOfGreatRecovery or
			Constants.ItemNames.Rings.RingOfRecovery or
			Constants.ItemNames.Rings.RingOfRestoration or
			Constants.ItemNames.Rings.SpectralRing or
			Constants.ItemNames.Rings.None or
			Constants.ItemNames.Rings.StrengthRing or
			Constants.ItemNames.Rings.Boss2Ring;
	}

	public static bool ItemIsSail(string itemName) {
		return itemName is
			Constants.ItemNames.Sails.BasicSail or
			Constants.ItemNames.Sails.IconicSail or
			Constants.ItemNames.Sails.ThatShitsDingoSail or
			Constants.ItemNames.Sails.WormsSail or
			Constants.ItemNames.Sails.Stripes;
	}
}

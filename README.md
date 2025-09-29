# Nice Day For Fishing – Mod Collection

This repository contains my BepInEx IL2CPP mods for the game [Nice Day For Fishing](https://store.steampowered.com/app/2393160/Nice_Day_for_Fishing/).

# Fish Stars Modifier

## What It Does
Quite simple. It sets all fish to 5★! The achievement to get a 5★ fish for every fish in the game is a bit too grindy for me since the star rating is entirely RNG based. This mod makes it so that every fish you catch is 5★, making it much easier to complete the collection.

## Side Effects / Balance Notes
- Economy will accelerate because the price of the fish when sold is affected by the star rating of the fish.
- May trivialize collection goals and any systems scaling with rarity.

## Extensibility Ideas (Future)
- Add configurable custom percentages for what star the fish is. 20% chance for 1 star, 30% for 2 star, etc.

---

# Instant Win Fishing

## What It Does
As soon as you hook a fish, it deals enough damage to the fish to win the encounter immediately. It should work on bosses too, but I did not test that.

## Side Effects / Balance Notes
- Completely removes the active battle gameplay loop.
- Great for rapid testing / collection completion. Not recommended for normal progression.

---

# Configuration
Each mod creates a config file when you run the game at: `<Your Game Folder>\BepInEx\config\`

Current exposed option (same pattern in both files):
```
[Feature Toggles]
EnableMod = true   # Set to false to disable the mod without removing the DLL
```
You will be able to change the value while the game is running. For the fish stars mod, it will only affect newly spawned fish. Instant win will be reflected immediately.

# Installing the Mods
1. Download the latest **BepInEx 6** for IL2CPP for your OS from their [downloads page](https://builds.bepinex.dev/projects/bepinex_be) if you have not already.
    * At the time of this writing, the latest version is 6.0.0-pre.2. These mods were built against that version and are guaranteed to work only with that version.
    * Windows -> https://builds.bepinex.dev/projects/bepinex_be/738/BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.738%2Baf0cba7.zip
    * MacOS -> https://builds.bepinex.dev/projects/bepinex_be/738/BepInEx-Unity.IL2CPP-macos-x64-6.0.0-be.738%2Baf0cba7.zip
    * Linux -> https://builds.bepinex.dev/projects/bepinex_be/738/BepInEx-Unity.IL2CPP-linux-x64-6.0.0-be.738%2Baf0cba7.zip
2. Follow [BepInEx instructions](https://docs.bepinex.dev/master/articles/user_guide/installation/unity_il2cpp.html). You should end up with a `BepInEx` folder alongside the game executable.
3. Place the mod's DLL into the `<Your Game Folder>\BepInEx\plugins\` folder.
4. Launch the game. Verify in `<Your Game Folder>\BepInEx\LogOutput.log` that the mod reports as loaded.
5. (Optional) Edit the config files to disable the mod without deleting it.

# Uninstalling the Mods
Remove the corresponding DLL(s) from `<Your Game Folder>\BepInEx\plugins\` and optionally delete their `.cfg` files under `<Your Game Folder>\BepInEx\config`.

# Troubleshooting
1. Enable BepInEx debug logs (set `LogLevel=All` in `BepInEx.cfg` in the `[Logging.Disk]` section)
2. Run the game and reproduce the issue.
3. Add the log file to the Issue you open.

# Disclaimer
These mods strongly alter intended gameplay progression. Use only for testing, accessibility, or experimentation. Not affiliated with the original game developers.

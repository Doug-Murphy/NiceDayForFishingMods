using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace GuysNight.NiceDayForFishingMod.InstantWin;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public override void Load()
    {
        SharedComponents.Logger = Log;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        SharedComponents.Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        SharedComponents.ConfigFile = new ConfigFile(Path.Combine(Paths.ConfigPath, $"{MyPluginInfo.PLUGIN_NAME}.cfg"), true) { SaveOnConfigSet = false };
        
        SharedComponents.ConfigFile.Bind(
            Constants.ConfigSectionHeaderToggles,
            Constants.ConfigKeyEnableMod,
            true,
            "Whether or not to enable this mod. True for enabling the mod. False for disabling."
        );
        
        SharedComponents.ConfigFile.Save();
    }
}

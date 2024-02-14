using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using System;

namespace DWNO_UnlockAllRequirements;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public static Plugin Instance;
  public override void Load()
  {
    Instance = this;

    // Plugin startup logic
    Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    Harmony.CreateAndPatchAll(typeof(Patches));
  }
}

using BepInEx;
using BepInEx.Logging;

namespace Template
{

    [BepInPlugin("your.unique.guid", "Template Mod", "1.0.0")]

    [BepInProcess("Assembly Line 2 Desktop.exe")]

    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;

        private void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;
            Logger.LogInfo($"Template Plugin is loaded!");
        }
    }
}

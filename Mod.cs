using System.Linq;
using System.Reflection;
using KitchenLib;
using KitchenLib.Interfaces;
using KitchenLib.Logging;
using KitchenLib.Logging.Exceptions;
using KitchenMods;
using UnityEngine;

namespace Fireworks
{
    public class Mod : BaseMod, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.fireworks";
        public const string MOD_NAME = "Champagne";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.1.8";

        public static AssetBundle Bundle;
        public static KitchenLogger Logger;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();
            
        }
    }
}


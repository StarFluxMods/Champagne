using Fireworks.Customs.Appliances;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.Items
{
    public class Glass : CustomItem
    {
        public override string UniqueNameID => "Glass";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Glass").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOUtils.GetCustomGameDataObject<SourceGlass>().GameDataObject as Appliance;
    }
}
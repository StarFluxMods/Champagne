using Fireworks.Customs.Appliances;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.Items
{
    public class ChampagneBottle : CustomItem
    {
        public override string UniqueNameID => "ChampagneBottle";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChampagneBottle").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOUtils.GetCustomGameDataObject<SourceChampagne>().GameDataObject as Appliance;
    }
}
using System.Collections.Generic;
using Fireworks.Customs.Items;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.Appliances
{
    public class SourceChampagne : CustomAppliance
    {
        public override string UniqueNameID => "SourceChampagne";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SourceChampagne").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty> { KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<ChampagneBottle>().ID)};

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (Locale.English, LocalisationUtils.CreateApplianceInfo("Champagne", "Provides Champagne", new List<Appliance.Section>{}, new List<string>{}))
        };
    }
}
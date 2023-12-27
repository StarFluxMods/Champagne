using System.Collections.Generic;
using Fireworks.Customs.Items;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.Appliances
{
    public class SourceGlass : CustomAppliance
    {
        public override string UniqueNameID => "SourceGlass";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SourceGlass").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty> { KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<Glass>().ID)};

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (Locale.English, LocalisationUtils.CreateApplianceInfo("SourceGlass", "Provides Glasses", new List<Appliance.Section>{}, new List<string>{}))
        };
    }
}
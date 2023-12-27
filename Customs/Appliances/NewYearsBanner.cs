using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.Appliances
{
    public class NewYearsBanner : CustomAppliance
    {
        public override string UniqueNameID => "NewYearsBanner";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("NewYearsBanner").AssignMaterialsByNames();
        public override ShoppingTags ShoppingTags => ShoppingTags.SpecialEvent;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Free;
        public override OccupancyLayer Layer => OccupancyLayer.Wall;
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CMustHaveWall()
        };

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (Locale.English, LocalisationUtils.CreateApplianceInfo("New Years Banner", "Celebrations!", new List<Appliance.Section>{}, new List<string>{}))
        };
    }
}
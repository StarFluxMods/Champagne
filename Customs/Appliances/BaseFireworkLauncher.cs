using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.Appliances
{
    public abstract class BaseFireworkLauncher : CustomAppliance
    {
        protected abstract string FireworkName { get; }
        public override string UniqueNameID =>  FireworkName + "FireworkLauncher";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>(FireworkName + "FireworkLauncher").AssignMaterialsByNames();
        public override ShoppingTags ShoppingTags => ShoppingTags.SpecialEvent;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Free;

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (Locale.English, LocalisationUtils.CreateApplianceInfo(FireworkName + " Fireworks", "Add a little sparkle!", new List<Appliance.Section>{}, new List<string>{}))
        };
    }
}
using System.Collections.Generic;
using Fireworks.Customs.ItemGroups;
using Fireworks.Customs.Items;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.Dishes
{
    public class Champagne : CustomDish
    {
        public override string UniqueNameID => "Champagne";
        
		public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
		public override bool IsUnlockable => false;
		public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
		public override CardType CardType => CardType.Default;
		public override DishCustomerChange CustomerMultiplier => DishCustomerChange.LargeIncrease;
		public override DishType Type => DishType.Base;
		
		public override List<string> StartingNameSet => new()
		{
			"Happy New Year!",
		};
		
		public override HashSet<Item> MinimumIngredients => new()
		{
			GDOUtils.GetCustomGameDataObject<Glass>().GameDataObject as Item,
			GDOUtils.GetCustomGameDataObject<ChampagneBottle>().GameDataObject as Item,
		};

		public override bool RequiredNoDishItem => true;
		public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("ChampagneIcon").AssignMaterialsByNames();
		public override int Difficulty => 1;
		public override GameObject DisplayPrefab => Mod.Bundle.LoadAsset<GameObject>("ChampagneIcon").AssignMaterialsByNames();
		
		public override List<Dish.MenuItem> ResultingMenuItems => new()
		{
			new Dish.MenuItem
			{
				Item = GDOUtils.GetCustomGameDataObject<ChampagneGlass>().GameDataObject as ItemGroup,
				Phase = MenuPhase.Dessert,
				Weight = 1,
				DynamicMenuType = DynamicMenuType.Static,
				DynamicMenuIngredient = null
			}
		};
		public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new()
		{
			new Dish.IngredientUnlock
			{
				MenuItem = GDOUtils.GetCustomGameDataObject<ChampagneGlass>().GameDataObject as ItemGroup,
				Ingredient = GDOUtils.GetCustomGameDataObject<ChampagneBottle>().GameDataObject as Item
			},
			new Dish.IngredientUnlock
			{
				MenuItem = GDOUtils.GetCustomGameDataObject<ChampagneGlass>().GameDataObject as ItemGroup,
				Ingredient = GDOUtils.GetCustomGameDataObject<Glass>().GameDataObject as Item
			}
		};
		public override bool IsAvailableAsLobbyOption => true;

		public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Pour some Champagne into a glass, and serve!" }
        };

        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
	        (Locale.English, LocalisationUtils.CreateUnlockInfo("Champagne", "Adds Champagne as a Dessert", "Happy New Year!"))
        };
    }
}
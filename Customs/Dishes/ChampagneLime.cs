using System.Collections.Generic;
using Fireworks.Customs.ItemGroups;
using Fireworks.Customs.Items;
using IngredientLib.Ingredient.Items;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;

namespace Fireworks.Customs.Dishes
{
    public class ChampagneLime : CustomDish
    {
        public override string UniqueNameID => "ChampagneLime";
        
		public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
		public override bool IsUnlockable => true;
		public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
		public override CardType CardType => CardType.Default;
		public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
		public override DishType Type => DishType.Extra;
		public override int Difficulty => 1;

		public override List<Unlock> HardcodedRequirements => new List<Unlock>
		{
			GDOUtils.GetCustomGameDataObject<Champagne>().GameDataObject as Dish
		};

		public override HashSet<Item> MinimumIngredients => new()
		{
			GDOUtils.GetCustomGameDataObject<Glass>().GameDataObject as Item,
			GDOUtils.GetCustomGameDataObject<ChampagneBottle>().GameDataObject as Item,
			GDOUtils.GetCustomGameDataObject<Lime>().GameDataObject as Item,
		};
		
		public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new()
		{
			new Dish.IngredientUnlock
			{
				MenuItem = GDOUtils.GetCustomGameDataObject<ChampagneGlass>().GameDataObject as ItemGroup,
				Ingredient = GDOUtils.GetCustomGameDataObject<ChoppedLime>().GameDataObject as Item
			}
		};
		public override bool RequiredNoDishItem => true;

		public override Dictionary<Locale, string> Recipe => new()
        {
            { Locale.English, "Chop and add some lime!" }
        };

        public override List<(Locale, UnlockInfo)> InfoList => new()
        {
	        (Locale.English, LocalisationUtils.CreateUnlockInfo("Champagne - Lime", "Adds Lime to Champagne", "Happy New Year!"))
        };
    }
}
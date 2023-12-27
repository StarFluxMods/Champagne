using System.Collections.Generic;
using Fireworks.Customs.Items;
using IngredientLib.Ingredient.Items;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.ItemGroups
{
    public class ChampagneGlass : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "ChampagneGlass";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChampagneGlass").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOUtils.GetCustomGameDataObject<Glass>().GameDataObject as Item,
                },
                Max = 1,
                Min = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOUtils.GetCustomGameDataObject<ChampagneBottle>().GameDataObject as Item
                },
                Max = 1,
                Min = 1
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOUtils.GetCustomGameDataObject<ChoppedLime>().GameDataObject as Item
                },
                Max = 1,
                Min = 0,
                RequiresUnlock = true
            }
        };

        public override List<ItemGroupView.ColourBlindLabel> Labels => new()
        {
            new ItemGroupView.ColourBlindLabel
            {
                Item = GDOUtils.GetCustomGameDataObject<ChoppedLime>().GameDataObject as Item,
                Text = "Li"
            }
        };
        
        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ItemGroupView view = gameDataObject.Prefab.GetComponent<ItemGroupView>();
            
            view.ComponentGroups = new List<ItemGroupView.ComponentGroup> {
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(gameDataObject.Prefab, "ChampagneGlass/Glass"),
                    Item = GDOUtils.GetCustomGameDataObject<Glass>().GameDataObject as Item
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(gameDataObject.Prefab, "ChampagneGlass/Liquid"),
                    Item = GDOUtils.GetCustomGameDataObject<ChampagneBottle>().GameDataObject as Item
                },
                new()
                {
                    GameObject = GameObjectUtils.GetChildObject(gameDataObject.Prefab, "Lime"),
                    Item = GDOUtils.GetCustomGameDataObject<ChoppedLime>().GameDataObject as Item
                }
            };
        }
    }
}
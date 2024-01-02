using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace Fireworks.Customs.PlayerCosmetics
{
    public class NYEPartyHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "NYEPartyHat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("NYEPartyHat").AssignMaterialsByNames().AssignVFXByNames();
        public override bool BlockHats => true;

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            PlayerOutfitComponent playerOutfitComponent = gameDataObject.Visual.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "HatPonPons").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "HatCone").GetComponent<SkinnedMeshRenderer>());
        }
    }
}